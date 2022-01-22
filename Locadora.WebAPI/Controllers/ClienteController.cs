
using System.Collections.Generic;
using Locadora.WebAPI.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Locadora.WebAPI.Data.Interfaces;

namespace Locadora.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        public ClienteController(IClienteRepository repository) 
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _repository.GetAllClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cliente = _repository.GetClienteById(id);
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            try
            {
                _repository.Add(cliente);
                return Ok();
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, Cliente cliente)
        {
            try
            {
                _repository.Update(cliente);
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