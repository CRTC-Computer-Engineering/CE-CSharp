using System;

namespace JoesLib
{
    public class jonsole
    {
        public static double getUserNumber(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static string getUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static void enterToContinue()
        {
            Console.Write("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
