using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Firestore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/{controller}/{id}")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        [HttpGet]
        public List<Usuario> Get()
        {
            return usuarios;
        }
        [HttpPost]
        public async void Post(string nome)
        {
            FirestoreDb db = FirestoreDb.Create("moahentaiclicker-267718");
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "moahentaiclicker-267718");

            DocumentReference docRef = db.Collection("Usuarios").Document(nome);
            Dictionary<string, object> user = new Dictionary<string, object>
{
                { "Nome", nome }
                
            };
            await docRef.SetAsync(user);
            if (!string.IsNullOrEmpty(nome))
                usuarios.Add(new Usuario(nome));
        }
        
    }
}