using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestAlbumsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            var album1 = new Album();
            album1.Artist = "Pink Floyd";
            album1.Name = "Dark Side of the moon";

            var album2 = new Album()
            {
                Artist = "Radiohead",
                Name = "The Bends"
            };

            List<Album> albums = new List<Album>
            {
                album1,
                album2
            };

            return albums;
        }
    }
}
