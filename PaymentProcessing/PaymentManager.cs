
using System;

using System.Collections.Generic;

namespace PaymentProcessing
{
     public  static class PaymentManager
    {   
         public static List<Payment> GetAll() 
        {
            List<Payment> payments = new List<Payment>();
            payments=PaymentDBManager.GetAll();
            return payments;
        }

    public static Payment GetById(int paymentId)
        {
            Payment thePayment=null;
           thePayment=PaymentDBManager.GetById(paymentId);
            return thePayment;
        }
    public static bool Delete(int paymentId)
        {
            bool status = false;
            status=PaymentDBManager.Delete(paymentId);
            return status;
        }   
    public static bool Update(Payment payment)
        {
            bool status = false;
            status=PaymentDBManager.Update(payment);
            return status;
        }
    public static bool Insert(Payment payment)
        {
            bool status = false;
               status=PaymentDBManager.Insert(payment);
            return status;
        }
  }
}
