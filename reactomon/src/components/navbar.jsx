import React, { Component } from "react";
import "./navbar.css";
import {NavLink} from 'react-router-dom';
 
class NavBar extends Component {
  render() {
    return (
      <div className="Nav">
        <nav>
          <div className="nav-links">

            <span><NavLink to="/"> Home </NavLink></span>
            <span><NavLink to="/pokemons"> Pokemons </NavLink></span>
            <span><NavLink to="/types"> Types </NavLink></span>

          </div>
        </nav>
      </div>
    );
  }}
 
export default NavBar;