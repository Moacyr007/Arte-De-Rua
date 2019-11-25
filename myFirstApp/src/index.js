import React, { Component } from 'react';
import {
  StyleSheet,
  View,
  Text,
  Button,
} from 'react-native';

import Todo from './components/Todo';


export default class App extends Component {
  state = {
    todos: [
      { id: 0, text: 'Fazer café'},
      { id: 1, text: 'Estudar'},
      { id: 2, text: 'Dormir'},
    ],
  };

  addTodo = () => {
    this.setState({ 
      todos: [...this.state.todos, 'Novo todo']
    })
  }

  render(){
    return (
      <>
        <View style={styles.container}>
          
          { this.state.todos.map(todo => {
            return <Todo key={todo.id}title={todo.text}/>
          }) }
          <Button title="Adicionar todo" onPress={this.addTodo} />
        </View>
      </>
    );
  }
}


const styles = StyleSheet.create({
  container: {
    backgroundColor: '#999',
  },
});

