using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Error_Handling_Exercise
{
    class Exercise2
    {
        static void Exer2()
        {
            //Exercise 2: This program converts the user's shoe size from feet to inches and displays it to him/her.
            Console.WriteLine("Please input feet to be converted to inches");
            double Feet = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your feet input is {Feet}, and  in inches is {FeetToInches(Feet)} inches.");
        }
        static double FeetToInches(double I)
        {
            return I * 12;
        }
    }
}
