using System;

namespace Exercise01_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Provide a first numah");
            double numah_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Provide anutah numah");
            double numah_two = Convert.ToDouble(Console.ReadLine());

            double _numah = numah_one;
            numah_one = numah_two;
            numah_two = _numah;

            Console.WriteLine("Swapped nummas\nNumah one: " + (numah_one).ToString() + ", Numah two: " + (numah_two).ToString());
        }
    }
}
