using System;
using JoesLib;

namespace Joe_LabExam3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = jonsole.getUserNumber("Welcome to the body mass index (BMI) calculator\nEnter your weight in pounds: ");
            double height = jonsole.getUserNumber("Enter your height in inches: ");

            Console.WriteLine("Your BMI is: {0}", (weight * 703) / (height * height));

            Console.WriteLine(@"
BMI VALUES
Underweight: less than 18.5
Normal: between 18.5 and 24.9
Overweight: between 25 and 29.9
Obese: 30 or greater
");
        }
    }
}
