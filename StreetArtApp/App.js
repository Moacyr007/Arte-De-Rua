import React, { Component } from 'react';
import { 
  StyleSheet, 
  Text, 
  View,
  Button
} from 'react-native';

import Arte from './src/componets/Arte'
import FormTeste from './src/componets/FormTeste'
export default class App extends Component {
  state = {
    artes:[
      {id: 0, nome: 'Arte1'},
      {id: 1, nome: 'Arte2'},
    ],
  }

addArte = () => {
  this.setState({artes: [...this.state.artes, {id: Math.random(), nome: 'Nova Arte'}]})
};

render() { 
   return (
    <View style={styles.container}>
      
      <FormTeste></FormTeste>
      {/*
      <Button title="Adicionar Arte" onPress={this.addArte}></Button>
      
      { this.state.artes.map( arte => <Arte key={arte.io} nome={arte.nome}></Arte>)}
      <Arte nome="Teste"></Arte>
      */}
    </View>
  );
 }
}

const styles = StyleSheet.create({
  container: {
    width: '100%',
    flex: 1,
    backgroundColor: '#aaf',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
