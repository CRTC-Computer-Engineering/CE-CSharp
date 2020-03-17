using System;

namespace Exercise02_2
{
    public class console_methods
    {
        public static double getUserNumber(string message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}