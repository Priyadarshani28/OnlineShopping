using System.Collections.Generic;
using CRMWebAPI.Models;
using CRMWebAPI.Repositories;

namespace CRMWebAPI.Services
{
    public class OrderService : ICRMService
    {
        private ICRMRepository _repo;
        public OrderService()
        {
            CRMRepository repository=new CRMRepository();
             this._repo = repository;
        }

        public List<Customer> GetAll()
        {
            if (_repo != null)
            {   
                return _repo.GetAll();
            }
            return null;
        }
        Customer ICRMService.GetById(int id)
        {
          return    _repo.GetOrderById(id);
        }

        bool ICustomer.Insert(Order order)
        {
            return _repo.Insert(order); 
        }

        bool IOrderService.Update(Order order)
        {
            return _repo.Update(order); 
        }

        bool IOrderService.Delete(int id)
        {
           return _repo.Delete(id);
        }
    }
}