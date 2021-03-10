using System;

namespace WheelOfFortune
{
	public class TargetWord
	{
		public string Answer = "programming";

		public TargetWord()
		{

		}

		public string GenerateWord()
		{
			return $"The word is {Answer}";
		}
	}
}
