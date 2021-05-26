using CRMDemoApp.Repositories.Interfaces;
using System.Collections.Generic;

namespace CRMDemoApp.ORM
{
    public class CustomerRepository : ICustomerRepository
    {
        private Customer allCustomer;

        public List<Customer> GetAll()
        {
            CRMDemoApp.ORM.IDBManager dbm=new CRMDemoApp.ORM.DBManager();
            List<Customer> items=new List<Customer>();          
            List<CRMDemoApp.ORM.Customer> allCustomer=dbm.GetAll();
           
            foreach (Customer theCustomer in allCustomer)
            {
                items.Add(new Customer{
                    Id=theCustomer.Id,
                    Name=theCustomer.Name,
                    Location=theCustomer.Location,
                    Age=theCustomer.Age,
                    ContactNumber=theCustomer.ContactNumber,
                    Email=theCustomer.Email,
                });
            }
            return items;
        }
        public Customer GetById(int id)
        {
            List<Customer> allCustomers=GetAll();
            var found = allCustomers.Find(x => x.Id == id);
             allCustomer=found as Customer;
            return allCustomer;
        }

        List<Models.Customer> ICustomerRepository.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Models.Customer ICustomerRepository.GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
