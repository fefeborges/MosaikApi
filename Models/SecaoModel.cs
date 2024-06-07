namespace Api.Models
{
    public class SecaoModel
    {
        public int SecaoId { get; set; }

        public string NomeSecao { get; set; } = string.Empty;


        public static implicit operator List<object>(SecaoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
