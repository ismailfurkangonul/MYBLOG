using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BLOGSITE.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cmm = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();



        }
         [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = 2;
            cmm.CommentAdd(p);
         
            return PartialView();
        }

        
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cmm.GetListAll(id);
            return PartialView(values);


        }
    }
}
