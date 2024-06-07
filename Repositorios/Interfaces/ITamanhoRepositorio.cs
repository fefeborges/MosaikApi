using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ITamanhoRepositorio
    {
        Task<List<TamanhoModel>> GetAll();

        Task<TamanhoModel> GetById(int id);

        Task<TamanhoModel> InsertTamanho(TamanhoModel tamanho);

        Task<TamanhoModel> UpdateTamanho(TamanhoModel tamanho, int id);

        Task<bool> DeleteTamanho(int id);
    }
}
