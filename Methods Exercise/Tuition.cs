using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Error_Handling_Exercise
{
    class Exercise1 
    {
    static void Exer1()
        {
        //Exercise 1: This program calculates tuition over a five year period. Tuition starts at $6000 and increases by %2
            double a = 1;
            Console.WriteLine($"{TuitionCalculator(a)}");
        }

        static double TuitionCalculator(double tuition)
        {
            tuition = 6000;
            double i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine($"for year {i} your tuition is {tuition}");
                tuition += tuition * 0.02;
            }
            return tuition;
        }

    }


}
