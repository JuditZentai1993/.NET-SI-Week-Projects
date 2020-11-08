import React, { Component } from "react";
import axios from 'axios';
import {NavLink} from 'react-router-dom';
import "./pokemons.css";
 
export default class Pokemons extends Component {
    state = {
        pokemons: []
    }

    componentDidMount() {
        axios.get(`https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100`)
          .then(res => {
            const pokemons = res.data.results;
            this.setState({ pokemons });
          })
      }

    render() {
        return (
        <React.Fragment>
            <div className="pokemons">
                { this.state.pokemons.map(pokemon => <div className="pokemon" key={pokemon.name}><NavLink to={"pokemon/" + pokemon.url.slice(34,pokemon.url.length)}>{pokemon.name}</NavLink></div>)}
            </div>
        </React.Fragment>
        );
    }
}