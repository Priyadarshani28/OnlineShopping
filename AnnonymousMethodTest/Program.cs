using System;

namespace AnnonymousMethodTest
{ 
    public delegate void BasicOperation();
    public delegate void  DoSomething();
    public delegate int anonymousOperation1(int i);
    public delegate int anonymousOperation2(int a, int b);
    class Program
    {
        void PrintReport(){
             Console.WriteLine("Printing a Report : graph, table, score card");
        }
        static void Main(string[] args)
        {

            Program theProgram = new Program();
            BasicOperation method1=new BasicOperation(theProgram.PrintReport);
            method1();

            BasicOperation method2= delegate(){
            Console.WriteLine("Printing Company Annual Report");
           
                  };
            method2();

//Lambda Method
                 DoSomething method3=()=>
                 { 
                     Console.WriteLine("Printing Covid spread Lockdown Report");
                 };

                    anonymousOperation1 proxy1 = new anonymousOperation1(  
                                                            delegate(int x){  
                                                                return x * 2;
                                                            }
                                );  
                               // method3();
                      Console.WriteLine("{0}", proxy1(5));  

                   anonymousOperation1 proxy2=x=>x*2;  
                   Console.WriteLine("{0}", proxy2(25));  

        
                   anonymousOperation2 getBigInteger = (x, y) => { if (x > y) return x; else return y; };  
                   Console.WriteLine(getBigInteger(10,15));  

      
                 Console.WriteLine("Welcome to .NET Core Programming!");
        }
    }
}
           
 