using System;

namespace LabExam2_6
{
    class Program
    {
        static void Main()
        {
            int outer_loop = 1;
            int inner_loop = 0;

            while (outer_loop < 3){
                Console.WriteLine("Outer Loop has run, current run: " + Convert.ToString(outer_loop));
                while (inner_loop < 10){
                    Console.WriteLine("Inner Loop has run, current run: " + Convert.ToString(inner_loop));
                    if (inner_loop == 3){
                        Console.WriteLine("I decided to just break now.");
                        break;
                    }
                    inner_loop++;
                }
                outer_loop++;
            }
        }
    }
}
