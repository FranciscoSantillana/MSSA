using System;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
         


         

         // Exercise 3: Get two numbers from the user and display the greater number
            Console.WriteLine("Please input a number");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input another number");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine(Greater(d,e));

        }

        static double FeetToInches(double I)
        {
            return I * 12;
        }

        static double TuitionCalculator (double tuition)
        {
            tuition = 6000;
            double i;
            for (i = 1; i<= 5 ; i++)
            {
             Console.WriteLine($"for year {i} your tuition is {tuition}");
             tuition += tuition * 0.02;
            }
            return tuition;
        }

        static string Greater(double d, double e)
        {
            if (d < e)
            {
                return $"{e} is greaer than {d}";
            }

            else if (d > e)
            {
                return $"{d} is greater than {e}";
            }
            else if (d == e)
            {
                return $"{d} = {e}";
            }
            else
            {
                return $"{e} = {d}";
            }
        }
    }

    
}
