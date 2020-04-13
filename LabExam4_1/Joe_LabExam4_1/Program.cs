using System;
using JoesLib;

namespace Joe_LabExam4_1
{
    class Program
    {
        static void Main()
        {
            double weight_in_pounds = jonsole.getUserNumber(@"Welcome to the body mass index (BMI) calculator
Enter your weight in pounds: ");
            double height_in_inches = jonsole.getUserNumber("Enter your height in inches: ");

            Console.WriteLine("Your BMI is: {0}", Convert.ToInt16(weight_in_pounds * 703 / (height_in_inches * height_in_inches)));

            Console.WriteLine(@"
BMI value, according to Department of Health and Human Services/National Institutes of Health
Underweight:        less than 18.5
Normal:             between 18.5 and 24.9
Overweight:         between 25 and 29.9
Obese:              30 or greater");
        }
    }
}
