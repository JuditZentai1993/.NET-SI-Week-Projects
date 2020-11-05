import React, { Component } from "react";
import "./navbar.css";
 
class NavBar extends Component {
  showMenuItems() {
    const menuItems = document.querySelector(".menu-items");
    if (!menuItems.classList.contains("clicked")){
      menuItems.classList.replace("hide-menu-items", "show-menu-items");
      menuItems.classList.add("clicked");
    }
    else {
      menuItems.classList.replace("show-menu-items", "hide-menu-items");
      menuItems.classList.remove("clicked");
    }

  }
  render() {
    return (
      <React.Fragment>
        <nav className="navbar" onClick={this.showMenuItems}>
            <div>Menu</div>
            <div className="menu-items hide-menu-items">
              <div>Show me Pokemons!</div>
              <div>Show me Pokemon Types!</div>
            </div>
        </nav>
      </React.Fragment>
    );
  }}
 
export default NavBar;