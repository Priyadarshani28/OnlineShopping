using System;

namespace SRP
{
    public class Data{   }
    public class BusinessServer
    {
        public void Get(Data message)
        {
       
        }
    
        public void Process(Data message)
        {
       
        }
    
        public void Dispatch(Data message)
        {
            
        }
    }
    
    public interface IService
        {
            void Get(Data message);
            void Process(Data message);
            void Dispatch(Data message);
        }

  

public class PaymentServiceProvider:IService{
    public void Get(Data message)
    { }
    
    public void Process(Data message)
    {
        
    }
    public void Dispatch(Data message)
    {    }
}
    public class DeliveryServiceProvider : IService
    {
        public void Get(Data message)
        {        }
    
        public void Dispatch(Data message)
        {        }

        public void Process(Data message)
        {        }
    }

   public class BillingServiceProvider : IService
    {
        public void Get(Data message)
        {
        }
    
        public void Dispatch(Data message)
        {
        }

        public void Process(Data message)
        {
        }
    }

       public class Server
    {
        IService service;
    
        public Server(IService svc)
        {
            this.service = svc;
        }
    }
}