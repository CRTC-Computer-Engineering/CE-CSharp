using System;
using System.Linq;

namespace LabExam2_5
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int end = 10;
            int[] ignored = {4, 7, 9};

            while (i < end)
            {
                i++;
                if (ignored.Contains(i))
                {
                    Console.WriteLine("Encountered number " + Convert.ToString(i) + " but number is ignored. Skipping number.");
                    continue;
                }
                Console.WriteLine("Counting to " + Convert.ToString(end) + ", Current number is: " + Convert.ToString(i));
            }
        }
    }
}
