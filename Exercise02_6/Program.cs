using System;
using JoesLib;

namespace Exercise02_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double user_num = jonsole.getUserNumber("Enter a number: ");

            for (int ay = 0; ay < 2; ay++)
            {
                for (int ayy = 0; ayy < 4; ayy++)
                {
                    Console.Write(Convert.ToString(user_num) + " ");
                }
                Console.Write("\n");
                for (int ayyy = 0; ayyy < 4; ayyy++)
                {
                    Console.Write(Convert.ToString(user_num));
                }
                Console.Write("\n");
            }
        }
    }
}
