using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace SerializationTest
{
    [Serializable]
    public class Product {  
        public  int Likes{get;set;}
        public int Id{get;set;}
        public string Title {get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}
    }  

  

    class Program
    {
        static void Main(string[] args)
        {

 
            
            Product theProduct = new Product();  
           
            theProduct.Id=34;
            theProduct.Title="Gerbera";
            theProduct.Description="Wedding flower";
            theProduct.UnitPrice=5;
            theProduct.Quantity=123;
            theProduct.Likes=4000;
            theProduct.ImageUrl="/images/gerbera.jpg";

           
            Product theProduct1 = new Product();  

            theProduct1.Id=34;
            theProduct1.Title="Tulip";
            theProduct1.Description="best flower";
            theProduct1.UnitPrice=15;
            theProduct1.Quantity=12367;
            theProduct1.Likes=5000;
            theProduct1.ImageUrl="/images/tulip.jpg";

            
            // container : cosist of two product instances
            List<Product> products=new List<Product>();

            products.Add(theProduct);
            products.Add(theProduct1);
            
      
            products.Add(new Product{ Id=35, Title="Carnation", Description="White wash Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/gerbera.jpg"});
            products.Add(new Product{ Id=35, Title="Lily", Description="Delicate Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/lily.jpg"});
            products.Add(new Product{ Id=35, Title="Lotus", Description="Worship Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/lotus.jpg"});
            products.Add(new Product{ Id=35, Title="Marigold", Description="Festival Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/marigold.jpg"});
            products.Add(new Product{ Id=35, Title="Rose", Description="Valentine Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/rose.jpg"});
            products.Add(new Product{ Id=35, Title="Tulip", Description="Kashmir Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/tulip.jpg"});
            products.Add(new Product{ Id=35, Title="Auster", Description="Beautiful   Flower", UnitPrice=10, Quantity=10000, Likes=54000, ImageUrl="/images/auster.jpg"});
         

            
            foreach( Product product in products){
                  
                   Console.WriteLine($" Flower :{product.Title} : {product.Description} :{product.Likes}");   
            }

        

            try{
                
                Stream stream=new FileStream("products.bin",FileMode.Create ,FileAccess.Write,FileShare.None);
                BinaryFormatter formatter=new BinaryFormatter();
               
                formatter.Serialize(stream,products);
                stream.Close();

            }
            catch(Exception exp){

            }
            finally{
            }
               

            
            Console.WriteLine("After Deserializtion , retrived Products......");
            try{
                  BinaryFormatter formatter = new BinaryFormatter();  
                  Stream stream=new FileStream("products.bin",FileMode.Open,
                                               FileAccess.Read,FileShare.Read);
                  List<Product> productsFromFile=(List<Product>)formatter.Deserialize(stream);                           
                  foreach( Product product in productsFromFile)
                  {
                    Console.WriteLine($"{product.Title} : {product.Description} : {product.Likes}");   
                  }
                 stream.Close(); 

            }
            catch(Exception exp){

            }
            finally{

            }
           
    
           
            try{
               
                var options=new JsonSerializerOptions {IncludeFields=true};
                var produtsJson=JsonSerializer.Serialize<List<Product>>(products,options);
                string fileName="products.json";
                File.WriteAllText(fileName,produtsJson);

              
                 string jsonString = File.ReadAllText(fileName);

                List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
                Console.WriteLine(" Deserializing data from json file");
                foreach( Product product in jsonProducts)
                {
                    Console.WriteLine($"{product.Title} : {product.Description}");   
                }   
            }
            catch(Exception exp){

            }
            finally{

            }
        
         Console.WriteLine("Hello World!");
        }
    }
} 