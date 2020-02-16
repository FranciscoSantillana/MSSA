using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2A_Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Sum of Numbers
            Console.WriteLine("We will ask you for ten different numbers between 0 and 100 and give you the sum");

            int Count = 1, inputNumber, Sum = 0;              //inputNumber validates if its 0 -100
            while (Count <= 10)
            {
                Console.WriteLine($"Enter number {Count}"); // the count goes up by 1 everytime this instance is repeated 
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber >= 0 && inputNumber <= 100)   // if inputNumber is greater than 0 or less than 100
                {
                    Sum += inputNumber;                       // then add their inputNumber to the Sum.
                    Count++;                                  // increment the Count value.
                }
                else
                    Console.WriteLine("Please insert a value between 0 - 100");// this "else" tells the user that he/she needs to try again.
            }

            Console.WriteLine("Thank you. Now calculating sum..."); // since the count is not less than or equal to 10 then this line proceeds
            Console.WriteLine($"Your sum is {Sum}");
            Console.WriteLine(" Press Enter");
            Console.ReadLine();

            //Part 2: Average Ten Scores
            Console.WriteLine("Welcome to StudentGrader.");
            Console.WriteLine("We will ask you for ten test scores and give you an average for your student.");

            int testAmount = 1, testScore, Sum2 = 0;
            ;
            while (testAmount <= 10)
            {
                Console.WriteLine($"Input grade #{testAmount} for your student (between 0 and 100).");
                testScore = int.Parse(Console.ReadLine());
                if (testScore >= 0 && testScore <= 100)
                {
                    Sum2 += testScore;
                    testAmount++;
                }
            }
            double studentAverage = Sum2 / 10;
            Console.WriteLine("Now calculating the average of your student's tests...");
            Console.WriteLine($"Your student's average is {studentAverage}. And the letter grade is {Grader(studentAverage)}");
            Console.WriteLine(" Press Enter");
            Console.ReadLine();

            //Part 3: Average a Specific Number of Scores
            Console.WriteLine("Welcome to StudentGrader!");
            double Sum3 = 0, examAverage;

            Console.WriteLine("How many exams are you looking to average?");
            int examAmount = int.Parse(Console.ReadLine());  //This is my specific number of scores 

            for (int i = 0; i < examAmount; i++) // this is the first time I ever used a FOR loop. It was SO much cleaner to look at. 
                                                 //Aside from cleanliness, I used a FOR loop to keep track of the exam amount being entered and also to calculate the sum as they were being entered. 
            {
                Console.WriteLine($"Enter exam score {i + 1}");
                Sum3 += int.Parse(Console.ReadLine());
            }
            examAverage = Sum3 / examAmount;
            Console.WriteLine($" The average of your exam scores is {examAverage}. And the letter grade is {Grader(examAverage)}");
            Console.WriteLine(" Press Enter");
            Console.ReadLine();


            //Part 4: Average a Non-Specific Number of Scores
            Console.WriteLine("Welcome to StudentGrader!");
            double sum4 = 0, quizAverage, quizCounter = 0;
            string quizScore;

            Console.WriteLine("Please input quiz score.");

            while ((quizScore = Console.ReadLine()) != "done")
            {
                Console.WriteLine("Please input next quiz score. Otherwise type done");
                sum4 += double.Parse(quizScore);

                quizCounter++;
            }
            quizAverage = sum4 / quizCounter;
            Console.WriteLine($"Your average is {quizAverage}. And the letter grade is {Grader(quizAverage)}");
            Console.WriteLine("Thank you for using StudentGrader!");
            Console.ReadLine();

        }
        //Implementing Letter Grades to Averages   
        // I decided to make a method that can be applied to all of the different averages. I learned that methods can be invoked and reused. 
        //This was enlightening to me because now I dont have to constantly write out a whole function every time I want a letter grade. I can invoke a method instead.
        static string Grader(double Average) 
        {
            string Grade = "The grade cannot be evaluated"; // I put this as my inital value of my Grade variable just in case the loop didn't like the entry.

            if (Average >= 90)
            {
                Grade = "A";
            }
            else if (Average >= 80)
            {
                Grade = "B";
            }
            else if (Average >= 70)
            {
                Grade = "C";
            }
            else if (Average >= 60)
            {
                Grade = "D";
            }
            else  //This was my catch all resolution for any value that didn't apply to the corresponding grades above.
            {
                Grade = "F";
            }

            return Grade; // the return keyword followed by my "Grade" variable is what my method "Grader" will be applying to the averages in my code.
        }

    }
}
