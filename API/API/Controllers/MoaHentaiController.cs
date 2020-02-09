using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


using Google.Cloud.Firestore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoaHentaiController : ControllerBase
    {
        
        private readonly ILogger<MoaHentaiController> _logger;

        public MoaHentaiController(ILogger<MoaHentaiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task GetAsync()
        {
            FirestoreDb db = FirestoreDb.Create("moahentaiclicker-267718");
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "moahentaiclicker-267718");

            DocumentReference docRef = db.Collection("peixes").Document("alovelace");
            Dictionary<string, object> user = new Dictionary<string, object>
{
                { "First", "Ada" },
                { "Last", "Lovelace" },
                { "Born", 1815 }
            };
            await docRef.SetAsync(user);

        }
    }
}
