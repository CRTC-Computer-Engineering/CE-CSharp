using System;

namespace Exercise02_3
{
    class Program
    {
        static void Main()
        {
            double first_num = console_methods.getUserNumber("First Number: ");
            double second_num = console_methods.getUserNumber("Second Number: ");
            double third_num = console_methods.getUserNumber("Third Number: ");
            double fourth_num = console_methods.getUserNumber("Fourth Number: ");

            Console.WriteLine("The average of " + Convert.ToString(first_num) + ", " + 
                                                  Convert.ToString(second_num) + ", " + 
                                                  Convert.ToString(third_num) + " and " +
                                                  Convert.ToString(fourth_num) + " is: " + 
                                                  Convert.ToString((first_num + second_num + third_num + fourth_num) / 4));
        }
    }
}
