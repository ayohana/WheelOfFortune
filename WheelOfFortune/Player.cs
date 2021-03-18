using System;
using System.Collections.Generic;

namespace WheelOfFortune
{
	/// <summary>
	/// Keeps tracks of player's input.
	/// </summary>
	public class Player
	{
		/// <summary>
		/// Gets user input and returns it 
		/// </summary>
		/// <returns>User Input</returns>
		/// 
		public string Name = "Player";

		public int Points = 0;


		public Player(string name)
        {
			Name = name;
			Points = 0;

        }
		public char ReadLetterInput()
        {
			VisualEffects.CenterConsoleText("Please guess a letter");
			ConsoleKeyInfo userInput = Console.ReadKey(true);
			Console.WriteLine();
			VisualEffects.CenterConsoleText($"You have entered {userInput.KeyChar}");

			return userInput.KeyChar;
        }

		public string ReadWordInput()
        {
			Console.Write("Please guess a word: ");
			string userInput = Console.ReadLine();
			Console.WriteLine();
			VisualEffects.CenterConsoleText($"You have entered {userInput}");
			return userInput;

		}

		public void IncreasePoints(int points)
        {
			Points += points;
        }
	}
}
