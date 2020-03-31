using System;
using System.Linq;
using JoesLib;

namespace Joe_LabExam3_2
{
    class Program
    {
        static void Main()
        {
            int firstNum = Convert.ToInt16(jonsole.getUserNumber("Enter first integer: "));
            int secondNum = Convert.ToInt16(jonsole.getUserNumber("Enter second integer: "));
            int thirdNum = Convert.ToInt16(jonsole.getUserNumber("Enter third integer: "));

            int[] nums = {firstNum, secondNum, thirdNum};

            Console.Write("For the numbers ");
            foreach (int number in nums)
            {
                System.Console.Write("{0}, ", number);
            }

            Console.WriteLine(@"
Largest is {0}
Smallest is {1}
Sum is {2}
Product is {3}
Average is {4}
"
,nums.Max()
,nums.Min()
,nums.Sum()
,nums.Aggregate(1, (acc, val) => acc * val)
,Convert.ToInt16(nums.Average()));
        }
    }
}
