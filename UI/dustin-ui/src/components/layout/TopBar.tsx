import React from "react";
import AppBar from "@mui/material/AppBar";
import Toolbar from "@mui/material/Toolbar";
import Typography from "@mui/material/Typography";
import Button from "@mui/material/Button";
import { useMsal } from "@azure/msal-react";

const TopBar = () => {
  const { instance } = useMsal();

  const handleLogout = async () => {
    try {
      await instance.logoutRedirect();
    } catch (error) {
      console.error("Logout failed", error);
    }
  };

  return (
    <AppBar position="sticky" sx={{
      background: "linear-gradient(to right, #0d47a1, #4a148c)", 
      color: "#ffffff",
    }}>
      <Toolbar>
        <Typography variant="h6" sx={{ flexGrow: 1 }}>
          Dustin
        </Typography>
        <Button color="inherit" onClick={handleLogout}>
          Logout
        </Button>
      </Toolbar>
    </AppBar>
  );
};

export default TopBar;
