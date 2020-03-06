using System;

namespace Exercise02_4
{
    class Program
    {
        static void Main()
        {
            double _x = console_methods.getUserNumber("First Number(x): ");
            double _y = console_methods.getUserNumber("Second Number(y): ");
            double _z = console_methods.getUserNumber("Third Number(z): ");

            Console.WriteLine("Result of specified numbers " + Convert.ToString(_x) + ", " + 
                                                               Convert.ToString(_y) + " and " + 
                                                               Convert.ToString(_z) + ", " +
                                                               "(x + y) * z = " + Convert.ToString((_x + _y) * _z) +
                                                               " and x * y + y * z is " + Convert.ToString(_x * _y + _y * _z));
        }
    }
}
