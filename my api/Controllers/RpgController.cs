using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_api.Services;

namespace my_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        private RpgService _service;

        public RpgController() //建構方式
        {
            _service = new RpgService();
        }
        [HttpGet]
        [Route(template:"{id}")]
        public Rpg Get(int id)
        {
            Rpg result = null;

            result = _service.Get(id);

            return result;
        }
        
        
    }
}
