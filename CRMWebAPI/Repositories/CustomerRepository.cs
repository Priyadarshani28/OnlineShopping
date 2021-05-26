using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CRMWebAPI.Models;

namespace CRMWebWebAPI.Repositories
{
    public class CRMWebAPIRepository : ICRMWebAPIRepository
    {
        
        ICRMManager _cManager;
        

        public CRMWebAPIRepository(){
            _cManager=new CRMManager();
        }
        public List<Customer> GetAll()
        {
                return _cManager.GetAll();
        }
    
        public Customer GetById(int id)
        {
             return _cManager.GetById(id);
            
        }
        public bool Insert(Customer customer){
        return  _cManager.Insert(customer);
        }
        public bool Update(Customer customer){
           
            return _cManager.Update(customer);
        }
        
        public bool Delete(int id){
            

            return  _cManager.Delete(id);
            
        }
    }
}