using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;

namespace MyShoppingApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            Demo D = new Demo();//IF we need to store less value or 1 value then we can create just model object 
            D.Id = 1;
            D.Name = "abrar";
            D.Description = "sdfghj";
            D.Title = "test";

            return View(D);//here we need to pass model object name
        }
    }
}
