using System;
using Banking;
namespace HandlerTest
{
    class Program
    {
        public delegate void AccountOperation();

        static void Main(string[] args)
        {
            Handler theHandler=new Handler();


            AccountOperation operation1=new AccountOperation(theHandler.SendEmailNotification);
            AccountOperation operation2=new AccountOperation(theHandler.PayIncomeTax);
            AccountOperation operation3=new AccountOperation(theHandler.BlockAccount);
            AccountOperation  operation=operation1;
            operation+=operation2;
            operation+=operation3;
            operation();


            Console.WriteLine("Hello World!");
        }
    }
}
