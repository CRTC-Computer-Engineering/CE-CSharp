using System;
using JoesLib;

namespace Joe_LabExam3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = Convert.ToInt16(jonsole.getUserNumber("Enter first integer: "));
            int secondNum = Convert.ToInt16(jonsole.getUserNumber("Enter second integer: "));

            if (firstNum == secondNum){Console.WriteLine("{0} == {1}", firstNum, secondNum);}
            if (firstNum != secondNum){Console.WriteLine("{0} != {1}", firstNum, secondNum);}
            if (firstNum < secondNum){Console.WriteLine("{0} < {1}", firstNum, secondNum);}
            if (firstNum > secondNum){Console.WriteLine("{0} > {1}", firstNum, secondNum);}
            if (firstNum <= secondNum){Console.WriteLine("{0} <= {1}", firstNum, secondNum);}
            if (firstNum >= secondNum){Console.WriteLine("{0} >= {1}", firstNum, secondNum);}
        }
    }
}
