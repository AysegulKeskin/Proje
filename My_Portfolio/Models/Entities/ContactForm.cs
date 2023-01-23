using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class ContactForm
    {
        public int Id { get; set; }
        public string? AdSoyad { get; set; }
        public string? Email { get; set; }
        public string? Konu { get; set; }
        public string? Aciklama { get; set; }
    }
}
