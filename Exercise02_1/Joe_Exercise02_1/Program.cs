using System;

namespace Exercise02_1
{
    class Program
    {
        static void Main()
        {
            double first_num = console_methods.getUserNumber("First number: ");
            double second_num = console_methods.getUserNumber("Second number: ");

            Console.WriteLine(
                Convert.ToString(first_num) + " + " + Convert.ToString(second_num) + " = " + Convert.ToString(first_num + second_num) + "\n" +
                Convert.ToString(first_num) + " - " + Convert.ToString(second_num) + " = " + Convert.ToString(first_num - second_num) + "\n" +
                Convert.ToString(first_num) + " * " + Convert.ToString(second_num) + " = " + Convert.ToString(first_num * second_num) + "\n" +
                Convert.ToString(first_num) + " / " + Convert.ToString(second_num) + " = " + Convert.ToString(first_num / second_num) + "\n" +
                Convert.ToString(first_num) + " % " + Convert.ToString(second_num) + " = " + Convert.ToString(first_num % second_num)
            );
        }
    }
}
