using System;

namespace JoesLib
{
    public class jonsole
    {
        public static double getUserNumber(string message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void enterToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
