import { useMsal } from "@azure/msal-react";
import { Box, Button, Card, CardContent, Typography } from "@mui/material";

const LoginButton = () => {
    const { instance } = useMsal();
 
    
    const handleLogin = async () => {
      try {
        const loginResponse = await instance.loginPopup();
        instance.setActiveAccount(loginResponse.account);
       
      } catch (error) {
        console.error("Login failed", error);
      }
    };
  
    return (
      <Button
        variant="contained"
        color="primary"
        size="large"
        onClick={handleLogin}
        sx={{
          mt: 2,
          px: 4,
          py: 1.5,
          textTransform: "none",
          fontSize: "1rem",
        }}
      >
        Login
      </Button>
    );
  };

  const LoginPage = () => (
    <Box
      sx={{
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        height: "100vh",
        backgroundColor: "#f0f4f8",
        padding: 2,
      }}
    >
      <Card
        sx={{
          maxWidth: 420,
          p: 4,
          boxShadow: "0px 4px 20px rgba(0, 0, 0, 0.1)",
          borderRadius: 3,
          backgroundColor: "white",
        }}
      >
        <CardContent>
          <Typography
            variant="h4"
            sx={{
              fontWeight: "bold",
              mb: 2,
              color: "#3f51b5",
            }}
          >
            Welcome to Dustin!
          </Typography>
          <Typography
            variant="body1"
            sx={{
              mb: 4,
              color: "#757575",
            }}
          >
            Please log in to access your account and manage your products.
          </Typography>
          <LoginButton />
        </CardContent>
      </Card>
    </Box>
  );

export default LoginPage;