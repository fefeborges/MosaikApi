using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using static Api.Repositorios.TamanhoRepositorio;

namespace Api.Repositorios
{
        public class TamanhoRepositorio : ITamanhoRepositorio
    {
            private readonly Contexto _dbContext;

            public TamanhoRepositorio(Contexto dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<List<TamanhoModel>> GetAll()
            {
                return await _dbContext.Tamanho.ToListAsync();
            }

            public async Task<TamanhoModel> GetById(int id)
            {
                return await _dbContext.Tamanho.FirstOrDefaultAsync(x => x.TamanhoId == id);
            }

            public async Task<TamanhoModel> InsertTamanho(TamanhoModel tamanho)
            {
                await _dbContext.Tamanho.AddAsync(tamanho);
                await _dbContext.SaveChangesAsync();
                return tamanho;
            }

            public async Task<TamanhoModel> UpdateTamanho(TamanhoModel tamanho, int id)
            {
            TamanhoModel tamanhos = await GetById(id);
                if (tamanhos == null)
                {
                    throw new Exception("Não encontrado.");
                }
                else
                {
                tamanhos.NomeTamanho = tamanho.NomeTamanho;
                    _dbContext.Tamanho.Update(tamanhos);
                    await _dbContext.SaveChangesAsync();
                }
                return tamanho;

            }

            public async Task<bool> DeleteTamanho(int id)
            {
                TamanhoModel tamanho = await GetById(id);
                if (tamanho == null)
                {
                    throw new Exception("Não encontrado.");
                }

                _dbContext.Tamanho.Remove(tamanho);
                await _dbContext.SaveChangesAsync();
                return true;
            }
        }
}
