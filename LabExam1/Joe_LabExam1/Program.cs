using System;
using JoesLib;

namespace LabExam1
{
    class Program
    {
        static void Main()
        {
            Menu MyMenu = new Menu(); // Construct a new object MyMenu, of the type, Menu
            double userInput = 1; // Create a default user input

            Console.WriteLine("Welcome, you may make a selection below."); // Prompt the user for a selection
            while (userInput != 0) // As long as that selection is not 0 (exit)
            {
                MyMenu.DisplayMenu(); // Show the menu
                userInput = jonsole.getUserNumber(
@"Please make a selection:
    [1] Show my order.
    [2] Add a menu item to my order.
    [3] Remove a menu item from my order.
    [4] Checkout and print my order.
    [0] Quit.
"); // Get the desired selection

                Console.Clear(); // Clear on user input

                int index = 0; // Create a default index value (for selecting menu items added to a list)
                switch (userInput)
                { // A switch using userInput
                    case 1: // In the case the user wants to see their order 
                    MyMenu.DisplayOrder(); // Show their order 
                    break; // Break (return to start)

                    case 2: // In the case they want to add a menu item to their order
                    index = 0; // Reset the index value

                    Console.WriteLine("Cafe Menu."); // Write some filler-text
                    foreach (MenuItem item in MyMenu.menuItems) // For every item in the possible menu items 
                    {
                        Console.WriteLine("[{0}] {1} - {2}", index, item.itemName, item.itemCost); // Display those items with an index number
                        index++; // Increase that index number
                    }
                    int userSelection = Convert.ToInt16(jonsole.getUserNumber("Please select a menu item: ")); // Ask for an index number (an item)
                    int userQty = Convert.ToInt16(jonsole.getUserNumber("Please enter a quantity: ")); // As for a qty
                    MyMenu.addOrderItem(MyMenu.menuItems[userSelection], userQty); // Add that item, and its qty to the order list

                    MyMenu.DisplayOrder(); // Show the order
                    break; // Break (return to start)

                    case 3:
                    index = 0; // Reset the index value

                    Console.WriteLine("Your Order."); // Write some filler-text
                    foreach (MenuItem item in MyMenu.selectedItems) // For every item in user selected items list
                    {
                        Console.WriteLine("[{0}] {1} - {2}", index, item.itemName, item.itemCost); // Display those items with an index number
                        index++; // Increase the index number
                    }
                    userSelection = Convert.ToInt16(jonsole.getUserNumber("Enter an order item to remove items of this type:")); // Ask for an index number (an item)
                    userQty = Convert.ToInt16(jonsole.getUserNumber("Enter a qty:")); // As for a qty
                    MyMenu.removeOrderItem(MyMenu.selectedItems[userSelection], userQty); // Remove that item, and its qty from the order list

                    MyMenu.DisplayOrder(); // Show the edited order
                    break;

                    case 4:
                    MyMenu.DisplayOrder(); // Show the order
                    Environment.Exit(1); // Exit the program with status 1
                    break;


                    default: // Catch other inputs
                    case 0:
                    break;
                }
            }
        }
    }
}
