using Microsoft.AspNetCore.Mvc;
using CRMDemoApp.Services.Interfaces;
public class CustomersController : Controller
    {
         private readonly ICustomerService _customerService;
         public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customer = _customerService.GetAll();
            return View(customer);
        }

        
        public IActionResult Insert()
        {
            return View();
        }
    }