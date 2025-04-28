import React, { ReactNode, useState, useEffect, createContext, useContext } from 'react';
import { IPublicClientApplication } from '@azure/msal-browser';
import { loginRequest } from '../authConfig';

type AuthContextType = {
  token: string | null;
  setToken: React.Dispatch<React.SetStateAction<string | null>>;
};

const AuthContext = createContext<AuthContextType | undefined>(undefined);
export const AuthConsumer = AuthContext.Consumer;

type Props = { children: ReactNode, msalInstance: IPublicClientApplication };

export const AuthProvider = (props: Props) => {

  const [token, setToken] = useState<string | null>(null);

  useEffect(() => {
    const fetchToken = async () => {
      try {
        const response = await props.msalInstance.acquireTokenSilent({
          scopes: loginRequest.scopes,
          account: props.msalInstance.getAllAccounts()[0]
        });
        setToken(response.accessToken);
        localStorage.setItem("accessToken", response.accessToken); // Store the token for use in the interceptor
      } catch (error) {
        console.error("Failed to acquire token", error);
      }
    };

    fetchToken();
  }, [props.msalInstance]);


  return <AuthContext.Provider
    value={{
      token, setToken
    }}
  >
    {props.children}
  </AuthContext.Provider>

};

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) {
    throw new Error("useAuth must be used within an AuthProvider");
  }
  return context;
};
