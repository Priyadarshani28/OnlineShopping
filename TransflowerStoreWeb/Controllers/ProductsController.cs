using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using Catalog;

namespace TransflowerStoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           List<Product> allProducts= Catalog.ProductManager.GetAllProducts();
           this.ViewData["products"]=allProducts;
            return View();  
        }

        [HttpGet]
         public IActionResult Insert()
        {
           Console.WriteLine("GET HTTP Insert method is invoked before empty send to client");
            return View();  
        }
        [HttpPost]
          public IActionResult Insert(int id, string title, string description, int quantity, double unitprice)
        {
            Product product = new Product(){
                Id=id,
                Title=title,
                Description=description,
                Quantity=quantity,
                UnitPrice=unitprice
            };
            ProductManager.Insert(product);
           Console.WriteLine("POST HTTP Insert method is invoked after form submission");
            return View(product);  
        }

         [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = ProductManager.Get(id);
            return View(product);  
        }
        
         [HttpPost]
        public IActionResult Update(Product modifiedProduct)  
        {
           ProductManager.Update(modifiedProduct);
           Console.WriteLine( "POST HTTP Insert method is invoked after form submission");
            return RedirectToAction("index","products"); 
        }
         public ActionResult Details(int id)
        {
            Product Product = ProductManager.Get(id);
            this.ViewData["products"]=Product;
            return View();
        }

       

        public ActionResult Delete(int id)
        {  
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
