using System;
using System.Collections.Generic;

namespace My_Portfolio.Models.Entities
{
    public partial class Title
    {
        public int Id { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutAciklama { get; set; }
        public string? OzgecmisTitle { get; set; }
        public string? OzgecmisAciklama { get; set; }
        public string? OzgecmisAltBaslik1 { get; set; }
        public string? OzgecmisAltBaslik2 { get; set; }
        public string? OzgecmisAltBaslik3 { get; set; }
        public string? ServicesTitle { get; set; }
        public string? ServicesAciklama { get; set; }
        public string? PortfolioTitle { get; set; }
        public string? PortfolioAciklama { get; set; }
        public string? ContactTitle { get; set; }
        public string? ContactAciklama { get; set; }
    }
}
