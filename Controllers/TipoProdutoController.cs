using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProdutoController : ControllerBase
    {
        private readonly ITipoProdutoRepositorio _tipoprodutoRepositorio;

        public TipoProdutoController(ITipoProdutoRepositorio tipoprodutoRepositorio)
        {
            _tipoprodutoRepositorio = tipoprodutoRepositorio;
        }

        [HttpGet("GetAllTipoProdutos")]
        public async Task<ActionResult<List<TipoProdutoModel>>> GetAllTipoProdutos()
        {
            List<TipoProdutoModel> tipoproduto = await _tipoprodutoRepositorio.GetAll();
            return Ok(tipoproduto);
        }

        [HttpGet("GetTipoProdutoId/{id}")]
        public async Task<ActionResult<TipoProdutoModel>> GetTipoProdutoId(int id)
        {
            TipoProdutoModel tipoproduto = await _tipoprodutoRepositorio.GetById(id);
            return Ok(tipoproduto);
        }

        [HttpPost("TipoProduto")]
        public async Task<ActionResult<TipoProdutoModel>> InsertTipoProduto([FromBody] TipoProdutoModel tipoprodutoModel)
        {
            TipoProdutoModel tipoproduto = await _tipoprodutoRepositorio.InsertTipoProduto(tipoprodutoModel);
            return Ok(tipoproduto);
        }

        [HttpPut("UpdateTipoProduto/{id:int}")]
        public async Task<ActionResult<TipoProdutoModel>> UpdateTipoProduto(int id, [FromBody] TipoProdutoModel tipoprodutoModel)
        {
            tipoprodutoModel.TipoProdutoId = id;
            TipoProdutoModel tipoproduto = await _tipoprodutoRepositorio.UpdateTipoProduto(tipoprodutoModel, id);
            return Ok(tipoproduto);
        }

        [HttpDelete("DeleteTipoProduto/{id:int}")]
        public async Task<ActionResult<TipoProdutoModel>> DeleteTipoProduto(int id)
        {
            bool deleted = await _tipoprodutoRepositorio.DeleteTipoProduto(id);
            return Ok(deleted);
        }

    }
}
