using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace OrderProcessing
{
    public  static class OrderDBManager
    {
        public static string conString = @"server=localhost;user=root;database=Ecommerce;password='Priya@2811'";
        public static List<Order> GetAll() 
            {
                List<Order> orders = new List<Order>();
                IDbConnection con = new MySqlConnection(conString);
                string query = "SELECT * FROM orders";
                IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            
                try
                {
                    con.Open(); 
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int orderId = int.Parse(reader["id"].ToString());
                        int customerId = int.Parse(reader["custid"].ToString());
                        DateTime orderDate=DateTime.Parse(reader["orderdate"].ToString());
                        string status=reader["status"].ToString();
                        string paymentMode=reader["paymentmode"].ToString();
                        double totalAmount=double.Parse(reader["totalamount"].ToString());
                        
                        orders.Add(new Order()
                        {
                            Id = orderId,
                            CustomerId=customerId,
                            OrderDate=orderDate,
                            Status=status,
                            PaymentMode=paymentMode,
                            TotalAmount=totalAmount 
                        });
                    }
                    reader.Close();
                }
                catch (MySqlException exp)
                {
                    string message = exp.Message;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                return orders;
            }
        public static Order GetById(int orderId)
            {
                Order theOrder=null;
                try
                {       
                    MySqlConnection con = new MySqlConnection(conString);
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "SELECT * FROM orders WHERE Id=@OrderId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@OrderId", orderId)); //Parameterized command handling
                    IDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int customerId = int.Parse(reader["custid"].ToString());
                        DateTime orderDate=DateTime.Parse(reader["orderdate"].ToString());
                        string status=reader["status"].ToString();
                        string paymentMode=reader["paymentmode"].ToString();
                        double totalAmount=double.Parse(reader["totalamount"].ToString());
        
                        theOrder=new Order()
                        {
                             Id = orderId,
                            CustomerId=customerId,
                            OrderDate=orderDate,
                            Status=status,
                            PaymentMode=paymentMode,
                            TotalAmount=totalAmount 
                        };
                    }
                    reader.Close();
                    if (con.State == ConnectionState.Open)
                    con.Close();
                }
                catch (MySqlException ee) {
                    string message = ee.Message;
                }
                return theOrder;
            }
        public static bool Delete(int orderId)
            {
                bool status = false;
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "DELETE FROM orders WHERE id=@OrderId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@OrderId", orderId)); //Parameterized command handling
                    cmd.ExecuteNonQuery();  // DML Operation
                    if (con.State == ConnectionState.Open)
                    con.Close();
                    status = true;
                }
                catch (MySqlException ee) {
                    string message = ee.Message;
                }
                return status;
            }   
        public static bool Update(Order order)
            {
                bool status = false;
                try
                {
                MySqlConnection con = new MySqlConnection(conString);
                    {
                        if (con.State == ConnectionState.Closed)
                        con.Open();

                        string query = "UPDATE orders SET custid=@CustomerId,orderdate=@OrderDate, paymentmode=@PaymentMode, " +
                                        "totalamount=@TotalAmount,status=@Status " + "WHERE id=@Id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add(new MySqlParameter("@Id", order.Id));
                        cmd.Parameters.Add(new MySqlParameter("@CustomerId", order.Id));
                        cmd.Parameters.Add(new MySqlParameter("@OrderDate", order.OrderDate));
                        cmd.Parameters.Add(new MySqlParameter("@PaymentMode", order.PaymentMode));
                        cmd.Parameters.Add(new MySqlParameter("@TotalAmount", order.TotalAmount));
                        cmd.Parameters.Add(new MySqlParameter("@Status", order.Status));
                        cmd.ExecuteNonQuery();  // DML Operation
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
                return status;
            }
        public static bool Insert(Order order)
            {
                bool status = false;
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    {
                        if (con.State == ConnectionState.Closed)

                        con.Open();
                        string query = "INSERT INTO orders (id,custid, totalamount,status, paymentmode, orderdate) " +
                                        "VALUES (@Id, @CustomerID,@TotalAmount, @Status,@PaymentMode, @OrderDate)";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add(new MySqlParameter("@Id", order.Id));
                        cmd.Parameters.Add(new MySqlParameter("@CustomerId", order.CustomerId));
                        cmd.Parameters.Add(new MySqlParameter("@TotalAmount", order.TotalAmount));
                        cmd.Parameters.Add(new MySqlParameter("@Status", order.Status));
                        cmd.Parameters.Add(new MySqlParameter("@PaymentMode", order.PaymentMode));
                        cmd.Parameters.Add(new MySqlParameter("@OrderDate", order.OrderDate));
                  
                        
                        cmd.ExecuteNonQuery();// DML

                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (MySqlException ex)
                {
                    string message = ex.Message;
                    throw ex;
                }
                return status;
            }
    }
}