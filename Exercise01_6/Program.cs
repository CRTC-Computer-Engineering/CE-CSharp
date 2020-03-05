using System;

namespace Exercise01_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Provide one of three nummahs to multiply.");
            double nummah_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Provide two of three nummahs to multiply.");
            double nummah_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Provide three of three nummahs to multiply.");
            double nummah_three = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Multiplying da nummahs");
            Console.WriteLine("Result: " + Convert.ToString(nummah_one * nummah_two * nummah_three));
        }
    }
}
