using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam01
{
    class Program
    {
        private static int sel = 0;
        private static int item = 0;
        private static void DisplayMenu()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  Cafe Diem Menu");
                Console.WriteLine("         1  Prime Rib     - $13.99 per plate");
                Console.WriteLine("         2  Fried Chicken - $8.49 per plate");
                Console.WriteLine("         3  Baked Haddock - $9.99 per plate");
                Console.WriteLine("         4  Soda          - $1.99 each");
                Console.WriteLine("         5  Quit");
                Console.Write("  Please make a selection: ");
                GetSelection();
                if (sel == 5)
                {
                    break;
                }
                ValidateSelection(ref sel);
                if (item == 5)
                {
                    break;
                }
                if (sel == 5)
                {
                    break;
                }
                Console.WriteLine(item);
                Console.WriteLine(sel);
                //GetQuantity();

            } while (sel != 5);
        }
        private static int GetSelection()
        {
            int sel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sel);
            return sel;
        }
        private static int ValidateSelection(ref int sel)

        {
            do
            {
                switch (sel)
                {
                    case 1:
                        item = 1;
                        Console.WriteLine(sel);
                        break;
                    case 2:
                        item = 2;
                        Console.WriteLine(sel);
                        break;
                    case 3:
                        item = 3;
                        Console.WriteLine(sel);
                        break;
                    case 4:
                        item = 4;
                        break;
                    case 5:
                        item = 5;
                        Console.WriteLine(sel);
                        break;
                    default:
                        Console.WriteLine("  Sorry, there seems to have been an error. Please make another selection.");
                        Console.Write("  Please make a selection: ");
                        GetSelection();
                        Console.WriteLine(sel);
                        break;
                }
            } while (item != 1 || sel != 2 || sel != 3 || sel != 4 || sel != 5);
            return item;
        }
        /*
        private static int GetQuantity()
        {
            Console.Write;
        }
        */
        static void Main(string[] args)
        {
            DisplayMenu();

        }
    }
}
