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
			ConsoleKeyInfo userInput = Console.ReadKey();
			return userInput.KeyChar;
        }
	}
}
