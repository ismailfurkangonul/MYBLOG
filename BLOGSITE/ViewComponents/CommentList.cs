using BLOGSITE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BLOGSITE.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName="Furkan"



                },
                 new UserComment
                {
                    Id=2,
                    UserName="İrem"



                },
                 new UserComment
                {
                    Id=3,
                    UserName="Meliha"



                }



            };

            return View(commentvalues);
        }
    }
}
