import React, { Component } from "react";
import "./navbar.css";
import Pokemons from "./pokemons";
import {BrowserRouter as Router, NavLink, Route, Switch} from 'react-router-dom';
 
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
        <Router>
          <nav className="navbar" onClick={this.showMenuItems}>
              <div>Menu</div>
          </nav>
          <nav className="navbar menu-items hide-menu-items">
            <Switch>
                <div><NavLink to="/pokemons"> Pokemons </NavLink></div>
                <Route path="/pokemons" component={Pokemons}/>
            </Switch>
          </nav>
        </Router>
      </React.Fragment>
    );
  }}
 
export default NavBar;