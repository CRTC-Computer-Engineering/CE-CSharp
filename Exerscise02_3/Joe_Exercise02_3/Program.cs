using System;
using JoesLib;

namespace Exercise02_3
{
    class Program
    {
        static void Main()
        {
            double first_num = jonsole.getUserNumber("First Number: ");
            double second_num = jonsole.getUserNumber("Second Number: ");
            double third_num = jonsole.getUserNumber("Third Number: ");
            double fourth_num = jonsole.getUserNumber("Fourth Number: ");

            Console.WriteLine("The average of " + Convert.ToString(first_num) + ", " + 
                                                  Convert.ToString(second_num) + ", " + 
                                                  Convert.ToString(third_num) + " and " +
                                                  Convert.ToString(fourth_num) + " is: " + 
                                                  Convert.ToString((first_num + second_num + third_num + fourth_num) / 4));
        }
    }
}
