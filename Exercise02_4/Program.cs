using System;
using JoesLib;

namespace Exercise02_4
{
    class Program
    {
        static void Main()
        {
            double _x = jonsole.getUserNumber("First Number(x): ");
            double _y = jonsole.getUserNumber("Second Number(y): ");
            double _z = jonsole.getUserNumber("Third Number(z): ");

            Console.WriteLine("Result of specified numbers " + Convert.ToString(_x) + ", " + 
                                                               Convert.ToString(_y) + " and " + 
                                                               Convert.ToString(_z) + ", " +
                                                               "(x + y) * z = " + Convert.ToString((_x + _y) * _z) +
                                                               " and x * y + y * z is " + Convert.ToString(_x * _y + _y * _z));
        }
    }
}
