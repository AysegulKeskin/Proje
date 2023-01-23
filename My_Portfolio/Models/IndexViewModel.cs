using My_Portfolio.Models.Entities;

namespace My_Portfolio.Models
{
    public class IndexViewModel
    {
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<AboutEnd> AboutEnds { get; set; }

        public IEnumerable <Header> Headers { get; set; }
        public IEnumerable<Hero> Heros { get; set; }

        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Title> Titles { get; set; }

        public IEnumerable<OzgecmisOzet> OzgecmisOzets { get; set;}

        public IEnumerable<OzgecmisEgitim> OzgecmisEgitims { get; set; }
        public IEnumerable<OzgecmisIsDeneyimleri> OzgecmisIsDeneyimleris { get; set; }

        public IEnumerable <Referanslar> Referanslars { get; set; }
        public IEnumerable  <Portfolio> Portfolios { get; set; }

        public IEnumerable <ContactLeft> ContactLefts { get; set; }

        public IEnumerable<Footer> Footers { get; set; } 

      

    }
    

}
