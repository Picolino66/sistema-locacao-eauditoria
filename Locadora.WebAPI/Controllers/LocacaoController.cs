using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Locadora.WebAPI.Models;
using System.Linq;
using Locadora.WebAPI.Data.Interfaces;

namespace Locadora.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoRepository _repository;
        public LocacaoController(ILocacaoRepository repository) 
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var locacoes = _repository.GetAllLocacoes();
            return Ok(locacoes);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var locacao = _repository.GetLocacaoById(id);
            return Ok(locacao);
        }

        [HttpPost]
        public IActionResult Post(Locacao locacao)
        {
            try
            {
                _repository.Add(locacao);
                return Ok();
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, Locacao locacao)
        {
            try
            {
                _repository.Update(locacao);
                return Ok();
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                //_repository.Delete();
                return Ok();
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}