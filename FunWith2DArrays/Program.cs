using System;
using System.Drawing;
using Console = Colorful.Console;

namespace FunWith2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to having fun with 2D arrays.\nPlease enter in the number of rows and columns you would like!\n");

            int numOfRows, numOfCols;
            while (true)
            {
                // Player chooses number of rows
                Console.WriteLine("Please enter in the number of rows: ");
                numOfRows = Convert.ToInt32(Console.ReadLine());

                // Player chooses number of columns
                Console.WriteLine("Please enter in the number of columns: ");
                numOfCols = Convert.ToInt32(Console.ReadLine());

                // Input Validation
                if (numOfRows > 0 && numOfCols > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n**** Please enter a number that is greater than zero. ****\n");
                }
            }

            // Colour Array
            string[] colorNames = { "Black", "White", "Gray", "Red", "Green", "Blue", "Yellow", "Cyan", "Magenta", "Orange", "Purple", "Pink", "Brown"};

            // Choose what to fill the grid with
            Console.WriteLine("Choose what to fill the grid with:\n1 - Colourful Symbols\n2 - Coordinates\n3 - Number Sequence\nEnter your choice(1 - 3): ");
            string inputChoice = Console.ReadLine();


            // Symbols array
            Random rand = new Random();
            string[] symbolsArray = { "!", "@", "#", "$", "%", "^", "&", "*", "~", "-", ";", ":", "<", ">", "?" };

            // Counter for Number Sequence
            int sequenceCounter = 1;

            // Determine the maximum cell width so the grid lines up to each no matter the size
            int maxCellWidth = 0;

            if (inputChoice == "1")
            {
                maxCellWidth = 2;
            }
            if (inputChoice == "2")
            {
                maxCellWidth = $"({numOfRows - 1},{numOfCols - 1})".Length;
            }
            if (inputChoice == "3")
            {
                maxCellWidth = (numOfRows * numOfCols).ToString().Length;
            }

            // Create the board and fill it
            for (int r = 0; r < numOfRows; r++)
            {
                for (int c = 0; c < numOfCols; c++)
                {
                    // Random Symbols
                    if (inputChoice == "1")
                    {
                        Console.Write($" {symbolsArray[rand.Next(symbolsArray.Length)]} ", Color.FromName(colorNames[rand.Next(colorNames.Length)]));
                    }

                    // Coordinates
                    if (inputChoice == "2")
                    {
                        Console.Write($"({r},{c})".PadLeft(maxCellWidth).PadRight(maxCellWidth + 1));
                    }

                    // Number sequence
                    if (inputChoice == "3")
                    {
                        Console.Write($"{sequenceCounter}".PadLeft(maxCellWidth).PadRight(maxCellWidth + 1));
                        sequenceCounter++;
                    }


                    // Column separation
                    if (c < numOfCols - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();

                // Row separation
                if (r < numOfRows - 1)
                {
                    for (int c = 0; c < numOfCols; c++)
                    {
                        Console.Write(new string('-', maxCellWidth + 1));
                        if (c < numOfCols - 1)
                        {
                            Console.Write("+");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
