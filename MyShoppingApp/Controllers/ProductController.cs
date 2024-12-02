using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;

namespace MyShoppingApp.Controllers
{
    public class ProductController : Controller
    {
       public static List<Product> productList = new List<Product>();

        public IActionResult Index()
        {
            Product productObj = new Product();
            //productObj.Id = 1;
            //productObj.Name = "Test";
            //productObj.Description = "demo";
            //productList.Add(productObj);

            //productObj = new Product();
            //productObj.Id = 2;
            //productObj.Name = "Test2";
            //productObj.Description = "demo2";
            //productList.Add(productObj);
            return View(productObj); //index.cshtml
        }
        public IActionResult AddProduct()
        {

            return View();
        }

        [HttpPost]//post method so that value can store if you click submit it will trigger here 
        public IActionResult AddProduct(Product product)// here we creating object for the model in html if import which model that model object need declare here 
        {
            //how to pass data from action to view page
            //ViewBag.message = "Successfully added...!";// 
            //return View();//it will return message like successfully added
            ViewBag.message = "Successfully added...!";

            if (productList.Count == 0)
            {
                product.Id = 1;
            }
            else
            {
                product.Id = productList[productList.Count - 1].Id+1;
            }
            productList.Add(product);//here it will add product line by line
            return View("Index", productList);// it will take you to index 
        }
        public IActionResult EditProduct(int Id)
        {
            var result = productList.Where(obj => obj.Id == Id).ToList();
            return View(result[0]);
        }
       
    }
}
