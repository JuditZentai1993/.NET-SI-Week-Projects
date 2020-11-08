import React, { Component } from "react";
import axios from 'axios';
import "./pokemon_details.css"

 
export default class PokemonDetails extends Component {

    state = {
        abilities: [],
        baseExperience: Number,
        height: Number,
        weight: Number,
        name: String
    }

    componentDidMount() {
        let id = this.props.match.params.id;
        axios.get('https://pokeapi.co/api/v2/pokemon/'+ id)
          .then(res => {
            const abilities = res.data.abilities.map( ability => ability.ability.name );
            console.log(res.data);
            this.setState({ abilities });
            const baseExperience = res.data.base_experience;
            this.setState({ baseExperience });
            const height = res.data.height;
            this.setState({ height });
            const weight = res.data.weight;
            this.setState({ weight });
            const name = res.data.name;
            this.setState({ name });
          })
      }

    render() {
        const abilities = [];
        for (let value of this.state.abilities) {
            abilities.push(<li key={value}>{value}</li>)
          }
        
        return (
            <React.Fragment>
                <h2>{this.state.name}</h2>
            <ul className="details">
                <li>Abilities:</li>
                    <ul>
                        {abilities}
                    </ul>
                <li>Base experience:</li>
                    <ul>
                        <li>{this.state.baseExperience}</li>
                    </ul>
                <li>Height:</li>
                    <ul>
                        <li>{this.state.height}</li>
                    </ul>
                <li>Weight:</li>
                    <ul>
                        <li>{this.state.weight}</li>
                    </ul>
            </ul>
            </React.Fragment>
        )
    }
}