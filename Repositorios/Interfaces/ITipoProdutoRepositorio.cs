using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ITipoProdutoRepositorio
    {
        Task<List<TipoProdutoModel>> GetAll();

        Task<TipoProdutoModel> GetById(int id);

        Task<TipoProdutoModel> InsertTipoProduto(TipoProdutoModel tipoproduto);

        Task<TipoProdutoModel> UpdateTipoProduto(TipoProdutoModel tipoproduto, int id);

        Task<bool> DeleteTipoProduto(int id);
    }
}
