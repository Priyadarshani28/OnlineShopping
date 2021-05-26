using System;

namespace ExtensionMethodTest
{
        public sealed class MathsHelper 
    {
        public int Addition(int num1, int num2){
            return num1+ num2;
        }
        public int Subtraction(int num1, int num2){
            return num1 - num2;
        }
    }

    public class Person{
        public string GetFullName(){
            return "Priyadarshani Deshmukh";
        }
    }
    public static class UtilityManager
    {
        public static int Multiplication( this MathsHelper m,int num1, int num2){
            return num1 * num2;
        }      
        public static int Division(this MathsHelper m,int num1, int num2){
            return num1 /num2;
        }

        public static string GetNationalityDetails(this Person p){
            return "Indian";
        }


        public static string GetStarPrifix(this string  name){

            return  "******"+ name;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathsHelper mathEngine=new MathsHelper();

            int number1=45;
            int number2=23;

           

            int result1=mathEngine.Addition(number1,number2);
            Console.WriteLine("Addition Result=" + result1);
            int result2=mathEngine.Subtraction(number1,number2);
            Console.WriteLine("Subtraction Result=" + result2);

            // Extension method call

            int result3=mathEngine.Multiplication(number1,number2);
             Console.WriteLine("Multiplication Result=" + result3);

            int result4=mathEngine.Division(number1,number2);
             Console.WriteLine("Division Result=" + result4);


             Person thePerson=new Person();
             string fullName=thePerson.GetFullName();           
             string country=thePerson.GetNationalityDetails();  

            Console.WriteLine(fullName + "  " + country);

            string state="Maharashtra";

            Console.WriteLine(state.GetStarPrifix());

           
        }
    }
}