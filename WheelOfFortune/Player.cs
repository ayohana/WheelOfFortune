using System;

namespace WheelOfFortune
{
	public class Player
	{
		public Player()
		{

		}
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
