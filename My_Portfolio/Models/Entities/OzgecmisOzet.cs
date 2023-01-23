using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class OzgecmisOzet
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Aciklama { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? MedeniHal { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Ehliyet { get; set; }
    }
}
