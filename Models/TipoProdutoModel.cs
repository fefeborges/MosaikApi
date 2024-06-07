

namespace Api.Models
{
    public class TipoProdutoModel
    {
        public int TipoProdutoId { get; set; }

        public string NomeTipoProduto { get; set; } = string.Empty;

        public static implicit operator List<object>(TipoProdutoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
