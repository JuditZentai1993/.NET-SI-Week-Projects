import React, { Component } from "react";
import axios from 'axios';
// import "./navbar.css";
// import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
 
export default class PokemonDetails extends Component {
    // state = {
    //     pokemons: []
    // }

    // componentDidMount() {
    //     axios.get(`https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100`)
    //       .then(res => {
    //         const pokemons = res.data.results;
    //         console.log(this.state.pokemons);
    //         console.log(pokemons.results);
    //         this.setState({ pokemons });
    //       })
    //   }

    render() {
        return (
            <p>hello poke details!</p>
        )
    //     return (
    //     <React.Fragment>
    //         <ul>
    //             { this.state.pokemons.map(pokemon => <li>{pokemon.name}</li>)}
    //         </ul>
    //     </React.Fragment>
    //     );
    }
}