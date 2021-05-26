using System;
using System.Collections.Generic;

namespace DisconnectedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool status=CustomerDBManager.Delete(29);
            List<Customer> allCustomers=CustomerDBManager.GetAll();
            foreach( Customer customer in allCustomers)
            {
              Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Location);
            }   
        }
    }
}