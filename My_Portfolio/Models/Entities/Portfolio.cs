using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class Portfolio
    {
        public int Id { get; set; }
        public string? Img { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
    }
}
