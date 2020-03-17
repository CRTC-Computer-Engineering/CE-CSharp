using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam01
{
    class Program
    {
        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  Cafe Diem Menu");
            Console.WriteLine("         1  Prime Rib     - $13.99 per plate");
            Console.WriteLine("         2  Fried Chicken - $8.49 per plate");
            Console.WriteLine("         3  Baked Haddock - $9.99 per plate");
            Console.WriteLine("         4  Soda          - $1.99 each");
            Console.WriteLine("         5  Quit");
            Console.Write("  Please make a selection: ");
        }
        private static void GetSelection()
        {
            int sel = Convert.ToInt32(Console.ReadLine());
        }
        private static void ValidateSelection(ref int sel)
        { 
            switch (sel)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("  Sorry, there seems to have been an error. Please make another selection.");
                    Console.Write("  Please make a selection: ");
                    GetSelection();
                    break;
            }
        }
        static void Main(string[] args)
        {
            DisplayMenu();
            GetSelection();
            ValidateSelection();
        }
    }
}