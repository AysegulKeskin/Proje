using Microsoft.AspNetCore.Mvc;
using My_Portfolio.Models.Entities;

namespace My_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        My_PortfolioContext db = new My_PortfolioContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin p)
        {
           var user = db.Admins.FirstOrDefault(x=>x.Username==p.Username&& x.Password==p.Password );
            if (user == null)
            {

                TempData["Uyarı"] = "Lütfen bilgilerinizi doğru girdiğinizden emin olunuz";
                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Home","Admin");
            }

           
        }

      
    }
}
