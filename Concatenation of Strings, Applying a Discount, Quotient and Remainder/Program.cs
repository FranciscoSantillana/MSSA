using System;

namespace Concatenation_of_Strings__Applying_a_Discount__Quotient_and_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Concatenation of Strings
            string a, b, c; //Declared Variables 
            Console.WriteLine("Enter your First Name");
            a = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            b = Console.ReadLine();
            c = a + " " + b; // This is where I implemented concatenation.
            Console.WriteLine($"Your name is {c}");
            Console.ReadKey();

            ////Sales Discount Exercise:
            double p, d;
            Console.WriteLine("What is the price of your item");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your discount percentage?");
            d = double.Parse(Console.ReadLine());
            p = (p - p * (d /100));
            Console.WriteLine($"Your new price is ${p}");


            ////Write a program that prompts the user to enter two integers and then calculates the quotient and the remainder of the integer division
            int numbera, numberb, quotient, remainder;
            Console.WriteLine("enter a number");
            numbera = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            numberb = int.Parse(Console.ReadLine());
            quotient = numbera / numberb;
            Console.WriteLine($"your quotient is {quotient}");
            remainder = numbera % numberb;
            Console.WriteLine($"your remainder is {remainder}");
        }
    }
}
