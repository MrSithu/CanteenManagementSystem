using CanteenManagementSystem.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private static readonly string[] Names = new[] 
        {
            "HninSiWai", "ShweLattYar", "SunTop", "AungMyinKyaw", "ForAll", "YoYarThu", "ShanMalay", "ShweTaungTan"
        };

        private static readonly string[] Photos = new[]
        {
            "HSWphoto", "SLYphoto", "STphoto", "AMKphoto", "FAphoto", "YYTphoto", "SMLphoto", "STTphoto"
        };

        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Shop> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Shop
            {
                Id = rng.Next(1,10),
                //Photo = Photos[rng.Next(Photos.Length)],
                Name = Names[rng.Next(Names.Length)]
            })
            .ToArray();
        }

    }
}
