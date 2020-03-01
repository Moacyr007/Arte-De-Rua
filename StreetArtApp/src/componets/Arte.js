import React, { Component } from 'react';
import { View, Text, StyleSheet } from 'react-native'
import PropTypes from 'prop-types'

export default class Arte extends Component {
    // state = {
    //     timeOutText:""
    // }

    componentDidMount(){//executado na primeira chamada do componente
        // setTimeout(() => {
        //     this.setState({ timeOutText: "3 segundos se passaram"})
        // }, 3000)
    }

    // não ´´e possivel atualisar estado e propriedades dos componentes dentro dos métodos abaixo
    //static getDerivedStateFromProps(nextProps, PrevState){} //executado na primeira chamada do componente e antes de cada atualização
    //shouldComponentUpdate(nextProps, PrevState){return true;}
    //componentDidUpdate(nextProps, PrevState){} //Called immediately after updating occurs. Not called for the initial render.
    //componentWillMount(){} //Called immediately before mounting occurs, and before Component#render. 

    // static defaultProps = {
    //     nome: 'Nome padrão Arte',
    // };

      static propTypes = {
        //nome: PropTypes.string.isRequired,   
        nome: PropTypes.string,   
      };
    render(){
        return(
            <View>
                <Text>{this.props.nome}</Text>
            </View>
        );
    }
}

const styles = StyleSheet.create({
    
});

