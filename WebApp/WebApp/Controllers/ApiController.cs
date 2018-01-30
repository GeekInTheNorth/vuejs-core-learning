using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]/{id?}")]
    public class DataController : Controller
    {
        [HttpGet]
        public IEnumerable<string> List()
        {
            return new List<string>
            {
                "One",
                "Two",
                "Three",
                "Many!"
            };
        }

        [HttpGet]
        public PersonModel View(int id)
        {
            switch (id)
            {
                case 1:
                    return new PersonModel(1, "John", "Smith");
                case 2:
                    return new PersonModel(2, "Jane", "Doe");
                default:
                    return null;
            }
        }

        [HttpPost]
        public void Save(int id, [FromBody]PersonModel person)
        {
            var emp = person;
        }

        [HttpGet]
        public CollectionModel Collection()
        {
            return new CollectionModel
            {
                CollectionName = "My Collection",
                Items = new List<CollectionModelItem>
                {
                    new CollectionModelItem { Id = 1, Name = "One" },
                    new CollectionModelItem { Id = 2, Name = "Two" },
                    new CollectionModelItem { Id = 3, Name = "Three" }
                }
            };
        }

        [HttpPost]
        public void Collection([FromBody]CollectionModel model)
        {
            var incomingModel = model;
        }
    }
}