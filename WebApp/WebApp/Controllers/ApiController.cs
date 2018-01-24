using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetList()
        {
            return new List<string>
            {
                "One",
                "Two",
                "Three",
                "Many!"
            };
        }
    }
}