using System;
using JoesLib;

namespace Exercise02_5
{
    class Program
    {
        static void Main()
        {
            double OldAge = 50;
            double user_age = jonsole.getUserNumber("Enter your age: ");
            
            if (user_age < OldAge)
            {
                Console.WriteLine("You look older than " + Convert.ToString(user_age) + ".");
            }
            else
            {
                Console.WriteLine("You look younger than " + Convert.ToString(user_age) + ".");
            }
        }
    }
}
