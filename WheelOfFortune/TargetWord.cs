using System;
using System.Collections.Generic;

namespace WheelOfFortune
{
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

		public string GenerateTargetWord()
		{
			return Answer;
		}

		public char[] Display()
        {

			for (int i = 0; i < EmptyTargetWord.Length; i++)
			{
				EmptyTargetWord[i] = '-';
			}
			Console.WriteLine(EmptyTargetWord);
			return EmptyTargetWord;
		}

		public bool IsCorrect(char letterToCheck)
        {
			if (ValidChars.Contains(letterToCheck))
            {
				// if correct show letter on screen 
				for(int i = 0; i < Answer.Length; i++)
                {
					if(Answer[i] == letterToCheck)
                    {
						EmptyTargetWord[i] = letterToCheck;
                    }
                }
				Console.Clear();
				Console.WriteLine(EmptyTargetWord);

				ValidChars.Remove(letterToCheck);
				return true;
            }
			Console.Clear();
			return false;
				 
		}
	}
}
