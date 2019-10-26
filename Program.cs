using System;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            int firstno;
            int secondno;
            int result;
           System.Console.WriteLine("Welcome to my Calculator Application:");
           System.Console.WriteLine("Select what you want to do:");
           System.Console.WriteLine("1. Addition");
           System.Console.WriteLine("2. Subtraction");
           System.Console.WriteLine("3. Multiplication");
           System.Console.WriteLine("4. Divison");
           selection = System.Convert.ToInt32(Console.Readline());

            if(selection == 1)
            {
               firstno = System.Convert.ToInt32(Console.Readline());
               secondno = System.Convert.ToInt32(Console.Readline());
                result = firstno + secondno;
                System.Console.WriteLine("Answer is:"+result);
            }
            else if(selection == 2)
            {
                firstno = System.Convert.ToInt32(Console.Readline());
               secondno = System.Convert.ToInt32(Console.Readline());
                result = firstno - secondno;
                System.Console.WriteLine("Answer is:"+result);
            } 
            else if(selection == 3)
            {
                firstno = System.Convert.ToInt32(Console.Readline());
               secondno = System.Convert.ToInt32(Console.Readline());
                result = firstno * secondno;
                System.Console.WriteLine("Answer is:"+result);
            } 
            else if(selection == 4)
            {
                firstno = System.Convert.ToInt32(Console.Readline());
               secondno = System.Convert.ToInt32(Console.Readline());
                result = firstno/secondno;
                System.Console.WriteLine("Answer is:"+result);
            } 
            else
            {
                System.Console.WriteLine("Wrong Selection");
            }   
            }
        }
    }
}
