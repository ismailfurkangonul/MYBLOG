using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BLOGSITE.Controllers
{
    public class WriterController : Controller
    {
        [AllowAnonymous]
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {

            return View();
        }
        public IActionResult WriterMail()
        {

            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {

            return View();
        }

    }
}
