
using System;
using System.Data;
using System.Collections.Generic;

namespace CRM
{
     public  static class CustomerManager
    {
         public static List<Customer> GetAll() 
        {
            List<Customer> allCustomers = new List<Customer>();
            // customers=CustomerDBManager.GetAll();
           // return customers;
           allCustomers=GetAllProductsFromDatabase();
            return allCustomers;

        }
        public static List<Customer> GetAllProductsFromDatabase()
        {
            List<Customer> allCustomers = CustomerDBManager.GetAll();
            return allCustomers;

        }

        public static Customer GetById(int customerId)
        {
            Customer theCustomer=null;
           theCustomer=CustomerDBManager.GetById(customerId);
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            status=CustomerDBManager.Delete(customerId);
            return status;
        }   
        public static bool Update(Customer customers)
        {
            bool status = false;
            status=CustomerDBManager.Update(customers);
            return status;
        }
        public static bool Insert(Customer customers)
        {
            bool status = false;
            status=CustomerDBManager.Insert(customers);
            return status;
        }
  }
}