
using System;
using System.Collections.Generic;

namespace OrderProcessing
{
    public  static class OrderManager
    {
        public static List<Order> GetAll() 
        {
            List<Order> orders = new List<Order>();
             orders=OrderDBManager.GetAll();
            return orders;
        }
        public static Order GetById(int orderId)
        {
            Order theOrder=null;
           theOrder=OrderDBManager.GetById(orderId);
            return theOrder;
        }
        public static bool Delete(int OrderId)
        {
            bool status = false;
            status=OrderDBManager.Delete(OrderId);
            return status;
        }   
        public static bool Update(Order Order)
        {
            bool status = false;
             status=OrderDBManager.Update(Order);
            return status;
        }
        public static bool Insert(Order Order)
        {
            bool status = false;
            status=OrderDBManager.Insert(Order);
            return status;
        }
    }
}