using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 

namespace rockstarwebapi.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class RockStarController : ControllerBase
    {
        private readonly ILogger<RockStarController> _logger;
        private MyMusic mymusic = new MyMusic();

        public RockStarController(ILogger<RockStarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/Faith")]
        public String GetFaith()
        {
            return mymusic.Faith;
        }

        [HttpGet]
        [Route("[controller]/RocketMan")]
        public String GetRM()
        {
            return mymusic.RocketMan;
        }
    }
}
