using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")] //routing
    [ApiController]
    public class GenresController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAllGenres()
        {
            //create a new anonymous array
            var genres = new[]
                          {
                             new {Id = 1, Name = "Action"},
                             new {Id = 2, Name = "Comedy"},
                             new {Id = 3, Name = "Thriller"}
                         };
            return Ok(genres);
        }
    }
}