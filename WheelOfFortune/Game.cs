using System;

namespace WheelOfFortune
{
	public class Game
	{
		public Player CurrentPlayer;
		public Game()
		{
		
		}

		/// <summary>
		/// This method will instantiate Player as Game's CurrentPlayer attribute
		/// </summary>
		public void StartGame()
		{
			CurrentPlayer = new Player();
			// TODO: move this to the targetword class 
			string targetWord = "programming";
			char[] emptyTargetWord = targetWord.ToCharArray();
			for(int i =0; i < emptyTargetWord.Length; i++) emptyTargetWord[i] = '-'; 

			Console.WriteLine("Welcome to Wheel of Fortune. A game by SpaceCoders.");
			Console.WriteLine(emptyTargetWord);
		}

		public void EndGame()
		{
			CurrentPlayer = null;
			Console.WriteLine("You've reached end of the game!");
		}
	}
}
