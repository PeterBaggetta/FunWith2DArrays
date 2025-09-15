using System.Drawing;
using Console = Colorful.Console;

namespace FunWith2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string COLOURFUL_SYMBOLS = "1";
            const string COORDINATES = "2";
            const string NUMBER_SEQUENCE = "3";

            // ----- Introduction and user inputs ----- //
            Console.WriteLine("Welcome to having fun with 2D arrays.\nPlease enter in the number of rows and columns you would like!\n");

            int numOfRows, numOfCols;
            while (true)
            {
                // Player chooses number of rows
                Console.WriteLine("Please enter in the number of rows: ");
                if (!int.TryParse(Console.ReadLine(), out numOfRows) || numOfRows <= 0)
                {
                    Console.WriteLine("\n**** Please enter a number that is greater than zero. ****\n");
                    continue;
                }

                // Player chooses number of columns
                Console.WriteLine("Please enter in the number of columns: ");
                if (!int.TryParse(Console.ReadLine(), out numOfCols) || numOfCols <= 0)
                {
                    Console.WriteLine("\n**** Please enter a number that is greater than zero. ****\n");
                    continue;
                }

                // Both inputs are valid
                break;
            }


            string inputChoice;
            while (true)
            {
                // Choose what to fill the grid with
                Console.WriteLine($"Choose what to fill the grid with:\n{COLOURFUL_SYMBOLS} - Colourful Symbols\n{COORDINATES} - Coordinates\n{NUMBER_SEQUENCE} - Number Sequence\nEnter your choice(1 - 3): ");
                inputChoice = Console.ReadLine();

                switch (inputChoice)
                {
                    case COLOURFUL_SYMBOLS:
                    case COORDINATES:
                    case NUMBER_SEQUENCE:
                        break;
                    default:
                        Console.WriteLine("\n**** Please enter a number from 1 to 3. ****\n");
                        continue;
                }
                break;
            }


            Random rand = new Random();

            // Colour Array
            string[] colorNames = { "Black", "White", "Gray", "Red", "Green", "Blue", "Yellow", "Cyan", "Magenta", "Orange", "Purple", "Pink", "Brown" };

            // Symbols array
            string[] symbolsArray = { "!", "@", "#", "$", "%", "^", "&", "*", "~", "-", ";", ":", "<", ">", "?" };

            // Counter for Number Sequence
            int sequenceCounter = 1;

            // Determine the maximum cell width so the grid lines up to each no matter the size
            int maxCellWidth;
            switch (inputChoice)
            {
                case COLOURFUL_SYMBOLS:
                    maxCellWidth = 2;
                    break;

                case COORDINATES:
                    maxCellWidth = $"({numOfRows - 1},{numOfCols - 1})".Length;
                    break;

                case NUMBER_SEQUENCE:
                    maxCellWidth = (numOfRows * numOfCols).ToString().Length;
                    break;

                default:
                    maxCellWidth = 2;
                    break;
            }

            // Create the board and fill it
            for (int r = 0; r < numOfRows; r++)
            {
                for (int c = 0; c < numOfCols; c++)
                {
                    switch (inputChoice)
                    {
                        case COLOURFUL_SYMBOLS:
                            Console.Write($"{symbolsArray[rand.Next(symbolsArray.Length)]}".PadLeft(maxCellWidth).PadRight(maxCellWidth + 1), Color.FromName(colorNames[rand.Next(colorNames.Length)]));
                            break;

                        case COORDINATES:
                            Console.Write($"({r},{c})".PadLeft(maxCellWidth).PadRight(maxCellWidth + 1));
                            break;

                        case NUMBER_SEQUENCE:
                            Console.Write($"{sequenceCounter}".PadLeft(maxCellWidth).PadRight(maxCellWidth + 1));
                            sequenceCounter++;
                            break;

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
