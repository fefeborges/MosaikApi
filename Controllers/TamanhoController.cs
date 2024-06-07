using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamanhoController : ControllerBase
    {
        private readonly ITamanhoRepositorio _tamanhoRepositorio;

        public TamanhoController(ITamanhoRepositorio tamanhoRepositorio)
        {
            _tamanhoRepositorio = tamanhoRepositorio;
        }

        [HttpGet("GetAllTamanho")]
        public async Task<ActionResult<List<TamanhoModel>>> GetAllTamanho()
        {
            List<TamanhoModel> tamanho = await _tamanhoRepositorio.GetAll();
            return Ok(tamanho);
        }

        [HttpGet("GetTamanhoId/{id}")]
        public async Task<ActionResult<TamanhoModel>> GetTamanhoId(int id)
        {
            TamanhoModel tamanho = await _tamanhoRepositorio.GetById(id);
            return Ok(tamanho);
        }

        [HttpPost("InsertTamanho")]
        public async Task<ActionResult<TamanhoModel>> InsertTamanho([FromBody] TamanhoModel tamanhoModel)
        {
            TamanhoModel tamanho = await _tamanhoRepositorio.InsertTamanho(tamanhoModel);
            return Ok(tamanho);
        }

        [HttpPut("UpdateTamanho/{id:int}")]
        public async Task<ActionResult<TamanhoModel>> UpdateTamanho(int id, [FromBody] TamanhoModel tamanhoModel)
        {
            tamanhoModel.TamanhoId = id;
            TamanhoModel tamanho = await _tamanhoRepositorio.UpdateTamanho(tamanhoModel, id);
            return Ok(tamanho);
        }

        [HttpDelete("DeleteTamanho/{id:int}")]
        public async Task<ActionResult<TamanhoModel>> DeleteTamanho(int id)
        {
            bool deleted = await _tamanhoRepositorio.DeleteTamanho(id);
            return Ok(deleted);
        }

    }
}
