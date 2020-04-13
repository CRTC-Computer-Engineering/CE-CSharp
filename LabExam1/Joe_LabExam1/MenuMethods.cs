using System;
using JoesLib;
using System.Collections.Generic;

namespace LabExam1
{
    class Menu
    {
        public List<MenuItem> menuItems = new List<MenuItem>(); // Create a new list for all the items available on the menu
        public List<MenuItem> selectedItems = new List<MenuItem>(); // Create a new list of all the items the user has selected

        public Menu() // A constructor for our menu class
        {
            MenuItem PrimeRib =  new MenuItem("Prime Rib      ", 13.99); // Create a new menu item
            menuItems.Add(PrimeRib); // Add it to the list
            MenuItem FriedChicken =  new MenuItem("Fried Chicken  ", 8.49); // Repeat
            menuItems.Add(FriedChicken);
            MenuItem BakedHaddock =  new MenuItem("Baked Haddock  ", 9.99);
            menuItems.Add(BakedHaddock);
            MenuItem Soda =  new MenuItem("Soda           ", 1.99);
            menuItems.Add(Soda);
        }

        public void DisplayMenu() // A method to display the menu
        {
            Console.WriteLine("Menu:");
            foreach (MenuItem item in menuItems) // For every item of type MenuItem in the list menuItems, do the following.
            {
                Console.WriteLine(item.itemName + " - " + Convert.ToString(item.itemCost)); // Print the name and the cost
            }
        }

        public void DisplayOrder() // A method to display your order
        {
            Console.WriteLine("Your order:");
            foreach (MenuItem item in selectedItems) // For every item of type MenuItem in the list menuItems, do the following.
            {
                Console.WriteLine(item.itemName + " - " + Convert.ToString(item.itemCost)); // Print the name and the cost
            }
            Console.WriteLine("Total Cost: $" + Convert.ToString(CalculateBill())); // Show the total
            jonsole.enterToContinue();
        }

        public void addOrderItem(MenuItem item, int qty)
        {
            for(int i = 0; i < qty; i++) // Loop through qty times
            {
                selectedItems.Add(item); // Add that item more than once based on the qty
            }
        }

        public void removeOrderItem(MenuItem item, int qty)
        {
            for(int i = 0; i < qty; i++) // Loop through qty times
            {
                selectedItems.Remove(item); // Add that item more than once based on the qty
            }
        }

        public decimal CalculateBill()
        {
            double sum = 0;
            foreach (MenuItem item in selectedItems) // For every item of type MenuItem in the list selectedItems, do the following.
            {
                sum = sum + item.itemCost; // Add up the costs of all the items in the list
            }
            return Convert.ToDecimal(sum);
        }

        public int ValidateSelection(ref int sel)
        {
            return 0;
        }

        public int GetSelection()
        {
            return 0;
        }

        public int GetQuantity()
        {
            return 0;
        }
    }

    class MenuItem
    { // A class to represent a item on the menu.
        public string itemName; // The name of this item
        public double itemCost; // The cost of this item
        public MenuItem(string _itemName, double _itemCost) 
        { // This constructor takes in the name and the cost, and assigns them to the class.
            itemName = _itemName;
            itemCost = _itemCost;
        }
    }
}