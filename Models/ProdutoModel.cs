namespace Api.Models
{
    public class ProdutoModel
    {
        public int ProdutoId { get; set; }

        public string NomeProduto { get; set; } = string.Empty;

        public string DescricaoProduto { get; set; } = string.Empty;

        public int TipoProdutoId { get; set; }

        public double PrecoProduto { get; set; }

        public int QtdEstoque { get; set; }

        public int MarcaId { get; set; }

        public int SecaoId { get; set; }

        public int TamanhoId { get; set; }

        public static implicit operator List<object>(ProdutoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
