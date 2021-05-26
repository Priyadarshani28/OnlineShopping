using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using PaymentProcessing;

namespace TransflowerStoreWeb.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly ILogger<PaymentsController> _logger;
        public PaymentsController(ILogger<PaymentsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
           List<Payment> allPayments= PaymentManager.GetAll();
                 this.ViewData["payments"]=allPayments;
            return View();  
        }
 
         public ActionResult Details(int id )
        {
            Payment thePayment = PaymentManager.GetById(id );
            this.ViewData["payments"]=thePayment;
            return View();
        }

        public ActionResult Delete(int id)
        {
            PaymentManager.Delete(id);
            return RedirectToAction("Index");
        }
         [HttpGet]
        public IActionResult Insert()
        {
           return View();  
        }

        [HttpPost]
        public IActionResult Insert(int pid,int custid, DateTime pdate,int amount )
        {
            Payment payment=new Payment(){
                PaymentID=pid,
                CustomerId=custid,
                PaymentDate=pdate,
                Amount=amount,
              
            };
            PaymentManager.Insert(payment);
            return View();  
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Payment product = PaymentManager.GetById(id);
            return View(product);  
        }

        [HttpPost]
        public IActionResult Update(Payment repayment)   /// best practice to send or receive data is using model binding
        {
           PaymentManager.Update(repayment);// send data to BLL----DAL----database
           return RedirectToAction("index","payments"); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
