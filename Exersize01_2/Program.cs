using System;

namespace Exersize01_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a number to be summed.");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide another number to be summed.");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is your result: " + (SimpleMath.SumTwoNumbers(one, two)).ToString());
        }
    }
}
