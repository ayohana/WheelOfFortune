using System;

namespace WheelOfFortune
{
	/// <summary>
	/// Game starts with one player and one word, keeps track of session and ends when the player wins.
	/// </summary>
	public class Game
	{
		public Player CurrentPlayer;
		public TargetWord word = new TargetWord();

		/// <summary>
		/// This method starts game and keeps track of current game session.
		/// </summary>
		// TO DO: refactor while loop into seperate method
		public void StartGame()
		{
			CurrentPlayer = new Player();

			Console.WriteLine("Welcome to Wheel of Fortune. A game by SpaceCoders.");
			word.GenerateDashes();
			
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
