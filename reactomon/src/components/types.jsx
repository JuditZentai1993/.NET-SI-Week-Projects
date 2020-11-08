import React, { Component } from "react";
import axios from 'axios';
import "./pokemons.css";
 
class Types extends Component {
    state = {
        types: []
    }

    componentDidMount() {
        axios.get(`https://pokeapi.co/api/v2/type`)
          .then(res => {
            const types = res.data.results;
            this.setState({ types });
          })
      }

    render() {
        return (
        <React.Fragment>
            <div className="types">
                { this.state.types.map(type => <div className="type" key={type.name}>{type.name}</div>)}
            </div>
        </React.Fragment>
        );
    }
}
 
export default Types;