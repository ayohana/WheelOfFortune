using System;
using System.Collections.Generic;

namespace WheelOfFortune
{
	/// <summary>
	/// Target Word Contains all the game functionality.
	/// </summary>
	public class TargetWord
	{
		public string Answer;
		public HashSet<char> ValidChars;
		public char[] EmptyTargetWord;
		public List<string> TargetWordsList = new List<string>()
		{
			"programming",
			"spacecoders",
			"marlon",
			"graduation",
			"rosemary"
		};

		public TargetWord()
        {
			Answer = GenerateTargetWord();
			ValidChars = new HashSet<char>(Answer);
			EmptyTargetWord = Answer.ToCharArray();
		}

		/// <summary>
		/// Returns a random word from TargetWordsList
		/// </summary>
		public string GenerateTargetWord()
		{
			Random random = new Random();
			int randomIndex = random.Next(0, TargetWordsList.Count);
			return TargetWordsList[randomIndex];
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
			if (ValidChars.Contains(letterToCheck))
            {
				for(int i = 0; i < Answer.Length; i++)
                {
					if(Answer[i] == letterToCheck)
                    {
						EmptyTargetWord[i] = letterToCheck;
                    }
                }
				DisplayWord();
				Console.WriteLine($"The letter {letterToCheck} you guessed is correct!");
				ValidChars.Remove(letterToCheck);
				return true;
            } 
			DisplayWord();
			return false;
		}

		public bool IsWordCorrect(string wordToCheck)
        {
			return Answer.Equals(wordToCheck);
        }
	}
}
