import React, { Component } from "react";
import axios from 'axios';
// import "./navbar.css";
// import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
 
class Types extends Component {
    state = {
        types: []
    }

    componentDidMount() {
        axios.get(`https://pokeapi.co/api/v2/type`)
          .then(res => {
            const types = res.data.results;
            console.log(this.state.types);
            console.log(types.results);
            this.setState({ types });
          })
      }

    render() {
        return (
        <React.Fragment>
            <ul>
                { this.state.types.map(pokemon => <li>{pokemon.name}</li>)}
            </ul>
        </React.Fragment>
        );
    }
}
 
export default Types;