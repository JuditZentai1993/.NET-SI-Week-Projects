import React, { Component } from "react";
import axios from 'axios';
 
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
            <ul>
                { this.state.types.map(type => <li key={type.name}>{type.name}</li>)}
            </ul>
        </React.Fragment>
        );
    }
}
 
export default Types;