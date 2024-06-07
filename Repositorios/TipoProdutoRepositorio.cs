using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Api.Repositorios
{
    public class TipoProdutoRepositorio : ITipoProdutoRepositorio
    {
        private readonly Contexto _dbContext;

        public TipoProdutoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TipoProdutoModel>> GetAll()
        {
            return await _dbContext.TipoProduto.ToListAsync();
        }

        public async Task<TipoProdutoModel> GetById(int id)
        {
            return await _dbContext.TipoProduto.FirstOrDefaultAsync(x => x.TipoProdutoId == id);
        }

        public async Task<TipoProdutoModel> InsertTipoProduto(TipoProdutoModel tipoproduto)
        {
            await _dbContext.TipoProduto.AddAsync(tipoproduto);
            await _dbContext.SaveChangesAsync();
            return tipoproduto;
        }

        public async Task<TipoProdutoModel> UpdateTipoProduto(TipoProdutoModel tipoproduto, int id)
        {
            TipoProdutoModel tipoprodutos = await GetById(id);
            if (tipoprodutos == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                tipoprodutos.NomeTipoProduto = tipoprodutos.NomeTipoProduto;
                _dbContext.TipoProduto.Update(tipoproduto);
                await _dbContext.SaveChangesAsync();
            }
            return tipoprodutos;

        }

        public async Task<bool> DeleteTipoProduto(int id)
        {
            TipoProdutoModel tipoprodutos = await GetById(id);
            if (tipoprodutos == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.TipoProduto.Remove(tipoprodutos);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
