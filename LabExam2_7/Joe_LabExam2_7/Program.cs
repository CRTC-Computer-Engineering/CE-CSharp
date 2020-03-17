using System;
using System.Collections.Generic;
using System.Linq;
using JoesLib;

namespace LabExam2_7
{
    class Program
    {
        static void Main()
        {
            List<double> grades = new List<double>();

            while (true)
            {
                double current_input = jonsole.getUserNumber("Input a grade, enter -1 to end.");
                
                if (current_input == -1)
                {
                    break;
                }
                grades.Add(current_input);
            }

            Console.WriteLine("You averaged a " + Convert.ToString(grades.Average()));    // Need to remve these lines later, very important
            Console.WriteLine("Letter grade: "+ jonvert.convertGradeToLetter(grades.Average())); // Debug this mesage  later please

            string letter_grade = jonvert.convertGradeToLetter(grades.Average());

            switch (letter_grade)
            {   // Switch statement so we pass the class
                case "A+":
                break;
                case "A":
                break;
                case "A-":
                break;
                case "B+":
                break;
                case "B":
                break;
                case "B-":
                break;
                case "C+":
                break;
                case "C":
                break;
                case "C-":
                break;
                case "D+":
                break;
                case "D":
                break;
                case "D-":
                break;
                case "F":
                break;
            }
        }
    }
}
