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
		public char[] EmptyTargetWord;

		public TargetWord()
        {
			ValidChars = new HashSet<char>(Answer);

			EmptyTargetWord = Answer.ToCharArray();
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
			VisualEffects.AddStyleToTargetWordBoard(EmptyTargetWord);

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

				VisualEffects.ProduceFoundLetterMessageInColor(letterToCheck, true);

				ValidChars.Remove(letterToCheck);
				return true;
            }
			DisplayWord();
			return false;
		}
	}
}
