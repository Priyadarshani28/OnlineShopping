using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StudentMongoDBTest
{
     public class Customer  
    {  
        public ObjectId Id { get; set; }  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public string City { get; set; }  
        public string Age { get; set; }  
    } 
     public class Program
    {
        protected static IMongoClient client;
        protected static IMongoDatabase database;
        public static Customer GetCustomer()
        {
            Console.WriteLine("Please enter customer First name :");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter customer Last name :");
            string lastname = Console.ReadLine();
            Console.WriteLine("Please enter customer Age :");
            string age = Console.ReadLine();
            Console.WriteLine("Please enter customer City name :");
            string city = Console.ReadLine();

            Customer customer= new Customer()
            {
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                City = city,

            };
            return customer;
        }

            public static void CRUDwithMongoDb()
            {
                client = new MongoClient();
                database = client.GetDatabase("Ecommerce");
                var collection = database.GetCollection<Customer>("customers");

                Console.WriteLine("Press select your option from the following\n1 - Insert\n2 - UpdateOne Document\n3 - Delete\n4 - Read All\n");
                string userSelection = Console.ReadLine();

                switch(userSelection)
                {
                    case "1" :
                           collection.InsertOne(GetCustomer());
                           break;

                    case "2" :
                            var obj1 =GetCustomer();

                            collection.FindOneAndUpdate<Customer>
                            (Builders<Customer>.Filter.Eq("FirstName", obj1.FirstName),  
                            Builders<Customer>.Update.Set("LastName", obj1.LastName).Set("City", obj1.City).Set("Age", obj1.Age));  
                    break;  

                    case "3":   
                                
                            Console.WriteLine("Please Enter the first name to delete the record(so called document) : ");  
                            var deletefirstName = Console.ReadLine();  
                            collection.DeleteOne(s => s.FirstName == deletefirstName);  
                    break;  
                     
                    case "4":   
                  
                            var all = collection.Find(new BsonDocument());  
                             Console.WriteLine("Show Data"); 
  
                           foreach (var i in all.ToEnumerable())  
                           {  
                               Console.WriteLine(i.Id + "  " + i.FirstName + "\t" + i.LastName + "\t" + i.Age + "\t" + i.City);  
                           }  
                           
                    break;  
  
                default:  
                    Console.WriteLine("Please choose a correct option");  
                    break; 

                }
               Console.WriteLine ("\n*******************************************************************************************\nPress Y for continue...\n");  
                string userChoice = Console.ReadLine();
                if (userChoice == "Y" | userChoice == "y")
                {
                    CRUDwithMongoDb();
                }

            }
        
        static void Main(string[] args)
        {
            CRUDwithMongoDb();
            Console.WriteLine("Hello World!");
        }
    }
}
