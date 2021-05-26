using System.Collections.Generic;
using System;
using System.Linq;
using CRMDemoApp.Models;


namespace CRMDemoApp.ORM
{
    public class DBManager : IDBManager
    {
        public void Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Customers.Remove(context.Customers.Find(id));
                context.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using (var context = new CollectionContext())
            {
             var customers = from cust in context.Customers select cust;
             return customers.ToList<Customer>();
            }
        }

        public Customer GetById(int id)
        {
            using (var context = new CollectionContext())
            {
             var customer = context.Customers.Find(id);
             return customer;
            }
        }

        public void Insert(Customer customer)
        {
            using(var context = new CollectionContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();   ////
            }
        }

        public void Update(Customer customer)
        {
            using(var context = new CollectionContext())
            {
                var theCustomer = context.Customers.Find(customer.Id);
                theCustomer.Name =customer.Name;
                theCustomer.Location=customer.Location;
                theCustomer.ContactNumber=customer.ContactNumber;
                 theCustomer.Age=customer.Age;
                  theCustomer.Email=customer.Email;
                context.SaveChanges();
            }
        }
    }
}