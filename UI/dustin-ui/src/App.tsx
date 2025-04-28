import React, { useEffect } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Layout from "./components/layout/Layout";
import ProductsPage from "./components/products/ProductsPage";
import { AuthenticatedTemplate, MsalProvider, UnauthenticatedTemplate } from "@azure/msal-react";
import { IPublicClientApplication } from "@azure/msal-browser";
import { AuthProvider } from "./auth/AuthProvider";
import LoginPage from "./auth/LoginPage";
import NotFoundPage from "./components/common/NotFound";


type AppProps = {
  msalInstance: IPublicClientApplication;
};

const Pages = () => {
  return (

    <Router>
      <Layout>
        <Routes>
          <Route path="/" element={<ProductsPage />} />
          <Route path="*" element={<NotFoundPage />} />
        </Routes>
      </Layout>
    </Router>

  );
}

const App = ({ msalInstance }: AppProps) => {

  useEffect(() => {
    const activeAccount = msalInstance.getActiveAccount();
    if (!activeAccount && msalInstance.getAllAccounts().length > 0) {
      msalInstance.setActiveAccount(msalInstance.getAllAccounts()[0]);
    }
  }, [msalInstance]);

  return (
    <MsalProvider instance={msalInstance}>
      <AuthenticatedTemplate>
        <AuthProvider msalInstance={msalInstance}>
          <Pages />
        </AuthProvider>
      </AuthenticatedTemplate>
      <UnauthenticatedTemplate>
        <LoginPage />
      </UnauthenticatedTemplate>
    </MsalProvider>

  )

};

export default App;
