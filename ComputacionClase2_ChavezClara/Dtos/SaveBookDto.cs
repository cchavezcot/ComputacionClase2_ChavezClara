﻿namespace ComputacionClase2_ChavezClara.Dtos
{
    public class SaveBookDto
    {
        public int? Id { get; set; }

        public string? ISBN { get; set; }

        public string? Title { get; set; }

        public string? Autor { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string? Commentary { get; set; }

        public int EditorialId { get; set; }
    }
}
