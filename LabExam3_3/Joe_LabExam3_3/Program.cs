using System;
using JoesLib;

namespace Joe_LabExam3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = Convert.ToInt16(jonsole.getUserNumber("Enter a seed: "));

            Console.WriteLine("Number\tSquare\tCube");
            for (int i = seed; i < 10 + seed; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
            }
        }
    }
}
