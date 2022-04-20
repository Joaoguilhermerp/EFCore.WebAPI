using System;
using System.Collections.Generic;

namespace EFCore.WebAPI.Models
{
    public class Batalha
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public List<HeroiBatalha> HeroiBatalhas { get; set; }
    }
}
