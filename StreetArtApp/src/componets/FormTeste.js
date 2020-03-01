import React, { Component } from 'react';
import {
  StyleSheet,
  View,
} from 'react-native';
import {
  Text,
  Item,
  Label,
  Input,
  Button,
} from 'native-base';
import firebase from './config/firestore'
import Form from 'react-native-form'

export default class App extends Component{

    async componentWillMount() {
        await Expo.Font.loadAsync({
          'Roboto': require('native-base/Fonts/Roboto.ttf'),
          'Roboto_medium': require('native-base/Fonts/Roboto_medium.ttf'),
        });
    }
  constructor(props) {
    super(props);
    this.state = {
     };
     this.itemsRef = firebase.database().ref().child(`Arte`)
  }

  pushToFirebase() {
    let formValues = this.refs.soulForm.getValues()
    this.itemsRef.push(formValues)
  }

  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.title}>
         Adicionar Arte de Rua
        </Text>

        <Form ref="soulForm" style={styles.form} >
          <Item floatingLabel style={{marginTop:10}}>
            <Label style={{marginLeft: 15}}>Nome</Label>
            <Input style={{marginLeft: 25}} name="nome" type="TextInput" />
          </Item>
          <Item floatingLabel style={{marginTop:10}}>
            <Label style={{marginLeft: 15}}>Artista</Label>
            <Input style={{marginLeft: 25}} name="artista" type="TextInput" />
          </Item>
          <Item floatingLabel style={{marginTop:10}}>
            <Label style={{marginLeft: 15}}>Descrição</Label>
            <Input style={{marginLeft: 25}} name="descricao" type="TextInput" />
          </Item>
            <Button Block primary onPress={() => this.pushToFirebase()} style={styles.button}><Text>Sell it</Text></Button>
        </Form>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  title: {
    fontSize: 30,
    textAlign: 'center',
    margin: 10,
  },
  text: {
    textAlign: 'left',
    color: '#333333',
    marginBottom: 5,
  },
  form: {
    width: '80%'
  },
  button: {
    margin: 10
  }
});