import firebase from 'firebase'
import firebaseSecrets from './firebaseSecrets'

const config = {
    apiKey: firebaseSecrets.apiKey,
    authDomain: firebaseSecrets.authDomain,
    databaseURL: firebaseSecrets.databaseURL,
    projectId: firebaseSecrets.projectId
  };

  
export default !firebase.apps.length ? firebase.initializeApp(config) : firebase.app();

  

