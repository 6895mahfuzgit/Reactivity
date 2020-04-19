import React, { Component } from "react";
import "./App.css";
import axios from "axios";
import { Header, Icon, List } from "semantic-ui-react";

class App extends Component {
  state = {
    values: [],
  };

  componentDidMount() {
    axios.get("http://localhost:12233/api/Values").then((response) => {
      
      this.setState({
        values: response.data.values,
      });
    });
    
  }

  render() {
    return (
      <div>
        <Header as="h2">
          <Icon name="users" />
          <Header.Content>Reactivity</Header.Content>
        </Header>
        <List>
          {this.state.values.map((item: any) => (
            <List.Item key={item.id}>{item.name}</List.Item>
          ))}
        </List>
      </div>
    );
  }
}

export default App;
