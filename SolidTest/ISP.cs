using System;

namespace ISP 
{
    public interface IOrder
    {
        void AddToCart();
    }
    public interface IonlineOrder
    {
        void ProcessThroughPaymentGateway();

    }
    public class OnlineOrder : IOrder, IonlineOrder
    {
        public void AddToCart()
        {

        }
        public void ProcessThroughPaymentGateway()
        {

        }

        
    }
    public class OfflineOrder : IOrder{
        public void AddToCart()
        {
            
        }
    }
}