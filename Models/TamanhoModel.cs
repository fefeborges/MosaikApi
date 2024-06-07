namespace Api.Models
{
    public class TamanhoModel
    {
        public int TamanhoId { get; set; }

        public string NomeTamanho{ get; set; } = string.Empty;


        public static implicit operator List<object>(TamanhoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
