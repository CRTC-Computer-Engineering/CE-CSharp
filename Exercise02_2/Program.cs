using System;

namespace Exercise02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double _num = console_methods.getUserNumber("Input a number: ");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(Convert.ToString(_num) + " * " + Convert.ToString(i) + " = " + Convert.ToString(_num * i));
            }
        }
    }
}
