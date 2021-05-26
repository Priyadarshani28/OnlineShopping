
using System.Collections.Generic;



namespace CRMDemoApp.ORM
{
    public interface IDBManager{
        List<Customer> GetAll();
        Customer GetById(int id);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
 }
