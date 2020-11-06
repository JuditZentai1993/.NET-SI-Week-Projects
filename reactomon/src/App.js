import './App.css';
import React, { Component } from "react";
import NavBar from "./components/navbar";
import Home from './components/home';
import Pokemons from './components/pokemons';
import Types from './components/types';
import "./App.css";
import {BrowserRouter as Router, NavLink, Route, Switch} from 'react-router-dom';

function App() {
    return (
      <Router>
        <div>
          
          <NavBar/>

            <Switch>

              <Route exact path="/" component={Home}/>
              <Route path="/pokemons" component={Pokemons}/>
              <Route path="/types" component={Types}/>

            </Switch>

        </div>
      </Router>
    );
  }

export default App;