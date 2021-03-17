using System;
using System.Collections.Generic;

namespace WheelOfFortune
{
	/// <summary>
	/// Target Word Contains all the game functionality.
	/// </summary>
	public class TargetWord
	{
		public string Answer = "programming";
		public HashSet<char> ValidChars;
		public HashSet<char> GuessedChars;
		public char[] EmptyTargetWord;
		public int Counter = 0;

		public TargetWord()
        {
			ValidChars = new HashSet<char>(Answer);
			Counter = 0;
			EmptyTargetWord = Answer.ToCharArray();
			GuessedChars = new HashSet<char>();
		}

		/// <returns>TargetWord.Answer</returns>
		public string GenerateTargetWord()
		{
			return Answer;
		}

		/// <summary>
		/// Generates a Dash for every letter of the Target Word
		/// </summary>
		/// <returns>EmptyTargetWord</returns>
		public char[] GenerateDashes()
        {

			for (int i = 0; i < EmptyTargetWord.Length; i++)
			{
				EmptyTargetWord[i] = '-';
			}
			DisplayWord();
			return EmptyTargetWord;
		}

		/// <summary>
		/// Clears console and Displays the Current EmptyTargetWord
		/// </summary>
		public void DisplayWord()
        {
			Console.Clear();
			Console.WriteLine(EmptyTargetWord);
        }

		/// <summary>
		/// Checks if letter given by User is correct
		/// </summary>
		/// <param name="letterToCheck"></param>
		/// <returns>boolean</returns>
		public bool IsCorrect(char letterToCheck)
        {
			if (ValidChars.Contains(letterToCheck) && !GuessedChars.Contains(letterToCheck))
            {
				for(int i = 0; i < Answer.Length; i++)
                {
					if(Answer[i] == letterToCheck)
                    {
						EmptyTargetWord[i] = letterToCheck;
						Counter += 1;
						GuessedChars.Add(letterToCheck);
                    }
                }
				DisplayWord();
				Console.WriteLine($"The letter {letterToCheck} you guessed is correct!");
				return true;
            } 
			DisplayWord();
			return false;
		}
	}
}
