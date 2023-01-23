using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class OzgecmisEgitim
    {
        public int Id { get; set; }
        public string? Bolum { get; set; }
        public string? Yil { get; set; }
        public string? Okul { get; set; }
        public string? Aciklama { get; set; }
    }
}
