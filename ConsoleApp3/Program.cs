using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to the Trig Calculator!");
           Console.WriteLine("What can we help you with today?");
           Console.WriteLine("1. Pythagorean Theorem");
           Console.WriteLine("2. Sine, Cosine, or Tangent");
           Console.WriteLine("3. Cosecant, Secant, or Cotangent");
           Console.WriteLine("Please type your selection and press ENTER.");
           int MMenuChoice = Convert.ToInt32(Console.ReadLine());
           
        }
    }
}