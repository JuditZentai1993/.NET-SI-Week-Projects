import React, { Component } from "react";
import "./home.css";
// import "./navbar.css";
// import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
 
class Home extends Component {
  render() {
    return (
      <React.Fragment>
        <div className="welcome-text">Here you can find all the pokemons, types, and detailed description of a certain pokemon!</div>
      </React.Fragment>
    );
  }}
 
export default Home;