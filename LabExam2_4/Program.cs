using System;

namespace LabExam2_3
{
    class Program
    {
        static void Main()
        {
            int current_multiple = 1;
            int found_multiples = 0;
            int target_multiples = 5;

            while(found_multiples < target_multiples){
                if (current_multiple % 5 == 0){
                    Console.WriteLine("Last number was a multiple of five. Number was: " + Convert.ToString(current_multiple));
                    found_multiples++;
                }
                current_multiple++;
            }
        }
    }
}
