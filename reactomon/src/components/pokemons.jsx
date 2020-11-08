import React, { Component } from "react";
import axios from 'axios';
import {NavLink} from 'react-router-dom';
// import "./navbar.css";
// import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
 
export default class Pokemons extends Component {
    state = {
        pokemons: []
    }

    componentDidMount() {
        axios.get(`https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100`)
          .then(res => {
            const pokemons = res.data.results;
            console.log(this.state.pokemons);
            console.log(pokemons.results);
            this.setState({ pokemons });
          })
      }

    render() {
        return (
        <React.Fragment>
            <ul>
                { this.state.pokemons.map(pokemon => <li><NavLink to={"pokemon/" + pokemon.url.slice(-2)}>{pokemon.name}</NavLink></li>)}
            </ul>
        </React.Fragment>
        );
    }
}