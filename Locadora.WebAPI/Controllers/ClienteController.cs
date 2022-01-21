using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Locadora.WebAPI.Models;
using System.Linq;

namespace Locadora.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public ClienteController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            return Ok(cliente);
        }

        [HttpPut]
        public IActionResult Put(int id, Cliente cliente)
        {
            return Ok(cliente);
        }

        [HttpPatch]
        public IActionResult Patch(int id, Cliente cliente)
        {
            return Ok(cliente);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
        
    }
}