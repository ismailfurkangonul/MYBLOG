using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace BLOGSITE.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetListAll();
            return View(values);


        }
    }
}
