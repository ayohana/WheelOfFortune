using System;

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
		public char ReadInput()
        {
			Console.WriteLine("Please enter a letter");
			ConsoleKeyInfo userInput = Console.ReadKey(true);
			Console.WriteLine();
			Console.WriteLine($"You have entered {userInput.KeyChar}");
			return userInput.KeyChar;
        }
	}
}
