using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BLOGSITE.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cmm = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke()
        {
            var values = cmm.GetListAll(2);
            return View(values);
        }
    }
}