using System;

namespace RickUtils
{
    public class ConsoleUtils
    {
        /// <summary>
        /// Print the given text in the provided color and reset the foreground color to gray afterwards.
        /// </summary>
        /// <param name="toPrint">The text to print to the console</param>
        /// <param name="color">The color that the text will be</param>
        public static void PrinterHelper(string toPrint, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(toPrint);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Print the given text to the console in a DarkRed color.
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintRed(string toPrint)
        {
            PrinterHelper(toPrint, ConsoleColor.Red);
        }

        /// <summary>
        /// Print the given text to the console in a Cyan color.
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintCyan(string toPrint)
        {
            PrinterHelper(toPrint, ConsoleColor.Cyan);
        }

        /// <summary>
        /// Print the given text to the console in a DarkGreen color
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintGreen(string toPrint)
        {
            PrinterHelper(toPrint, ConsoleColor.DarkGreen);
        }

        /// <summary>
        /// Print the given text to the console in a DarkYellow color
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintYellow(string toPrint)
        {
            PrinterHelper(toPrint, ConsoleColor.DarkYellow);
        }

        /// <summary>
        /// Print text to the console in a green color. Alias to PrintGreen
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintSuccessColor(string toPrint) => PrintGreen(toPrint);
        
        /// <summary>
        /// Print text to the console in a yellow color. Alias to PrintYellow
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintWarningColor(string toPrint) => PrintYellow(toPrint);

        /// <summary>
        /// Print text to the console in a red color. Alias to PrintRed
        /// </summary>
        /// <param name="toPrint">Text to be printed</param>
        public static void PrintDangerColor(string toPrint) => PrintRed(toPrint);
    }
}
