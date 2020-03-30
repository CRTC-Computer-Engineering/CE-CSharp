using System;
using JoesLib;

namespace Joe_Exercise03_01
{
    class Program
    {
        private static int Int = 10;
        private static short Short = 5;
        private static long Long = 2000;
        private static byte Byte = 8;
        private static float Float = 3.14F;
        private static double Double = 3.1415927;
        private static char Char = 'a';
        private static bool Bool = true;
        private static string String = "hello";
        private static decimal Decimal = 3.14159265358979M;
        static void Main(string[] args)
        {
            Console.WriteLine(
                @"Int is {0}.
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
