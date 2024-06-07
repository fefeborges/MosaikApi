using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet("GetAllProdutos")]
        public async Task<ActionResult<List<ProdutoModel>>> GetAllProdutos()
        {
            List<ProdutoModel> produto = await _produtoRepositorio.GetAll();
            return Ok(produto);
        }

        [HttpGet("GetProdutoId/{id}")]
        public async Task<ActionResult<ProdutoModel>> GetProdutoId(int id)
        {
            ProdutoModel produto = await _produtoRepositorio.GetById(id);
            return Ok(produto);
        }

        [HttpPost("InsertProduto")]
        public async Task<ActionResult<ProdutoModel>> InsertProduto([FromBody] ProdutoModel produtoModel)
        {
            ProdutoModel produto = await _produtoRepositorio.InsertProduto(produtoModel);
            return Ok(produto);
        }

        [HttpPut("UpdateProduto/{id:int}")]
        public async Task<ActionResult<ProdutoModel>> UpdateProduto(int id, [FromBody] ProdutoModel produtoModel)
        {
            produtoModel.ProdutoId = id;
            ProdutoModel produto = await _produtoRepositorio.UpdateProduto(produtoModel, id);
            return Ok(produto);
        }

        [HttpDelete("DeleteProduto/{id:int}")]
        public async Task<ActionResult<ProdutoModel>> DeleteProduto(int id)
        {
            bool deleted = await _produtoRepositorio.DeleteProduto(id);
            return Ok(deleted);
        }

    }
}
