import './App.css';
import React, { Component } from "react";
import NavBar from "./components/navbar";
import "./App.css";

class App extends Component {
  render() {
    return (
      <React.Fragment>
        <h1> Welcome to Reactomon!</h1>
        <NavBar
        />
      </React.Fragment>
    );
  }
}
 
export default App;