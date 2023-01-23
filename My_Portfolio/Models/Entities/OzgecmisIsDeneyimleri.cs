using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class OzgecmisIsDeneyimleri
    {
        public int Id { get; set; }
        public string? Bolum { get; set; }
        public string? Tarih { get; set; }
        public string? Adres { get; set; }
        public string? Aciklama { get; set; }
    }
}
