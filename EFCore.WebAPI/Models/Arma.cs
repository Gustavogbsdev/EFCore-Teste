namespace EFCore.WebAPI.Models
{
    public class Arma
    {
        public int Id { get; set; }
        public string NomeArma { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}
