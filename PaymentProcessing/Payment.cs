using System;

namespace PaymentProcessing
{
        // you can not create object from class

    // Parent Class
    // Super Class
    
        public class Payment
        {
        public int PaymentID{get;set;}
        public int CustomerId{get;set;}
        public DateTime PaymentDate{get;set;}
        public int Amount{get;set;}

        }
    // condition: minumum one function need to be abstract
    public abstract class Payments 
    {
        
        public double cash;
        public double getcash() 
        {
                return cash;
        }
        public void setcash(double newval) 
        {
                this.cash = newval;
        }
        public abstract void PaymentDetails() ;
    }
}
