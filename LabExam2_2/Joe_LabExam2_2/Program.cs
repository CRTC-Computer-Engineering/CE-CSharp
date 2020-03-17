using System;

namespace LabExam2_1
{
    class Program
    {
        static void Main() 
        {
            int i = 1;
            int end = 5;

            do
            {
                Console.WriteLine("A Line. (" + Convert.ToString(i) + "/" + Convert.ToString(end) + ")");
                i++;
            } while (i <= end);
        }
    }
}
