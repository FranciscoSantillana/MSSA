using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1A__Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius:");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"the circumference is {circumference}");

            // Implementation for area here

            int squaredradius = intradius * intradius;
            Console.WriteLine($"the area is {Math.PI * squaredradius}");



            // Part 2
            Console.WriteLine("\npart 2, volume of a hemisphere.");

            // Implementation here
            
            int thirdPowerRadius = intradius * intradius * intradius;
            int FourDiv3 = 4 / 3; 

            Console.WriteLine($"The volume is {(FourDiv3 * Math.PI * thirdPowerRadius)/2}");



            //Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula.");

            // Implementation here

            Console.WriteLine("enter a number value for 'a'");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number value for 'b'");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number value for 'c'");
            double c = int.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"the value of p is {p}");
            Console.ReadLine();
            Console.WriteLine($"the area of the triangle is {area}");
            Console.ReadLine();


            //Part 4

            Console.WriteLine($"your value for 'a' is {a}.");
            Console.WriteLine($"your value for 'b' is {b}.");
            Console.WriteLine($"your value for 'c' is {c}.");
            
            double Negative_x = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
            double Positive_x = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);


             Console.WriteLine($"The positive solution is {Positive_x}");
             Console.WriteLine($"The negative solution is {Negative_x}");
             Console.ReadLine();
        }

    }
}
