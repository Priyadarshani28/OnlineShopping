using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using CRM;

namespace TransflowerStoreWeb.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
           List<Customer> allCustomers= CRM.CustomerManager.GetAll();
           this.ViewData["customers"]=allCustomers;
            return View();  
        }
         public ActionResult Details(int id)
        {
            Customer theCustomer =CustomerManager.GetById(id);
            this.ViewData["customer"]=theCustomer;
            return View();
        }

        public ActionResult Delete(int id)
        { 
            CustomerManager.Delete(id);
            return RedirectToAction("Index");
        }
        
         // GET Request for Insert
        [HttpGet]
        public IActionResult Insert()
        {
           return View();  
        }

        [HttpPost]
        public IActionResult Insert(int id,string name, string contactNumber,string email, string location, int age )
        {
            Customer customer=new Customer(){
                Id=id,
                Name=name,
                ContactNumber=contactNumber,
                Email=email,
                Location=location,
                Age=age
            };
            CustomerManager.Insert(customer);
            return View();  
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Customer customer = CustomerManager.GetById(id);
            return View(customer);  
        }

        [HttpPost]
        public IActionResult Update(Customer modifiedCustomer)   /// best practice to send or receive data is using model binding
       {
           CustomerManager.Update(modifiedCustomer);// send data to BLL----DAL----database
           return RedirectToAction("index","customers"); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
