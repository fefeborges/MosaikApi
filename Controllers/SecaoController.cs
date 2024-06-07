using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecaoController : ControllerBase
    {
        private readonly ISecaoRepositorio _secaoRepositorio;

        public SecaoController(ISecaoRepositorio secaoRepositorio)
        {
            _secaoRepositorio = secaoRepositorio;
        }

        [HttpGet("GetAllSecao")]
        public async Task<ActionResult<List<SecaoModel>>> GetAllSecao()
        {
            List<SecaoModel> secao = await _secaoRepositorio.GetAll();
            return Ok(secao);
        }

        [HttpGet("GetSecaoId/{id}")]
        public async Task<ActionResult<SecaoModel>> GetSecaoId(int id)
        {
            SecaoModel secao = await _secaoRepositorio.GetById(id);
            return Ok(secao);
        }

        [HttpPost("InsertSecao")]
        public async Task<ActionResult<SecaoModel>> InsertSecao([FromBody] SecaoModel secaoModel)
        {
            SecaoModel secao = await _secaoRepositorio.InsertSecao(secaoModel);
            return Ok(secao);
        }

        [HttpPut("UpdateSecao/{id:int}")]
        public async Task<ActionResult<SecaoModel>> UpdateSecao(int id, [FromBody] SecaoModel secaoModel)
        {
            secaoModel.SecaoId = id;
            SecaoModel secao = await _secaoRepositorio.UpdateSecao(secaoModel, id);
            return Ok(secao);
        }

        [HttpDelete("DeleteSecao/{id:int}")]
        public async Task<ActionResult<SecaoModel>> DeleteSecao(int id)
        {
            bool deleted = await _secaoRepositorio.DeleteSecao(id);
            return Ok(deleted);
        }

    }
}
