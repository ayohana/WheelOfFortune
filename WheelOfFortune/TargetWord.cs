using System;

namespace WheelOfFortune
{
	public class TargetWord
	{
		public string Answer = "programming";


		public string GenerateTargetWord()
		{
			return Answer;
		}

		public char[] Display()
        {
			string targetWord = GenerateTargetWord();
			char[] emptyTargetWord = targetWord.ToCharArray();
			for (int i = 0; i < emptyTargetWord.Length; i++)
			{
				emptyTargetWord[i] = '-';
			}
			return emptyTargetWord;
		}
	}
}
