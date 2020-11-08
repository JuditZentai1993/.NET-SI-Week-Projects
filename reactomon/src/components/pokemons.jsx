import React, { Component } from "react";
import axios from 'axios';
import {NavLink} from 'react-router-dom';
 
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
            <ul>
                { this.state.pokemons.map(pokemon => <li key={pokemon.name}><NavLink to={"pokemon/" + pokemon.url.slice(34,pokemon.url.length)}>{pokemon.name}</NavLink></li>)}
            </ul>
        </React.Fragment>
        );
    }
}