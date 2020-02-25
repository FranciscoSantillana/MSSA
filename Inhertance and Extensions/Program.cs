using System;


namespace Inheritance_and_Extensions
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance : I could have chosen to instantiate but I just wanted
            //to borrow the methods and not use up memory.

            Console.WriteLine(new Mammal().Iam());
            Console.WriteLine(new Whale().Iam());
            
            //Extension: Pass a string to a string extension method and add
            //a period at the end of it. Also write a method that indents strings.

            string b = "";
            Console.WriteLine($"There should be a period at the " +
                $"end of this sentence{b.AddPeriod()}{b.Indent()}");
            Console.WriteLine("Cookie.");

            //Extension for int
            int a = 450;
            Console.WriteLine(a.Negate());

        }
         
    }
}
