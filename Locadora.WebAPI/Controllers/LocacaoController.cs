using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Locadora.WebAPI.Models;
using System.Linq;

namespace Locadora.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocacaoController : ControllerBase
    {
        public LocacaoController()
        {
            
        }

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
        public IActionResult Post(Locacao locacao)
        {
            return Ok(locacao);
        }

        [HttpPut]
        public IActionResult Put(int id, Locacao locacao)
        {
            return Ok(locacao);
        }

        [HttpPatch]
        public IActionResult Patch(int id, Locacao locacao)
        {
            return Ok(locacao);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}