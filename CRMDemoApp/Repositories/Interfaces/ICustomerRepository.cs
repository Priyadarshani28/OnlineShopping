using CRMDemoApp.Models;
using System.Collections.Generic;

namespace CRMDemoApp.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer GetById(int id);
    
    }
}
