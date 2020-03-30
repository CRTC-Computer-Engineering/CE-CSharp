using System;
using System.Collections.Generic;

namespace LabExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            

            int grade;
            while (true)
            {
                try
                {
                    Console.Write("Enter a grade: ");
                    grade = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ResetColor();
                }
            }
            grades.Add(grade);
            bool allInputGood = false;
            do
            {
                
                while (true)
                {
                    try
                    {
                        Console.Write("Enter another grade, or input 'exit' to finish: ");
                        string input = Console.ReadLine();
                        if (input == "exit" || input == "Exit")
                        {
                            allInputGood = true;
                            break;
                        }
                        grade = Convert.ToInt32(input);
                        grades.Add(grade);
                        break;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input");
                        Console.ResetColor();
                    }
                }

            } while (!allInputGood); // end input loop
            Console.WriteLine("\n");


            for (int i = 0; i < grades.Count; i++)
            {
                switch (grades[i])
                {
                    case int n when (n >= 100):
                        Console.WriteLine("Grade {0} ({1}) is an A+", i + 1, grades[i]);
                        break;
                    case int n when (n < 100 && n >= 93):
                        Console.WriteLine("Grade {0} ({1}) is an A", i + 1, grades[i]);
                        break;
                    case int n when (n < 93 && n >= 90):
                        Console.WriteLine("Grade {0} ({1}) is an A-", i + 1, grades[i]);
                        break;
                    case int n when (n < 90 && n >= 87):
                        Console.WriteLine("Grade {0} ({1}) is a B+", i + 1, grades[i]);
                        break;
                    case int n when (n < 87 && n >= 83):
                        Console.WriteLine("Grade {0} ({1}) is a B", i + 1, grades[i]);
                        break;
                    case int n when (n < 83 && n >= 80):
                        Console.WriteLine("Grade {0} ({1}) is a B-", i + 1, grades[i]);
                        break;
                    case int n when (n < 80 && n >= 77):
                        Console.WriteLine("Grade {0} ({1}) is a C+", i + 1, grades[i]);
                        break;
                    case int n when (n < 77 && n >= 73):
                        Console.WriteLine("Grade {0} ({1}) is a C", i + 1, grades[i]);
                        break;
                    case int n when (n < 73 && n >= 70):
                        Console.WriteLine("Grade {0} ({1}) is a C-", i + 1, grades[i]);
                        break;
                    case int n when (n < 70 && n >= 67):
                        Console.WriteLine("Grade {0} ({1}) is a D+", i + 1, grades[i]);
                        break;
                    case int n when (n < 67 && n >= 63):
                        Console.WriteLine("Grade {0} ({1}) is a D", i + 1, grades[i]);
                        break;
                    case int n when (n < 63 && n >= 60):
                        Console.WriteLine("Grade {0} ({1}) is a D+", i + 1, grades[i]);
                        break;
                    case int n when (n <= 59):
                        Console.WriteLine("Grade {0} ({1}) is an F", i + 1, grades[i]);
                        break;
                    default:
                        Console.WriteLine("what");
                        break;
                }
            }
            double total = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                total += grades[i];
            }
            double avg = total / grades.Count;
            Console.WriteLine("Grade Average: {0,5:P2}", avg/100);


        } // end svm
    } 
}
