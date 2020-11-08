import './App.css';
import React from "react";
import NavBar from "./components/navbar";
import Home from './components/home';
import Pokemons from './components/pokemons';
import Types from './components/types';
import PokemonDetails from './components/pokemon_details';
import "./App.css";
import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';

function App() {
    return (
      <Router>
        <div>
          
          <NavBar/>

            <Switch>

              <Route exact path="/" component={Home}/>
              <Route path="/pokemons" component={Pokemons}/>
              <Route path="/types" component={Types}/>
              
              <Switch>
                <Route path="/pokemon/:id" component={PokemonDetails}/>
              </Switch>

            </Switch>

        </div>
      </Router>
    );
  }

export default App;