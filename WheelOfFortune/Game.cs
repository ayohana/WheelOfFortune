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
		public SpinWheel PointWheel = new SpinWheel();
		/// <summary>
		/// This method starts game and keeps track of current game session.
		/// </summary>
		// TO DO: refactor while loop into seperate method
		public void StartGame()
		{
			VisualEffects.StartGameMessage();
			var input= Console.ReadLine();
			// set number of players
			int numberOfPlayers = Convert.ToInt32(input);

			for(int i = 0; i < numberOfPlayers; i++)
            {
				VisualEffects.CenterConsoleText("Please enter name of the Player");
				var name = Console.ReadLine();
				name = Convert.ToString(name);
				Players.Add(new Player(name));

			}

			VisualEffects.StartGameMessage();
			word.GenerateDashes();
			// set current player

			CurrentPlayer = Players[CurrentPlayerIndex];


			while (true) {

				VisualEffects.CenterConsoleText("Press 1 to guess entire word");
				VisualEffects.CenterConsoleText("Press 2 to guess the letter");

				char choice = Console.ReadKey(true).KeyChar;

				if (choice == '1')
                {
					string guessedWord = CurrentPlayer.ReadWordInput();
                    if (word.IsWordCorrect(guessedWord))
                    {
						word.DisplayWord();
						VisualEffects.CenterConsoleText($"The word {guessedWord} is Correct!");
						int points = PointWheel.SpinWheelForCorrectWord();
						CurrentPlayer.IncreasePoints(points);
						EndGame();
						break;
                    } else
                    {
						word.DisplayWord();
						VisualEffects.CenterConsoleText($"The word {guessedWord} is Incorrect!");
                    }

                } else {

					char letter = CurrentPlayer.ReadLetterInput();
					if (!word.IsCorrect(letter))
					{
						VisualEffects.ProduceFoundLetterMessageInColor(letter, false);
						// switch current player;
						SwitchCurrentPlayer();
					}
					else
					{
						int points = PointWheel.SpinWheelForCorrectGuessedLetter();
						CurrentPlayer.IncreasePoints(points);
						if (didWin())
						{
							EndGame();
							break;
						}
					}
				}

			}
		}

		/// <summary>
		/// Ends the game.
		/// </summary>
		public void EndGame()
		{
			// TODO: edit message for winner
			VisualEffects.CenterConsoleText($"{CurrentPlayer.Name} won with {CurrentPlayer.Points} points!");
			VisualEffects.EndGameMessage();
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
			VisualEffects.CenterConsoleText($"Switching Player. Player {CurrentPlayer.Name}, it's your turn");

		}

		public bool didWin()
        {
			return word.Counter == word.EmptyTargetWord.Length;
		}
	}
}
