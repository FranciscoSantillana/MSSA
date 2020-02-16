using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Jan22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number for a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("number for b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"your lowest value is {FindMin(a, b)}.");
            Console.ReadLine();


            Console.WriteLine("enter your height in inches");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your weight in lbs");
            double weight = double.Parse(Console.ReadLine());

            double Scale = BMI(height, weight);

            Console.ReadKey();
        }
        static int FindMin(int a, int b)
        {
            int lowestOne = 0;

            if (a < b)
            {
                lowestOne = a;
            }
            if (a > b)
            {
                lowestOne = b;
            }

            return lowestOne;
        }
        static double BMI(double height, double weight)
        {
            double bMI = (weight * 703) / (height * height);

            if (bMI < 16)
            {
                Console.WriteLine($"Your BMI is {bMI}. You must add weight");
            }
            if (16 <= bMI && bMI < 18.5)
            {
                Console.WriteLine($"Your BMI is {bMI}. You should add weight");
            }
            if (18.5 <= bMI && bMI < 25)
            {
                Console.WriteLine($"Your BMI is {bMI}. Maintain your weight");
            }
            if (25 <= bMI && bMI < 30)
            {
                Console.WriteLine($"Your BMI is {bMI}. You should lose some weight.");
            }
            if (30 <= bMI)
            {
                Console.WriteLine($"Your BMI is {bMI}. You should lose some weight.");
            }
            return bMI;
        }
    }


}
