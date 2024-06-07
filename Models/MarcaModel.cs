

namespace Api.Models
{
    public class MarcaModel
    {
        public int MarcaId { get; set; }

        public string NomeMarca { get; set; } = string.Empty;


        public static implicit operator List<object>(MarcaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
