using System;
using JoesLib;

namespace Joe_Exercise03_1_2
{
    class Program
    {
        private static int Int = Convert.ToInt16(jonsole.getUserInput("Please enter an integer: "));
        private static short Short = Convert.ToInt16(jonsole.getUserInput("Please enter a short integer: "));
        private static long Long = Convert.ToInt16(jonsole.getUserInput("Please enter an long integer: "));
        private static byte Byte = Convert.ToByte(jonsole.getUserInput("Please enter a byte: "));
        private static float Float = float.Parse(jonsole.getUserInput("Please enter a float: "));
        private static double Double = Convert.ToDouble(jonsole.getUserInput("Please enter a double: "));
        private static char Char = Convert.ToChar(jonsole.getUserInput("Please enter a char: "));
        private static bool Bool = Convert.ToBoolean(jonsole.getUserInput("Please enter a bool: "));
        private static string String = Convert.ToString(jonsole.getUserInput("Please enter a string: "));
        private static decimal Decimal = Convert.ToDecimal(jonsole.getUserInput("Please enter a decimal: "));
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                Int is {0}.
                Short is {1}.
                Long is {2}.
                Byte is {3}.
                Float is {4}.
                Double is {5}.
                Char is {6}.
                Bool is {7}.
                String is {8}.
                Decimal is {9}."
                ,Convert.ToString(Int)
                ,Convert.ToString(Short)
                ,Convert.ToString(Long)
                ,Convert.ToString(Byte)
                ,Convert.ToString(Float)
                ,Convert.ToString(Double)
                ,Convert.ToString(Char)
                ,Convert.ToString(Bool)
                ,Convert.ToString(String)
                ,Convert.ToString(Decimal));
        }
    }
}
