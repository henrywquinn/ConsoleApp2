using System;
namespace ConsoleApp2
{
    
   
    
    class Program
    {

    

        static void Main(string[] args)
        {
            Console.WriteLine("What is your first number?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            var num2 = int.Parse(Console.ReadLine());

          
            Console.WriteLine(Secondary(num1, num2));




        }

       
        public static int Secondary(int num1, int num2)
        {
            
            int sum = num1 + num2;


            return sum;

        }



    }



}
