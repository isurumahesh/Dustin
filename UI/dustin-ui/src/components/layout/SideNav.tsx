import React from "react";
import Drawer from "@mui/material/Drawer";
import List from "@mui/material/List";
import ListItem from "@mui/material/ListItem";
import ListItemButton from "@mui/material/ListItemButton";
import ListItemText from "@mui/material/ListItemText";
import { Link } from "react-router-dom";

const SideNav: React.FC = () => {
  return (
    <Drawer
      variant="permanent"
      anchor="left"
      sx={{
        width: 240,
        flexShrink: 0,
        "& .MuiDrawer-paper": {
          width: 240,
          background: "linear-gradient(to bottom, #0d47a1, #4a148c)",
          color: "#ffffff",
        },
      }}
    >
      <List sx={{ width: 240 }}>
        <ListItem disablePadding>
          <ListItemButton component={Link} to="/" sx={{
            backgroundColor: "#ffffff",
            color: "#0d47a1",
            borderRadius: "8px",
            margin: "8px",
            "&:hover": {
              backgroundColor: "#e3f2fd",
            },
          }}>
            <ListItemText primary="All Products" />
          </ListItemButton>
        </ListItem>


      </List>
    </Drawer>
  );
};

export default SideNav;
