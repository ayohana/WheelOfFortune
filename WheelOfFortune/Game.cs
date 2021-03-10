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
		}
	}
}
