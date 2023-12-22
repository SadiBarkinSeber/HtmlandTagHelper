using HtmlandTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlandTagHelper.Controllers
{
    public class UserController : Controller
    {

    

        public IActionResult HtmlHelpers()
        {
            return View();
        }



        [HttpPost]
        public IActionResult HtmlHelpers(Userr userr)
        {
            return View();
        }

        public IActionResult TagHelpers() => View();
        [HttpPost]
        public IActionResult TagHelpers(Userr userr)
        {
            Userr usserr = new Userr()
            {
                    UserName="testuser",
                    Password="12345",
                    FirstName="John",
                    LastName="Doe"
            };

            // return View("HtmlHelpers",userr);
            return RedirectToAction("HtmlHelpers", "User");

        }


    }

   

}
