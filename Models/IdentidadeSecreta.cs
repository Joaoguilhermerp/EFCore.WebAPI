﻿namespace EFCore.WebAPI.Models
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}
