using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;


using Google.Cloud.Firestore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task GetAsync()
        {
            FirestoreDb db = FirestoreDb.Create("moahentaiclicker-267718");
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "moahentaiclicker-267718");

            DocumentReference docRef = db.Collection("Peixes").Document("Pacu");
            Dictionary<string, object> user = new Dictionary<string, object>
{
                { "First", "Ada" },
                { "Last", "Lovelace" },
                { "Born", 1815 }
            };
            await docRef.SetAsync(user);

        }
        /*
        [HttpPost]
        [Route("post")]
        public JsonResult postFunction([FromBody])
        {
            return Json(new { succcess = true, result = "My name is " });
        }
        */
    }
}
