using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;

namespace MyShoppingApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            List<Categories> CategoriesList = new List<Categories>();//if we need more than one object that time we can go with collection list
            Categories cate = new Categories();
            cate.Id = 1;
            cate.Name = "varun";
            cate.Description = "LULU";
            CategoriesList.Add(cate);

            cate = new Categories();
            cate.Id = 2;
            cate.Name = "anusha";
            cate.Description = "mall";
            CategoriesList.Add(cate);
            return View(CategoriesList);//here we need to pass list object so that it will store collection of values
        }
    }
}
