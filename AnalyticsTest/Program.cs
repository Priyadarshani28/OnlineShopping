using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;




namespace AnalyticsTest
{
   
 
    class Program
    {
    static void Main(string[] args)
        {
           /* FindAllNumbersMultipleOf2();
            ShowAllNames();
            GetReport();

            */

                /*TakeThree();
                Skip();

                IEnumerable<string> fruits= GetFruitsOrderBy();     
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }*/
            
            //SimpleUnion();
            //SimpleIntersect();

            //SimpleExcept();

           Console.WriteLine("Sold out Products");
           //GetProductsOrderBy()
         /*  IEnumerable<Product> soldOutProducts= GetSoldOutProducts();

           foreach (Product theProduct in soldOutProducts)
           {
               Console.WriteLine(theProduct.Title  + "  "+ theProduct.UnitPrice + " " + theProduct.Quantity);
           }


        */
        IEnumerable<Product> products=GetAllProductsFromMySqlDatabase();
        Product productupdate=new Product{
                Id=14,
                Title="Carnation",
                Description="Favourite Flower",
                UnitPrice=45,
                Quantity=3000,
                ImageUrl="/ImageUrl/carnation.jpg",
        };
        ProductDBManager.Update(productupdate);

         Product newProduct=new Product{
                Id=30,
                Title="Lily",
                Description="Popular Flower",
                UnitPrice=67,
                Quantity=8000,
                ImageUrl="/ImageUrl/lily.jpg",
        };
        ProductDBManager.Insert(newProduct);
       
        Product productDelete=new Product{
              
        };
       bool status=ProductDBManager.Delete(30);

      //  IEnumerable<Product> products=ProductDBManager.GetAll();

       /*  foreach (Product theProduct in products)
           {
               Console.WriteLine(theProduct.Title  + "  "+ theProduct.UnitPrice + " " + theProduct.Quantity);
           }*/
        }

   
    static void FindAllNumbersMultipleOf2(){
      
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };  
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);  

        foreach (var num in evenNumbers)  
        {     Console.Write("{0} ", num);   }  
        Console.WriteLine();  
    }

   
    static void ShowAllNames(){

        List<Person> participants = new List<Person>() {   
            new Person { FirstName = "Sakshi",LastName = "Datrange" ,Age = 19 },  
            new Person { FirstName = "Neha",LastName = "Bhor", Age = 21 },  
            new Person { FirstName = "Nikita",LastName = "Akhade", Age = 23 } ,
            new Person { FirstName = "Priya",LastName = "Deshmukh", Age = 23},  
            new Person { FirstName = "Swarali",LastName = "Lakade", Age =23 },  
            new Person { FirstName = "Ankur",LastName = "Prasad", Age = 28 }  
        }; 

        var peopleResult = participants.Select(x => new {
                                                            Age = x.Age, 
                                                            FirstLetter = x.FirstName,
                                                            LastNameLetter = x.LastName[0] 
                                                         }
                                        );  

        foreach (var person in peopleResult)  
        {  Console.WriteLine(person);  }   
    }

   
    static void GetReport()
    {
        string[] students = new string[] { "Neha", "Akanksha", "Mayuresh", "Shubham","Bill" ,
                                            "Rohit", "Siddhachakra" ,"Ajinkya","Sumeet","Hemant","Mohit",
                                            "Amol","Rajiv","Kimaya","Santosh","Nilesh","Umesh","Manishankar",
                                            "Amitabh","Swarali","Kamal","Steve","Priyadarshani","Jaiprakash",
                                            "Rutuja"
                                        };

      /*  var filterNamebyChar = students.Where(n => n.Contains('i'));
        var NamesOrderedBy = filterNamebyChar.OrderBy(n => n.Length);
        var InUpperCase = NamesOrderedBy.Select(n => n.ToUpper());
*/

      var InUpperCase = students.Where(n => n.Contains('i')).OrderBy(n => n.Length).Select(n => n.ToUpper());

        Console.WriteLine("\nStudents names containing i in Inreasing Order in Upper Case ");
        
        foreach (var item in InUpperCase)
        {  Console.WriteLine(item); }
    }
    public static void TakeThree()
    {
        int [] numbers={34,65,23,87,12,98,23,56,87};
        var first3Numbers=numbers.Take(3);
         foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
    }
    public static void Skip()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var allButFirst4Numbers = numbers.Skip(4);
        Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
    }
    public static IEnumerable<string> GetFruitsOrderBy(){
         string[] fruits = { "cherry", "apple", "blueberry","banana", "mango" };
        
         var sortedFruits= from fruit in fruits orderby fruit descending select fruit;

        return sortedFruits;
    }
     public static void SimpleUnion(){
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };

        var uniqueNumbers = numbersA.Union(numbersB);
        Console.WriteLine("Unique numbers from both arrays:");
        foreach (var n in uniqueNumbers)
        {
            Console.WriteLine(n);
        }
     }

    public static void SimpleIntersect()
    {
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var commonNumbers = numbersA.Intersect(numbersB);
        Console.WriteLine("Common numbers shared by both arrays:");
        foreach (var n in commonNumbers)
        {
            Console.WriteLine(n);
        }
    }

    public static void SimpleExcept()
    {
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };

        IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);
        Console.WriteLine("Numbers in first array but not second array:");
        foreach (var n in aOnlyNumbers)
        {
            Console.WriteLine(n);
        }
    }
    public static void ToSimpleList()
    {
        string[] words = { "cherry", "apple", "blueberry" };
        var sortedWords =
                            from w in words
                            orderby w
                            select w;

        var wordList = sortedWords.ToList();

        Console.WriteLine("The sorted word list:");
        foreach (var w in wordList)
        {
            Console.WriteLine(w);
        }
    }

     public static void ToDictionary(){

        var scoreRecords = new[] {  new {   Name = "Ankur", Score = 89},
                                    new {   Name = "Sakshi", Score = 76},
                                    new {   Name = "Umesh", Score = 68},
                                    new {   Name = "Neha", Score = 72},
                                    new {   Name = "Priya", Score = 76},
                                    new {   Name = "Nikita", Score = 45},
                                    new {   Name = "Swarali", Score = 45},
                                    new {   Name = "Rutuja", Score = 45}
        };

          var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);  


     }

    
      public static IEnumerable<Product> GetAllProducts(){

        List<Product> allProducts = new List<Product>();
        allProducts.Add(new Product { Id = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Quantity = 5000,Likes=4000 });
        allProducts.Add(new Product { Id = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", Quantity = 7000 ,Likes=4000 });
        allProducts.Add(new Product { Id = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", Quantity = 3400,Likes=4000  });
        allProducts.Add(new Product { Id = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", Quantity = 27000,Likes=4000  });
        allProducts.Add(new Product { Id = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", Quantity = 1000,Likes=4000  });
        allProducts.Add(new Product { Id = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", Quantity = 2000 ,Likes=4000 });
        allProducts.Add(new Product { Id = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", Quantity = 159,Likes=4000  });
        allProducts.Add(new Product { Id = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", Quantity = 67,Likes=4000  });
        allProducts.Add(new Product { Id = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Quantity = 5000,Likes=4000  });
        allProducts.Add(new Product { Id = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", Quantity = 0,Likes=4000  });
        allProducts.Add(new Product { Id = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", Quantity = 0,Likes=4000  });
        allProducts.Add(new Product { Id = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", Quantity = 700,Likes=4000  });
        allProducts.Add(new Product { Id = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", Quantity = 1500,Likes=4000  });
        allProducts.Add(new Product { Id = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", Quantity = 2300,Likes=4000  });
        allProducts.Add(new Product { Id = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Quantity = 10000,Likes=4000  });
        
        return allProducts;

    }
    public static IEnumerable<Product> GetAllProductsFromMySqlDatabase(){

      
        List<Product> allProducts = new List<Product>();
        string connStr = "server=localhost;user=root;database=Ecommerce;password='Priya@2811'";
        MySqlConnection conn = new MySqlConnection(connStr); 
        try{
            string query="SELECT * FROM flowers";
            MySqlCommand command=new MySqlCommand(query,conn);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
           
            while (reader.Read())
            {

                Console.WriteLine(reader[0] + " -- " + reader[1] + " -- " + reader[2]);
            }
            reader.Close();
         }
         catch(Exception ee){
             Console.WriteLine(ee.Message);
         }
         finally{
             conn.Close();
         }
        return allProducts;
    }

     public static IEnumerable<Product> GetAllProductsFromOracleDatabase(){

        List<Product> allProducts = new List<Product>();
       
        return allProducts;
    }


     public static IEnumerable<Product> GetAllProductsFromMongoDBDatabase(){

        List<Product> allProducts = new List<Product>();
       
        return allProducts;
    }

    public static IEnumerable<Product> GetAllProductsFromJSONFile(){

        List<Product> allProducts = new List<Product>();
       
        return allProducts;
    }

    public static IEnumerable<Product> GetAllProductsFromBinaryFile(){

        List<Product> allProducts = new List<Product>();
        
        return allProducts;
    }

    public static IEnumerable<Product> GetAllProductsFromMongoDB(){

        List<Product> allProducts = new List<Product>();
       
        return allProducts;
    }

    public static IEnumerable<Product> GetProductsOrderBy()
    {
        
       IEnumerable<Product> products = GetAllProducts();
      
        var sortedProducts =
                            from product in products
                            orderby product.Quantity
                            select product;

        return sortedProducts;
    }  

    //Bussiness Logic layer

    public static IEnumerable<Product> GetSoldOutProducts(){


        IEnumerable<Product> products=GetAllProducts();
        var soldOutProducts = from prod in products
                              where prod.Quantity == 0
                              select prod;

        return soldOutProducts;
    }

    public static IEnumerable<Product> GetProuductsInStockLessthan(int amount)
    {
        IEnumerable<Product> products = GetAllProducts();
        var expensiveInStockProducts =
            from prod in products
            where prod.Quantity > 0 && prod.UnitPrice > amount
            select prod;
        return expensiveInStockProducts;
    }

     public static dynamic GetProductDetails()
        {
            IEnumerable<Product> products = GetAllProducts();
            var productInfos =
                                from prod in products
                                select new { prod.Title, prod.Category, Price = prod.UnitPrice };
            return productInfos;         
        }


    public static IEnumerable<string> GetProductsDistinct()
    {
        IEnumerable<Product> products = GetAllProducts();

        var categoryNames = ( from prod in products
                              select prod.Category
                            ).Distinct();
        
        return categoryNames;
    } 

    public static dynamic  GetProductCount()
    {
        IEnumerable<Product> products = GetAllProducts();
        var categoryCounts =
                            from prod in products
                            group prod by prod.Category into prodGroup
                            select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };
        return categoryCounts;
    }
}
}