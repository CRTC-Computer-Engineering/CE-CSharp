﻿using System;

namespace Exercise01_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Executing the following instructions:");
            Console.WriteLine("-1 + 4 * 6 = " + Convert.ToString(-1 + 4 * 6));
            Console.WriteLine("(35 + 5) % 7 = " + Convert.ToString((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = " + Convert.ToString(14 + -4 * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + Convert.ToString(2 + 15 / 6 * 1 - 7 % 2));
        }
    }
}