
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PaymentProcessing
{
    public  static class PaymentDBManager
    {
        public static string conString = @"server=localhost;user=root;database=ecommerce;password='Priya@2811'";
        public static List<Payment> GetAll() 
            {
                List<Payment> payments = new List<Payment>();
                IDbConnection con = new MySqlConnection(conString);
                string query = "SELECT * FROM payment";
                IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            
                try
                {
                    con.Open(); 
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int paymentid = int.Parse(reader["PaymentID"].ToString());
                        int customerid = int.Parse(reader["CustomerId"].ToString());
                        DateTime paymentdate=DateTime.Parse(reader["PaymentDate"].ToString());
                        int amount = int.Parse(reader["Amount"].ToString());
                        
                         
                        payments.Add(new Payment()
                        {
                            PaymentID = paymentid,
                            CustomerId=customerid,
                            PaymentDate=paymentdate,
                            Amount=amount
                           
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
                return payments;
            }
        public static Payment GetById(int paymentId)
            {
                Payment thePayment=null;
                try
                {       
                    MySqlConnection con = new MySqlConnection(conString);
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "SELECT * FROM payment WHERE PaymentID=@PaymentID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@PaymentID", paymentId)); 
                    IDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int paymentid = int.Parse(reader["PaymentID"].ToString());
                        int customerId = int.Parse(reader["CustomerId"].ToString());
                        DateTime paymentdate=DateTime.Parse(reader["PaymentDate"].ToString());
                        int amount = int.Parse(reader["Amount"].ToString());
       
                        thePayment=new Payment()
                        {
                            PaymentID = paymentid,
                            CustomerId=customerId,
                            PaymentDate=paymentdate,
                            Amount=amount
                           
                        };
                    }
                    reader.Close();
                    if (con.State == ConnectionState.Open)
                    con.Close();
                }
                catch (MySqlException ee) {
                    string message = ee.Message;
                }
                return thePayment;
            }
        public static bool Delete(int paymentId)
            {
                bool status = false;
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "DELETE FROM payments WHERE PaymentID=@PaymentID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@PaymentID", paymentId)); 
                    cmd.ExecuteNonQuery();  
                    if (con.State == ConnectionState.Open)
                    con.Close();
                    status = true;
                }
                catch (MySqlException ee) {
                    string message = ee.Message;
                }
                return status;
            }   

            
        public static bool Update(Payment payment)
            {
                bool status = false;
                try
                {
                MySqlConnection con = new MySqlConnection(conString);
                    {
                        if (con.State == ConnectionState.Closed)
                        con.Open();

                        string query = "UPDATE payment SET custmerid=@CustomerId, paymentdate=@PaymentDate, " +
                                        "amount=@Amount " + "WHERE pyamentid=@PaymentID";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add(new MySqlParameter("@PaymentID", payment.PaymentID));
                         cmd.Parameters.Add(new MySqlParameter("@CustomerId", payment.CustomerId));
                        cmd.Parameters.Add(new MySqlParameter("@PaymentDate", payment.PaymentDate));
                        cmd.Parameters.Add(new MySqlParameter("@Amount", payment.Amount));
                    
                        cmd.ExecuteNonQuery();  
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
             public static bool Insert(Payment payment)
            {
                bool status = false;
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    {
                        if (con.State == ConnectionState.Closed)

                        con.Open();
                        string query = "INSERT INTO payment (id,custid,pdate, amount) " +
                                        "VALUES (@PaymentID, @CustomerId,PaymentDate,@Amount)";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add(new MySqlParameter("@PaymentID", payment.PaymentID));
                        cmd.Parameters.Add(new MySqlParameter("@CustomerId", payment.CustomerId));
                        cmd.Parameters.Add(new MySqlParameter("@Amount", payment.Amount));
                        cmd.Parameters.Add(new MySqlParameter("@PaymentDate", payment.PaymentDate));
                        
                  
                        
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