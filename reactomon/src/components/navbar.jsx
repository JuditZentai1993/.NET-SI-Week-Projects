import React, { Component } from "react";
import "./navbar.css";
import {NavLink} from 'react-router-dom';
 
class NavBar extends Component {
  render() {
    return (
      <div className="Nav">
        <nav>
          <ul className="nav-links">

            <li><NavLink to="/"> Home </NavLink></li>
            <li><NavLink to="/pokemons"> Pokemons </NavLink></li>
            <li><NavLink to="/types"> Types </NavLink></li>

          </ul>
        </nav>
      </div>
    );
  }}
 
export default NavBar;