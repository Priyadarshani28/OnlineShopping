
using CRMDemoApp.Models;
using CRMDemoApp.Repositories.Interfaces;
using CRMDemoApp.Services.Interfaces;
using System.Collections.Generic;

namespace CRMDemoApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _custRepo;
        public CustomerService(ICustomerRepository custRepo)
        {
            _custRepo = custRepo;
        }
        public List<Customer> GetAll()=> _custRepo.GetAll();
        public Customer GetById(int id)=> _custRepo.GetById(id);
       
    }
} 