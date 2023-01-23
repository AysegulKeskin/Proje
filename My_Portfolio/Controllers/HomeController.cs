using Microsoft.AspNetCore.Mvc;
using My_Portfolio.Models;
using My_Portfolio.Models.Entities;
using System.Diagnostics;

namespace My_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        My_PortfolioContext db = new My_PortfolioContext();

        public IActionResult Index()
        {
            var model = new IndexViewModel() {
                Titles = db.Titles.ToList(),
                Abouts = db.Abouts.ToList(),
                Heros = db.Heroes.ToList(),
                AboutEnds = db.AboutEnds.ToList(),
                Headers = db.Headers.ToList(),
                OzgecmisOzets = db.OzgecmisOzets.ToList(),
                OzgecmisEgitims=db.OzgecmisEgitims.ToList(),
                OzgecmisIsDeneyimleris=db.OzgecmisIsDeneyimleris.ToList(),
                Services= db.Services.ToList(),
                Referanslars=db.Referanslars.ToList(),
                Portfolios=db.Portfolios.ToList(),
                ContactLefts=db.ContactLefts.ToList(),
                Footers=db.Footers.ToList(),

            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(ContactForm contact)
        {

            


            ContactForm cntct = new ContactForm();
            cntct.AdSoyad = contact.AdSoyad;
            cntct.Email = contact.Email;
            cntct.Konu = contact.Konu;
            cntct.Aciklama = contact.Aciklama;
            db.Add(cntct);
            db.SaveChanges();

            return RedirectToAction("Index");

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}