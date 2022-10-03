using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BLOGSITE.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EFAboutRepository());
        public IActionResult Index()
        {
            var values = am.GetListAll();

            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
        
            return PartialView();


        }
    }
}
