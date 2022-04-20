namespace EFCore.WebAPI.Models
{
    public class HeroiBatalha
    {
        public int HeroId { get; set; }
        public Heroi Heroi { get; set; }
        public int BatalhaId { get; set; }
        public Batalha Batalha { get; set; }
    }
}
