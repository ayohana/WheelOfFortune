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
		public int CurrentPlayerIndex = 0;
		/// <summary>
		/// This method starts game and keeps track of current game session.
		/// </summary>
		// TO DO: refactor while loop into seperate method
		public void StartGame()
		{
			Console.WriteLine("Hello, Welcome to Wheel Of Fortune");
			Console.WriteLine("Please Enter the number of Players. Max is 3");
			var input= Console.ReadLine();
			// set number of players
			int numberOfPlayers = Convert.ToInt32(input);

			for(int i = 0; i < numberOfPlayers; i++)
            {
				Console.WriteLine("Please enter name of the Player");
				var name = Console.ReadLine();
				name = Convert.ToString(name);
				Players.Add(new Player(name));

			}

			word.GenerateDashes();
			// set current player

			CurrentPlayer = Players[CurrentPlayerIndex];

			while (true) {
				char letter = CurrentPlayer.ReadInput();
                if (!word.IsCorrect(letter))
                {
					Console.WriteLine($"Incorrect Letter {letter}");
					// switch current player;
					SwitchCurrentPlayer();
                } else {

					if(didWin())
                    {
						break;
					}
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
			Console.WriteLine("Come back again");
		}

		public void SwitchCurrentPlayer()
        {
			if (CurrentPlayerIndex + 1 == Players.Count)
			{
				CurrentPlayerIndex = 0;
				CurrentPlayer = Players[CurrentPlayerIndex];
			}
			else
			{
				CurrentPlayer = Players[++CurrentPlayerIndex];
			}
			Console.WriteLine($"Switching Player. Player {CurrentPlayer.Name}, it's your turn");

		}

		public bool didWin()
        {
			if(word.Counter == word.EmptyTargetWord.Length)
            {
				Console.WriteLine($"{CurrentPlayer.Name} won with {CurrentPlayer.Points} points!");
				return true;
            }
			return false;
		}
	}
}
