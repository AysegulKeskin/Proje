using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class Referanslar
    {
        public int Id { get; set; }
        public string? Img { get; set; }
        public string? AdSoyad { get; set; }
        public string? Title { get; set; }
        public string? Aciklama { get; set; }
    }
}
