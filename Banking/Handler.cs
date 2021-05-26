using System;

namespace Banking {


    public class Handler{
       public void BlockAccount(){

              Console.WriteLine("The Account has been Blocked....");
            
       }
       public void SendEmailNotification(){

              Console.WriteLine("Email notification has been sent to the registered Email Address....");
       }

       public void PayIncomeTax(){

              Console.WriteLine("Income Tax has been deducted from your Account by Order....");
       }
    }
}