using System;
using System.Collections.Generic;

namespace WheelOfFortune
{
	/// <summary>
	/// Game starts with one player and one word, keeps track of session and ends when the player wins.
	/// </summary>
	public class Game
	{
		public Player CurrentPlayer;
		public TargetWord word = new TargetWord();
		public List<Player> Players = new List<Player>();

		/// <summary>
		/// This method starts game and keeps track of current game session.
		/// </summary>
		// TO DO: refactor while loop into seperate method
		public void StartGame()
		{
			Console.WriteLine("Hello, Welcome to Wheel Of Fortune");

			Console.WriteLine("Please Enter the number of Players. Max is 3");

			var input= Console.ReadLine();

			int numberOfPlayers = Convert.ToInt32(input);

			for(int i = 0; i < numberOfPlayers; i++)
            {
				Console.WriteLine("Adding Player");
				Players.Add(new Player());

			}

			Console.WriteLine("Welcome to Wheel of Fortune. A game by SpaceCoders.");
			word.GenerateDashes();
			CurrentPlayer = Players[0];

			while (word.ValidChars.Count > 0) {
				char letter = CurrentPlayer.ReadInput();
                if (!word.IsCorrect(letter))
                {
					Console.WriteLine($"Incorrect Letter {letter}");
                } 
			}
			EndGame();
		}

		/// <summary>
		/// Ends the game.
		/// </summary>
		public void EndGame()
		{
			CurrentPlayer = null;
			Console.WriteLine("You've reached end of the game!");
		}
	}
}
