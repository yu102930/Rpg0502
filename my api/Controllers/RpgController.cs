using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace my_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        [HttpGet]
        public Rpg Get()
        {
            Rpg result = null;

            result = new Rpg() { id = 0, name = "boss", lv = 200 };

            return result;
        }
        
        
    }
}
