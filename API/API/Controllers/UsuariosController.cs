using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Firestore;

//TODO post com frombody e conectar get ao firebase
namespace API.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/{controller}/{id}")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        [HttpGet]
        //Task<ActionResult<Usuario>>
        public async void  Get()
        {
            FirestoreDb db = FirestoreDb.Create("moahentaiclicker-267718");
            //System.Diagnostics.Debug.WriteLine("g e t");
            //CollectionReference usersRef = db.Collection("Usuarios");
            //QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            Query capitalQuery = db.Collection("Usuarios");
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                Console.WriteLine("Document data for {0} document:", documentSnapshot.Id);
                Dictionary<string, object> city = documentSnapshot.ToDictionary();
                foreach (KeyValuePair<string, object> pair in city)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }
                Console.WriteLine("");
            }







            /*
            if (snapshot.Exists)
            {
                Console.WriteLine("Document data for {0} document:", snapshot.Id);
                Dictionary<string, object> city = snapshot.ToDictionary();
                foreach (KeyValuePair<string, object> pair in city)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }
            }
            else
            {
                Console.WriteLine("Document {0} does not exist!", snapshot.Id);
            }
            */


            //return (snapshot.Documents);

            /*
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                return document;
                
                Console.WriteLine("User: {0}", document.Id);
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                Console.WriteLine("First: {0}", documentDictionary["First"]);
                if (documentDictionary.ContainsKey("Middle"))
                {
                    Console.WriteLine("Middle: {0}", documentDictionary["Middle"]);
                }
                Console.WriteLine("Last: {0}", documentDictionary["Last"]);
                Console.WriteLine("Born: {0}", documentDictionary["Born"]);
                Console.WriteLine();
                
            }
            */


        }
        [HttpPost]
        //public async void Post([FromBody]Usuario usuario)
        public async void Post(string nome)
        {
            try
            {
                FirestoreDb db = FirestoreDb.Create("moahentaiclicker-267718");
                Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "moahentaiclicker-267718");

                DocumentReference docRef = db.Collection("Usuarios").Document(nome);
                Dictionary<string, object> user = new Dictionary<string, object>
                {
                { "Nome", nome }

                };
                await docRef.SetAsync(user);
                //if (!string.IsNullOrEmpty(nome))
                //  usuarios.Add(new Usuario(nome));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(string nome)
        {
            
        }
        
    }
}