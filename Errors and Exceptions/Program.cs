using System;

namespace Errors_and_Exceptions
{
    class Program
    {
        static void Main()
        {



            // Part 1: Circles, Hemispheres, and Triangles

            
                Console.WriteLine("\n Circumference and Area of a Circle.");
                Console.Write("Enter an integer for the radius:");
                int intradius = 0;
                try
                {
                    string strradius = Console.ReadLine();

                    intradius = checked(int.Parse(strradius));
                    if (intradius > 0)
                    {
                        double circumference = 2 * Math.PI * intradius;
                        Console.WriteLine($"the circumference is {circumference}");
                        int squaredradius = intradius * intradius;
                        Console.WriteLine($"the area is {Math.PI * squaredradius}");// Area of Circle    

                        Console.WriteLine("\n Volume of a Hemisphere.");
                        int thirdPowerRadius = intradius * intradius * intradius;
                        int FourDiv3 = 4 / 3;
                        Console.WriteLine($"The volume is {(FourDiv3 * Math.PI * thirdPowerRadius) / 2}");                        
                    }
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine($"{fEx.Message}\n\n");
                    Main();
                }
           
                Console.WriteLine("\n Area of a triangle (Heron's formula.");

                try
                {
                    double a, b, c;
                    do
                    {
                        Console.WriteLine("enter a number value for 'a'");
                        a = checked(double.Parse(Console.ReadLine()));

                    } while (a < 0); // I used this to ensure I get a value greater than 0

                    do
                    {
                        Console.WriteLine("enter a number value for 'b'");
                        b = checked(double.Parse(Console.ReadLine()));

                    } while (b < 0);

                    do
                    {
                        Console.WriteLine("enter a number value for 'c'");
                        c = checked(double.Parse(Console.ReadLine()));

                    } while (c < 0);


                    double p = (a + b + c) / 2;
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));// Implementation here

                    Console.WriteLine($"the value of p is {p}\n");
                    Console.ReadLine();
                    Console.WriteLine($"the area of the triangle is {area}\n Press [enter]\n");
                    Console.ReadLine();

                }
                catch (FormatException fEx)
                {
                    Console.WriteLine($"{fEx.Message}\n\n");
                    Main();
                }
            
        
        //Part 2: Comprehensive Exceptions, Quadratic Formula Error
                       
               try
               {
                int x, y, z;
                do
                 {
                    Console.WriteLine("enter a number value for 'x'");
                    x = checked(int.Parse(Console.ReadLine()));//checking against numeric overflow
                } while (x < 0);
                do
                {
                    Console.WriteLine("enter a number value for 'y'");
                    y = checked(int.Parse(Console.ReadLine()));
                } while (y < 0);
                do
                {
                    Console.WriteLine("enter a number value for 'z'");
                    z = checked(int.Parse(Console.ReadLine()));
                } while (z < 0);
                double NoNegs = y * y - (4 * x * z);// i grabbed a piece of the quadratic equation and called it NoNegs.
                do
                {
                    double Negative_x = (-y - Math.Sqrt(NoNegs)) / (2 * x);
                    double Positive_x = (-y + Math.Sqrt(NoNegs)) / (2 * x);
                    Console.WriteLine($"The positive solution is {Positive_x}");
                    Console.WriteLine($"The negative solution is {Negative_x}");
                    Console.ReadLine();
                } while (NoNegs > 0); // this ensures that the square root is applied to a positive number.
               }  
              catch (Exception ex)
               {
                Console.WriteLine(ex.Message);
                Main();
               }
            finally { Console.WriteLine("This program has finally terminated."); }//finally block
        } 
    }
}
