using System.Collections.Generic;
using CRMWebAPI.Models;
namespace CRMWebAPI.Repositories
{
    public interface ICRMManager
    {

    List<Customer> GetAll();

    Customer GetById(int id);
    bool Insert(Customer customer);
    bool Update(Customer customer);
    bool Delete(int id);
    }
}