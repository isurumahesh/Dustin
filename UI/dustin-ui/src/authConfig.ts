import { Configuration, PopupRequest } from "@azure/msal-browser";

// Config object to be passed to Msal on creation
export const msalConfig: Configuration = {
    auth: {
        clientId: "e8ce7379-20a9-465b-ba44-6d8756bdb481",
        authority: "https://login.microsoftonline.com/isuruwick21gmail.onmicrosoft.com",
        redirectUri: "/",
        postLogoutRedirectUri: "/"
    },
};

// Add here scopes for id token to be used at MS Identity Platform endpoints.
export const loginRequest: PopupRequest = {
    scopes: ["api://9054b3e5-74ac-4898-8518-9b4949d7cfa8/AdminAccess"]
};

// Add here the endpoints for MS Graph API services you would like to use.
export const graphConfig = {
    graphMeEndpoint: "https://graph.microsoft.com/v1.0/me"
};
