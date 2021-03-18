using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class VisualEffects
    {
        /// <summary>
        /// Changes the color of a message whether or not they guessed correctly
        /// </summary>
        /// <param name="letterToCheck"></param>
        /// <param name="letterIsCorrect"></param>
        public static void ProduceFoundLetterMessageInColor(char letterToCheck, bool letterIsCorrect)
        {
            if (letterIsCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string message = $"The letter {letterToCheck} you guessed is correct!";
                CenterConsoleText(message);
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string message = $"Oh no! You guessed an Incorrect Letter {letterToCheck}";
                CenterConsoleText(message);
            }
            Console.ResetColor();
        }
        /// <summary>
        /// Produce a neat welcome message for the user
        /// </summary>
        public static void StartGameMessage()
        {
            string message = "Welcome to WHEEL OF FORTUNE";
            Console.WriteLine();
            Console.Write(new string(' ', (Console.WindowWidth - message.Length) / 2));

            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Red;
            int count = 0;
            foreach (char letter in "WHEEL OF FORTUNE")
            {
                char whiteSpaceChar = ' ';

                if (letter != whiteSpaceChar) count++;
                Console.ForegroundColor = (ConsoleColor)count;
                Console.Write(letter);
            }
            Console.ResetColor();
            CenterConsoleText("Please Enter the number of Players");
        }
        /// <summary>
        /// Produces a message when the user ends the game
        /// </summary>
        public static void EndGameMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CenterConsoleText("You've reached end of the game!");
            CenterConsoleText("Come back again");

            Console.ReadKey();
        }
        /// <summary>
        /// generates the displayboard in a cool letter block style
        /// </summary>
        /// <param name="EmptyTargetWord"></param>
        public static void AddStyleToTargetWordBoard(char[] EmptyTargetWord)
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write(new string(' ', (Console.WindowWidth - EmptyTargetWord.Length) / 2));
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(EmptyTargetWord);
            Console.ResetColor();
        }
        /// <summary>
        /// Centers text for many of the console output functions.
        /// </summary>
        /// <param name="message"></param>
        public static void CenterConsoleText(string message)
        {
            Console.WriteLine();
            Console.Write(new string(' ', (Console.WindowWidth - message.Length) / 2));
            Console.WriteLine(message);
        }
        /// <summary>
        /// visual spinner.. can be expanded upon later influence prize amount.
        /// </summary>
        public static void ShowSpinner()
        {
        }
    }

}
