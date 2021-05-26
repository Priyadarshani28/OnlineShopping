using System.Collections.Generic;
using System;
using System.Linq;
using CRMWebAPI.Models;
using CRMWebAPI.Contexts;

namespace OrdersWebAPI.Repositories
{
    public class CRMManager :ICRMManager
    {
        public bool Delete(int id)
        {
            using (var context = new CollectionContext())
            {
                context.Customers.Remove(context.Customers.Find(id));
                context.SaveChanges();
            }
            return true;
        }
        public List<Customer> GetAll()
        {
            using (var context = new CollectionContext())
            {
             var customers = from cust in context.Customers select cust;
             return customers.ToList<Customer>();
            }
        }
        public Order GetById(int id)
        {
            using (var context = new CollectionContext())
            {
                var customers = context.customers.Find(id);
                return customers;
            }
        }
        public bool Insert(Customer customer)
       
        {
            using (var context=new CollectionContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            return true;
        }
        public bool Update(Customer customer)
        {
            using(var context = new CollectionContext())
            {
                var newcustomer =context.cudtomers.Find(customer.Id);
                newcustomer.id=customer.Id;
                newcustomer.name=customer.Name;
                newcustomer.contactnumber=customer.ContactNumber;
                newcustomer.email=customer.Email;
                newcustomer.location=newcustomer.Location;
                newcustomer.age=customer.Age;
                context.SaveChanges();
            }
            return true;
        }

    }
}