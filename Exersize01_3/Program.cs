using System;

namespace Exersize01_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Provide a numerator..");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Provide a denominator..");
            double denominator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Here is your result: " + (SimpleMath.DivideTwoNumbers(numerator, denominator)).ToString());
        }
    }
}
