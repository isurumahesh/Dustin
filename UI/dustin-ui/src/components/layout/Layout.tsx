import React from "react";
import Box from "@mui/material/Box";

import TopBar from "./TopBar";
import SideNav from "./SideNav";

interface LayoutProps {
  children: React.ReactNode;
}

const Layout: React.FC<LayoutProps> = ({ children }) => {
  return (
    <Box sx={{ display: "flex" }}>
      <SideNav />
      <Box sx={{ flexGrow: 1, display: "flex", flexDirection: "column" }}>
        <TopBar />
        <Box sx={{ padding: 2 }}>{children}</Box>
      </Box>
    </Box>
  );
};

export default Layout;
