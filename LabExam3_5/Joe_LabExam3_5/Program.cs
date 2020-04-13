using System;
using JoesLib;

namespace Joe_LabExam3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = Convert.ToInt16(jonsole.getUserNumber("Input number of desired rows: "));
            Console.WriteLine(pyramid(rows));
        }

        private static String pyramid(int targetRows)
        {
            int i, j = 0;
            string output = "";

            for (i = 0; i < targetRows; i++)
            {
                for (j = 1; j <= targetRows - i; j++)
                output = output + "\t";
                for (j = 1; j <= 2 * i - 1; j++)
                    output = output + "*\t";
                output = output + "\n";
            }
            return output;
        }
    }
}
