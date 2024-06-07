using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ISecaoRepositorio
    {
        Task<List<SecaoModel>> GetAll();

        Task<SecaoModel> GetById(int id);

        Task<SecaoModel> InsertSecao(SecaoModel secao);

        Task<SecaoModel> UpdateSecao(SecaoModel secao, int id);

        Task<bool> DeleteSecao(int id);
    }
}
