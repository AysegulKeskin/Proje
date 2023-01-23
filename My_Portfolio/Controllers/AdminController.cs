
using Microsoft.AspNetCore.Mvc;
using My_Portfolio.Models;
using My_Portfolio.Models.Entities;
using System.Data.Common;

namespace My_Portfolio.Controllers
{
    public class AdminController : Controller
    {
   

        public IActionResult Index()
        {
            return View();
        }
        My_PortfolioContext db=new My_PortfolioContext();
        public IActionResult Home(int id)
        {
            Hero hero = db.Heroes.FirstOrDefault(x => x.Id == id);
            return View(hero);
        }
        [HttpPost]
        public IActionResult Home(Hero hero)
        {
            Hero _hero = db.Heroes.FirstOrDefault(h => h.Id == hero.Id);
            _hero.Adi = hero.Adi;
            _hero.Hakkinda = hero.Hakkinda;
            db.Update(_hero);
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
           
            return RedirectToAction("Home");
        }

        public IActionResult Menu(int id)
        {
            Header header = db.Headers.FirstOrDefault(x=>x.Id==id);
            return View(header);

        }
        [HttpPost]
        public IActionResult Menu(Header header)
        {
            Header _header = db.Headers.FirstOrDefault(x=> x.Id== header.Id);
            _header.Nav1 = header.Nav1;
            _header.Nav2 = header.Nav2;
            _header.Nav3 = header.Nav3;
            _header.Nav4 = header.Nav4;
            _header.Nav5 = header.Nav5;
            _header.Nav6 = header.Nav6;
            _header.Nav1Link = header.Nav1Link;
            _header.Nav2Link = header.Nav2Link;
            _header.Nav3Link = header.Nav3Link;
            _header.Nav4Link = header.Nav4Link;
            _header.Nav5Link = header.Nav5Link;
            _header.Nav6Link = header.Nav6Link;
            db.Update(_header);
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
            return RedirectToAction("Menu");
        }



        public IActionResult About(int id)
        {
            About about = db.Abouts.FirstOrDefault(x=>x.Id==id);
            return View(about);
        }
        [HttpPost]
        public IActionResult About(About about,IFormFile Foto)
        {
            About _about = db.Abouts.FirstOrDefault(x => x.Id == about.Id);
            
            _about.Name = about.Name;
            _about.Website = about.Website;
            _about.Phone = about.Phone;
            _about.City = about.City;
            _about.Age = about.Age;
            _about.Degree = about.Degree;
            _about.Email = about.Email;
            _about.Serbestlik = about.Serbestlik;
            _about.Data1 = about.Data1;
            _about.Data2 = about.Data2;
            _about.Data3 = about.Data3;
            _about.Data4 = about.Data4;
            _about.Aciklama1 = about.Aciklama1;
            _about.Aciklama2 = about.Aciklama2;
            _about.Aciklama3 = about.Aciklama3;
            _about.Aciklama4 = about.Aciklama4;


            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur"||  ext == "jpg"||  ext == "jpeg"||  ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img", fileName)))
                {
                    Foto?.CopyTo(fs);
                }
                _about.Img = fileName;
            }
            db.Update(_about);
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
            return RedirectToAction("About");
        }
        public IActionResult SAboutAlt()
        {
            var model = new IndexViewModel()
            {
                AboutEnds = db.AboutEnds.ToList(),

            };
            return View(model);
        }

        public IActionResult AboutAltDuzenle(int id)
        {
            AboutEnd aboutEnd = db.AboutEnds.FirstOrDefault(x=>x.Id==id);
            return View(aboutEnd);
        }
        [HttpPost]
        public IActionResult AboutAltDuzenle(AboutEnd aboutEnd)
        {
            AboutEnd _aboutEnd = db.AboutEnds.FirstOrDefault(x => x.Id == aboutEnd.Id );
            _aboutEnd.Bilgi = aboutEnd.Bilgi;
            _aboutEnd.Deger = aboutEnd.Deger;
            db.Update(_aboutEnd);
            db.SaveChanges();
           
            return RedirectToAction("SAboutAlt");
        }


        public IActionResult AboutAltSil(int id)
        {
            AboutEnd a = db.AboutEnds.FirstOrDefault(x=>x.Id==id);
            return View(a);
        }
        [HttpPost]
        public IActionResult AboutAltSil(AboutEnd aboutEnd)
        {
            AboutEnd _aboutEnd1 = db.AboutEnds.FirstOrDefault(x => x.Id == aboutEnd.Id );
    
            db.Remove(_aboutEnd1);
            db.SaveChanges();
            return RedirectToAction("SAboutAlt");
        }

        public IActionResult SAboutEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SAboutEkle(AboutEnd a)
        {
            AboutEnd e= new AboutEnd();
            e.Deger = a.Deger;
            e.Bilgi = a.Bilgi;
            db.Add(e);
            db.SaveChanges();
            return RedirectToAction("SAboutAlt");
        }

        public IActionResult Titles(int id)
        {
            Title title = db.Titles.FirstOrDefault(x => x.Id == id);
            return View(title);
        }
        [HttpPost]
        public IActionResult Titles(Title title)
        {
            Title _title = db.Titles.FirstOrDefault(x => x.Id == title.Id );
            _title.AboutTitle = title.AboutTitle;
            _title.AboutAciklama= title.AboutAciklama;
            _title.OzgecmisTitle= title.OzgecmisTitle;
            _title.OzgecmisAciklama = title.OzgecmisAciklama;
            _title.OzgecmisAltBaslik1 = title.OzgecmisAltBaslik1;
            _title.OzgecmisAltBaslik2 = title.OzgecmisAltBaslik2;
            _title.OzgecmisAltBaslik3 = title.OzgecmisAltBaslik3;
            _title.ServicesTitle= title.ServicesTitle;
            _title.ServicesAciklama=title.ServicesAciklama;
            _title.PortfolioTitle=title.PortfolioTitle;
            _title.PortfolioAciklama = title.PortfolioAciklama;
            _title.ContactTitle= title.ContactTitle;
            _title.ContactAciklama = title.ContactAciklama;
            db.Update(_title);
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
            return RedirectToAction("Titles");
        }

        public IActionResult OzgecmisOzet(int id)
        {
            OzgecmisOzet ozgecmisOzet =db.OzgecmisOzets.FirstOrDefault(o => o.Id == id);
            return View(ozgecmisOzet);
        }
        [HttpPost]
        public IActionResult OzgecmisOzet(OzgecmisOzet ozgecmisOzet)
        {
            OzgecmisOzet _ozgecmisOzet = db.OzgecmisOzets.FirstOrDefault(o => o.Id == ozgecmisOzet.Id );
            _ozgecmisOzet.Ad = ozgecmisOzet.Ad;
            _ozgecmisOzet.Soyad = ozgecmisOzet.Soyad;
            _ozgecmisOzet.Aciklama = ozgecmisOzet.Aciklama;
            _ozgecmisOzet.Adres = ozgecmisOzet.Adres;
            _ozgecmisOzet.Telefon = ozgecmisOzet.Telefon;
            _ozgecmisOzet.Email = ozgecmisOzet.Email;
            _ozgecmisOzet.MedeniHal = ozgecmisOzet.MedeniHal;
            _ozgecmisOzet.Cinsiyet = ozgecmisOzet.Cinsiyet;
            _ozgecmisOzet.Ehliyet = ozgecmisOzet.Ehliyet;
            db.Update( _ozgecmisOzet );
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
            return RedirectToAction( "OzgecmisOzet" );
        }

        public IActionResult OzgecmisEgitim()
        {
            var model = new IndexViewModel()
            {
                OzgecmisEgitims = db.OzgecmisEgitims.ToList(),

            };
            return View(model);
        }

        public IActionResult OzgecmisEgitimDuzenle(int id)
        {
            OzgecmisEgitim ozgecmisEgitim = db.OzgecmisEgitims.FirstOrDefault(x=>x.Id==id);
            return View(ozgecmisEgitim);
        }
        [HttpPost]
        public IActionResult OzgecmisEgitimDuzenle(OzgecmisEgitim ozgecmisEgitim)
        {
            OzgecmisEgitim _ozgecmisEgitim = db.OzgecmisEgitims.FirstOrDefault(x => x.Id == ozgecmisEgitim.Id);
            _ozgecmisEgitim.Bolum = ozgecmisEgitim.Bolum;
            _ozgecmisEgitim.Yil = ozgecmisEgitim.Yil;
            _ozgecmisEgitim.Okul = ozgecmisEgitim.Okul;
            _ozgecmisEgitim.Aciklama = ozgecmisEgitim.Aciklama;
            db.Update(_ozgecmisEgitim);
            db.SaveChanges();
            return RedirectToAction("OzgecmisEgitim");
        }

        public IActionResult OzgecmisEgitimEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OzgecmisEgitimEkle(OzgecmisEgitim o)
        {
            OzgecmisEgitim e = new OzgecmisEgitim();
            e.Bolum = o.Bolum;
            e.Yil = o.Yil;
            e.Okul = o.Okul;
            e.Aciklama = o.Aciklama;
            db.Add(e);
            db.SaveChanges();
            return RedirectToAction("OzgecmisEgitim");
        }

        public IActionResult OzgecmisEgitimSil(int id)
        {
            OzgecmisEgitim o=db.OzgecmisEgitims.FirstOrDefault(x => x.Id == id);

            return View(o);
        }

        [HttpPost]
        public IActionResult OzgecmisEgitimSil(OzgecmisEgitim ozgecmisEgitim)
        {
            OzgecmisEgitim _ozgecmisEgitim1 = db.OzgecmisEgitims.FirstOrDefault(x => x.Id == ozgecmisEgitim.Id);

            db.Remove(_ozgecmisEgitim1);
            db.SaveChanges();
            return RedirectToAction("OzgecmisEgitim");
        }

        public IActionResult IsDeneyimleri()
        {
            var model = new IndexViewModel()
            {
                OzgecmisIsDeneyimleris = db.OzgecmisIsDeneyimleris.ToList(),

            };
            return View(model);
        }

        public IActionResult IsDeneyimleriDuzenle(int id)
        {
            OzgecmisIsDeneyimleri ozgecmisIsDeneyimleri = db.OzgecmisIsDeneyimleris.FirstOrDefault(x => x.Id == id);
            return View(ozgecmisIsDeneyimleri);
        }

        [HttpPost]
        public IActionResult IsDeneyimleriDuzenle(OzgecmisIsDeneyimleri ozgecmisIsDeneyimleri)
        {
            OzgecmisIsDeneyimleri _ozgecmisIsDeneyimleri = db.OzgecmisIsDeneyimleris.FirstOrDefault(x => x.Id ==ozgecmisIsDeneyimleri.Id);
            _ozgecmisIsDeneyimleri.Bolum = ozgecmisIsDeneyimleri.Bolum;
            _ozgecmisIsDeneyimleri.Tarih = ozgecmisIsDeneyimleri.Tarih;
            _ozgecmisIsDeneyimleri.Adres = ozgecmisIsDeneyimleri.Adres;
            _ozgecmisIsDeneyimleri.Aciklama = ozgecmisIsDeneyimleri.Aciklama;
            db.Update(_ozgecmisIsDeneyimleri);
            db.SaveChanges();

            return RedirectToAction("IsDeneyimleri");
        }

        public IActionResult IsDeneyimleriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IsDeneyimleriEkle(OzgecmisIsDeneyimleri o)
        {
            OzgecmisIsDeneyimleri e = new OzgecmisIsDeneyimleri();
            e.Bolum = o.Bolum;
            e.Tarih = o.Tarih;
            e.Adres = o.Adres;
            e.Aciklama = o.Aciklama;
            db.Add(e);
            db.SaveChanges();
            return RedirectToAction("IsDeneyimleri");
        }

        public IActionResult IsDeneyimleriSil(int id)
        {
            OzgecmisIsDeneyimleri o = db.OzgecmisIsDeneyimleris.FirstOrDefault(x => x.Id == id);
            return View(o);
        }
        [HttpPost]
        public IActionResult IsDeneyimleriSil(OzgecmisIsDeneyimleri ozgecmisIsDeneyimleri)
        {
            OzgecmisIsDeneyimleri _ozgecmisIsDeneyimleri1 = db.OzgecmisIsDeneyimleris.FirstOrDefault(x => x.Id == ozgecmisIsDeneyimleri.Id);
            db.Remove(_ozgecmisIsDeneyimleri1);
            db.SaveChanges();
            return RedirectToAction("IsDeneyimleri");
        }

        public IActionResult Service()
        {
            var model = new IndexViewModel()
            {
                Services = db.Services.ToList(),

            };
            return View(model);
        }

        public IActionResult ServiceDuzenle(int id)
        {
            Service service = db.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }
        [HttpPost]
        public IActionResult ServiceDuzenle(Service service)
        {
            Service _service= db.Services.FirstOrDefault(x => x.Id == service.Id);
            _service.Icon = service.Icon;
            _service.Baslik = service.Baslik;
            _service.Aciklama = service.Aciklama;
            db.Update(_service);
            db.SaveChanges();
            return RedirectToAction("Service");
        }
        public IActionResult Referanslar()
        {
            var model = new IndexViewModel()
            {
                Referanslars = db.Referanslars.ToList(),

            };
            return View(model);
        }

        public IActionResult ReferanslarDuzenle(int id)
        {
            Referanslar referanslar = db.Referanslars.FirstOrDefault(x => x.Id == id);
            return View(referanslar);
        }
        [HttpPost]
        public IActionResult ReferanslarDuzenle(Referanslar referanslar, IFormFile Foto)
        {
            Referanslar _referanslar = db.Referanslars.FirstOrDefault(x => x.Id == referanslar.Id);
            
            _referanslar.AdSoyad = referanslar.AdSoyad;
            _referanslar.Title = referanslar.Title;
            _referanslar.Aciklama = referanslar.Aciklama;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\testimonials", fileName)))
                {
                    Foto?.CopyTo(fs);
                }
                _referanslar.Img = fileName;
            }

            db.Update(_referanslar);
            db.SaveChanges();

            return RedirectToAction("Referanslar");
        }
        public IActionResult ReferanslarEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReferanslarEkle(Referanslar r, IFormFile Foto)
        {
            Referanslar e = new Referanslar();
            
            e.AdSoyad = r.AdSoyad;
            e.Title = r.Title;
            e.Aciklama = r.Aciklama;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\testimonials", fileName)))
                {
                    Foto?.CopyTo(fs);
                }
                e.Img = fileName;
            }

            db.Add(e);
            db.SaveChanges();
            return RedirectToAction("Referanslar");
        }
        public IActionResult ReferanslarSil(int id)
        {
            Referanslar o = db.Referanslars.FirstOrDefault(x => x.Id == id);
            return View(o);
        }
        [HttpPost]
        public IActionResult ReferanslarSil(Referanslar referanslar)
        {
            Referanslar _referanslar = db.Referanslars.FirstOrDefault(x => x.Id == referanslar.Id);
            db.Remove(_referanslar);
            db.SaveChanges();
            return RedirectToAction("Referanslar");
        }

        public IActionResult Contact(int id)
        {
            ContactLeft contactLeft = db.ContactLefts.FirstOrDefault(x => x.Id == id);
            return View(contactLeft);
        }
        [HttpPost]
        public IActionResult Contact(ContactLeft contactLeft)
        {
            ContactLeft _contactLeft = db.ContactLefts.FirstOrDefault(x => x.Id == contactLeft.Id);
            _contactLeft.Link1 = contactLeft.Link1;
            _contactLeft.Link2 = contactLeft.Link2;
            _contactLeft.Link3 = contactLeft.Link3;
            _contactLeft.Link4 = contactLeft.Link4;
            _contactLeft.Link5 = contactLeft.Link5;
            _contactLeft.Email = contactLeft.Email;
            _contactLeft.Phone = contactLeft.Phone;

            db.Update(_contactLeft);
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
            return RedirectToAction("Contact");
        }
        public IActionResult Footer(int id)
        {
            Footer footer = db.Footers.FirstOrDefault(x => x.Id == id);
            return View(footer);
        }
        [HttpPost]
        public IActionResult Footer(Footer footer)
        {
            Footer _footer = db.Footers.FirstOrDefault(x => x.Id == footer.Id);
           _footer.Name=footer.Name;
            _footer.Aciklama = footer.Aciklama;
            _footer.Link1 = footer.Link1;
            _footer.Link2 = footer.Link2;
            _footer.Link3 = footer.Link3;
            _footer.Link4 = footer.Link4;
            _footer.Link5 = footer.Link5;


            db.Update(_footer);
            db.SaveChanges();
            TempData["Uyarı"] = "Bilgiler güncellenmiştir";
            return RedirectToAction("Footer");
        }

        public IActionResult Portfolio()
        {
            var model = new IndexViewModel()
            {
                Portfolios = db.Portfolios.ToList(),

            };
            return View(model);
        }
        public IActionResult PortfolioDuzenle(int id)
        {
            Portfolio portfolio = db.Portfolios.FirstOrDefault(x => x.Id == id);
            return View(portfolio);
        }
        [HttpPost]
        public IActionResult PortfolioDuzenle(Portfolio portfolio, IFormFile Foto)
        {
            Portfolio _portfolio = db.Portfolios.FirstOrDefault(x => x.Id == portfolio.Id);
            _portfolio.Baslik = portfolio.Baslik;
            _portfolio.Aciklama = portfolio.Aciklama;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\portfolio", fileName)))
                {
                    Foto?.CopyTo(fs);
                }
                _portfolio.Img = fileName;
            }

            db.Update(_portfolio);
            db.SaveChanges();

            return RedirectToAction("Portfolio");
        }
        public IActionResult PortfolioSil(int id)
        {
            Portfolio o = db.Portfolios.FirstOrDefault(x => x.Id == id);
            return View(o);
        }
        [HttpPost]
        public IActionResult PortfolioSil(Portfolio portfolio)
        {
            Portfolio _portfolio = db.Portfolios.FirstOrDefault(x => x.Id == portfolio.Id);
            db.Remove(_portfolio);
            db.SaveChanges();
            return RedirectToAction("Portfolio");
        }
        public IActionResult PortfolioEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PortfolioEkle(Portfolio r, IFormFile Foto)
        {
            Portfolio e = new Portfolio();

            e.Baslik = r.Baslik;
            e.Aciklama = r.Aciklama;

            var ext = Foto?.FileName.Split('.').LastOrDefault()?.ToLower();
            if (ext == "png" || ext == "gif" || ext == "ico" || ext == "cur" || ext == "jpg" || ext == "jpeg" || ext == "jfif" || ext == "pjpeg" || ext == "pjp")
            {
                var fileName = $"{Guid.NewGuid():N}.{ext}";
                using (var fs = System.IO.File.Create(Path.Combine(Program.WWWROOT, "assets\\img\\portfolio", fileName)))
                {
                    Foto?.CopyTo(fs);
                }
                e.Img = fileName;
            }

            db.Add(e);
            db.SaveChanges();
            return RedirectToAction("Portfolio");
        }
    }
}
