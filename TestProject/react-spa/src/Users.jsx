import { GetUsers } from '../src/api/user.js';
import React from 'react';
import axios from 'axios';


class Users extends React.Component {

  state = {
    userCollection: []
  }

  componentDidMount() {
    GetUsers().then(res => {
      const userCollection = res.userCollection;
      console.log(userCollection);
      this.setState({ userCollection });
      console.log(this.state.userCollection);
    }).catch(console.log(5));
  }

  render() {
    return (
      <div style={{display:'flex' ,justifyContent:'center'}}>
        <ul>
          {this.state.userCollection.map(person => <h1 key={person.id}>{person.name}</h1>)}
        </ul>
      </div>

    )
  }
}

export default Users