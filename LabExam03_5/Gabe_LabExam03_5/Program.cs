using System;
using System.Collections.Generic;

namespace LabExam03
{
    class Program
    {
        static readonly List<char> acceptedSymbols = new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')'}; // for use by the symbol tree
        //List<T> is basically like an array but with all the things an array wishes it had, same fundimental functionality
        static void Main(string[] args)
        {
            MakeNumPyramid(); // count from 1 to 10 in a pyramid

            Console.WriteLine(); // output spacing

            string color;
            while (true) // Error loop for text color input
            {
                Console.Write("\nEnter a text color (without spaces, not case sensitive): ");

                while (true) // trycatch loop
                {
                    try
                    {

                        color = Console.ReadLine().ToLower(); // take input
                        color = Convert.ToString(char.ToUpper(Convert.ToChar(color[0])) + color.Substring(1)); // god i hate this line

                        // First, it gets the character at index 0 of the input
                        // Next, it converts that length 1 string to a char to use the char.ToUpper method
                        // Next it converts that char back to a length 1 string
                        // Finally, it adds the now uppercase first character to the rest of the string

                        // i need a 
                        break;
                    }
                    catch (IndexOutOfRangeException) // catch if string empty (index 0 of range null)
                    {
                        Console.WriteLine("Error, string empty");
                        Console.Write("\nEnter a text color (without spaces): ");

                    }
                } // end trycatch

                switch (color)  // edge cases for multi captial colors
                {
                    case "Darkblue":
                        color = "DarkBlue";
                        break;
                    case "Darkcyan":
                        color = "DarkCyan";
                        break;
                    case "Darkgray":
                        color = "DarkGray";
                        break;
                    case "Darkgreen":
                        color = "DarkGreen";
                        break;
                    case "Darkmagenta":
                        color = "DarkMagenta";
                        break;
                    case "Darkred":
                        color = "DarkRed";
                        break;
                    case "Darkyellow":
                        color = "DarkYellow";
                        break;
                    default:  // if normal color, continue
                        break;
                } // end edge cases

                if (Enum.IsDefined(typeof(ConsoleColor), color)) // if the user's color is valid, break out of the loop
                {
                    break;
                } 
                else // not a valid color
                {
                    Console.WriteLine("Invalid color, try again");
                    continue;
                }

            } // end color collection


            setColor(color); // massive switch to convert from a string to an Enum
            MakeNumPyramid(); // actually make the pyramid
            Console.ResetColor(); // fix color for next prompt

            char chr; // input for the final tree
            while (true) // trycatch loop
            {
                try
                {
                    Console.Write("\nWrite a symbol to use to make the tree: ");
                    chr = Convert.ToChar(Console.ReadLine()); 

                    if (acceptedSymbols.Contains(chr)) // if our imput matches our big list of 10 accepted special symbols
                    {
                        break; // continue with the pyramid
                    }
                    else // not on the list
                    {
                        Console.WriteLine("Invalid Symbol, please use one of the symbols above your numbers (ex !, @, #, etc)");
                    }
                    
                }
                catch (Exception ex) // First attempt at a multi-exception catch
                {
                    if (ex is FormatException || ex is ArgumentNullException) // If the input is not a char  ||  there is no input/blank line
                    {
                        Console.WriteLine("Expecting a single symbol, try again");
                        continue; // restart the trycatch for new input
                    } 

                    else
                    {
                        throw ex; // throw anything thats not what we're expecting
                    }
                }

            }
            setColor(color); // set the color before outputting
            MakeCharPyramid(chr); // new pyramid with the symbol, and a parameter, +bonus :)

            Console.ResetColor(); // fix colors before ending the program
            Console.ReadLine(); // pause before instant quit
        } // end svm

        static void MakeCharPyramid(char chr) // Symbol pyramid, make a pyramid out of any char
        {
            int row = 0, pos = 1; // set up the counters for the current row and which column we're writing to

            for (int i = 1; i < 11; i++) // repeat 10 times starting at 1
            {
                if (row < pos) // if our cursor is further than we want it to be
                {
                    if (row != 0) // no new line on 0
                    {
                        Console.WriteLine(); // move on to the next row of the pyramid
                    }

                    for (int j = 0; j < 4 - row; j++) // Loop for the number of spaces before the first pyramid row
                    {
                        Console.Write(" "); // 1 blank space
                    }
                    row++; // add one to the row counter
                    pos = 1; // reset our position back to 1
                } // end pyramid row reset

                Console.Write(chr + " "); // write our special symbol and a space
                pos++; // add to our position counter so we don't go over
            } // end x10 loop

        } // end char pyramid
        static void MakeNumPyramid()
        {
            int row = 0, pos = 1;// set up the counters for the current row and which column we're writing to
                                // starts at 0 to instantly trigger the spacing before we start writing
                                // could possibly be refactored to make the spaces first, then the next number, then the newline
            for (int i = 1; i < 11; i++) // loop 10 times starting at 1
            {
                if (row < pos) // if our cursor is further than we want it to be
                {
                    if (row != 0) // first loop ignore
                    {
                        Console.WriteLine(); // move to the next pyramid row
                    }
                    for (int j = 0; j < 4 - row; j++) // pre-number spacing
                    {
                        Console.Write(" "); // blank space
                    }
                    row++; // add one to our row
                    pos = 1; // reset our "cursor"
                } // end reset

                Console.Write(i + " "); // write our number and a space
                pos++; // add one to our position counter
            } // end x10 loop
        } // end num pyramid

        static void setColor(string color) // man I wish there was a way to just
                                      // Concole.ForgroundColor = ConsoleColor.color;
        {
            switch (color) // pulls the param from the method
            {
                case "Black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "DarkBlue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "DarkGreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "DarkCyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "DarkRed":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "DarkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "DarkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "DarkGray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default: // there should be no way for this to trigger... but in case it does
                    Console.WriteLine("stray photon"); // hey it could happen
                    Environment.Exit(69); // exit the program with an error code of 69
                    break; // unreachable because we just quit but VS likes it anyway
            } // end input conversion switch
        } // end setcolor method

    } // end program
} // eof
