using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet("GetAllClientes")]
        public async Task<ActionResult<List<ClienteModel>>> GetAllClientes()
        {
            List<ClienteModel> cliente = await _clienteRepositorio.GetAll();
            return Ok(cliente);
        }

        [HttpGet("GetClienteId/{id}")]
        public async Task<ActionResult<ClienteModel>> GetClienteId(int id)
        {
            ClienteModel cliente = await _clienteRepositorio.GetById(id);
            return Ok(cliente);
        }

        [HttpPost("InsertCliente")]
        public async Task<ActionResult<ClienteModel>> InsertCliente([FromBody] ClienteModel clienteModel)
        {
            ClienteModel cliente = await _clienteRepositorio.InsertCliente(clienteModel);
            return Ok(cliente);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ClienteModel>> Login([FromBody] ClienteModel clienteModel)
        {
            ClienteModel cliente = await _clienteRepositorio.Login(clienteModel);   
            if(cliente == null)
            {
                cliente= new ClienteModel();
                cliente.ClienteId = 0;
            }
            return Ok(cliente);
        }

        [HttpPut("UpdateCliente/{id:int}")]
        public async Task<ActionResult<ClienteModel>> UpdateCliente(int id, [FromBody] ClienteModel clienteModel)
        {
            clienteModel.ClienteId = id;
            ClienteModel cliente = await _clienteRepositorio.UpdateCliente(clienteModel, id);
            return Ok(cliente);
        }

        [HttpDelete("DeleteCliente/{id:int}")]
        public async Task<ActionResult<ClienteModel>> DeleteCliente(int id)
        {
            bool deleted = await _clienteRepositorio.DeleteCliente(id);
            return Ok(deleted);
        }
    }
}
