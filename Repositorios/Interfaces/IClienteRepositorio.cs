using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> GetAll();

        Task<ClienteModel> GetById(int id);

        Task<ClienteModel> InsertCliente(ClienteModel cliente);

        Task<ClienteModel> Login(ClienteModel cliente);

        Task<ClienteModel> UpdateCliente(ClienteModel cliente, int id);

        Task<bool> DeleteCliente(int id);

    }
}
