using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class SecaoRepositorio : ISecaoRepositorio
    {
        private readonly Contexto _dbContext;

        public SecaoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SecaoModel>> GetAll()
        {
            return await _dbContext.Secao.ToListAsync();
        }

        public async Task<SecaoModel> GetById(int id)
        {
            return await _dbContext.Secao.FirstOrDefaultAsync(x => x.SecaoId == id);
        }

        public async Task<SecaoModel> InsertSecao(SecaoModel secao)
        {
            await _dbContext.Secao.AddAsync(secao);
            await _dbContext.SaveChangesAsync();
            return secao;
        }

        public async Task<SecaoModel> UpdateSecao(SecaoModel secao, int id)
        {
            SecaoModel secaos = await GetById(id);
            if (secaos == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                secaos.NomeSecao = secao.NomeSecao;
                _dbContext.Secao.Update(secaos);
                await _dbContext.SaveChangesAsync();
            }
            return secaos;

        }

        public async Task<bool> DeleteSecao(int id)
        {
            SecaoModel secao = await GetById(id);
            if (secao == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Secao.Remove(secao);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
