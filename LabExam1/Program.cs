using System;
using JoesLib;

namespace LabExam1
{
    class Program
    {
        static void Main()
        {
            Menu MyMenu = new Menu(); // Construct a new menu
            double userInput = 1;

            Console.WriteLine("Welcome, you may make a selection below.");
            while (userInput != 0)
            {
                MyMenu.DisplayMenu();
                userInput = jonsole.getUserNumber(
@"Enter selection:
[1] Show my order.
[2] Add a menu item to your order.
[3] Remove a menu item from your order.
[4] Checkout and print your order.
[0] Quit.");

                int index = 0;
                switch (userInput)
                {
                    case 1:
                    MyMenu.DisplayOrder();
                    break;

                    case 2:
                    index = 0;

                    Console.WriteLine("Displaying Menu.");
                    foreach (MenuItem item in MyMenu.menuItems) // For every item in the possible menu items
                    {
                        Console.WriteLine("[{0}] {1} - {2}", index, item.itemName, item.itemCost); // Display those items with an index number
                        index++;
                    }
                    int userSelection = Convert.ToInt16(jonsole.getUserNumber("Enter a menu item to add to your order:")); // Ask for an index number (an item)
                    int userQty = Convert.ToInt16(jonsole.getUserNumber("Enter a qty:")); // As for a qty
                    MyMenu.addOrderItem(MyMenu.menuItems[userSelection], userQty); // Add that item, and its qty to the order list

                    MyMenu.DisplayOrder();
                    break;

                    case 3:
                    index = 0; // Reset

                    Console.WriteLine("Displaying Your Order.");
                    foreach (MenuItem item in MyMenu.selectedItems) // For every item in the possible menu items
                    {
                        Console.WriteLine("[{0}] {1} - {2}", index, item.itemName, item.itemCost); // Display those items with an index number
                        index++;
                    }
                    userSelection = Convert.ToInt16(jonsole.getUserNumber("Enter an order item to remove items of this type:")); // Ask for an index number (an item)
                    userQty = Convert.ToInt16(jonsole.getUserNumber("Enter a qty:")); // As for a qty
                    MyMenu.removeOrderItem(MyMenu.selectedItems[userSelection], userQty); // Add that item, and its qty to the order list

                    MyMenu.DisplayOrder();
                    break;

                    case 4:
                    MyMenu.DisplayOrder();
                    Environment.Exit(1);
                    break;


                    default: // Catch other inputs
                    case 0:
                    break;
                }
            }
        }
    }
}
