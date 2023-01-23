using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class Service
    {
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
    }
}
