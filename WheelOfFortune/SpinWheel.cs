using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class SpinWheel
    {
        public List<int> awardPoints = new List<int> { 0, 100, 200, 500, 1000 };
        public List<int> bonusPoints = new List<int> { 1000, 2000, 5000, 10000 };
        Random random = new Random();
        

        /// <summary>
        /// Method is invoked if the Player guesses correct letter and a random point is generated from the list of  award points
        /// </summary>
        /// <returns>pointsAwarded</returns>
        public  int SpinWheelForCorrectGuessedLetter()
        {
            int pointsEarnedIndex = random.Next(awardPoints.Count);
            int pointsAwarded = awardPoints[pointsEarnedIndex];
            return pointsAwarded;
        }

        /// <summary>
        /// Method is invoked if the Player guesses enitire word correctly and a random point is generated from the list of bonus points
        /// </summary>
        /// <returns>bonusPointsAwarded</returns>
        public int SpinWheelForCorrectWord()
        {
            int pointsIndex = random.Next(bonusPoints.Count);
            int bonusPointsAwarded = awardPoints[pointsIndex];
            return bonusPointsAwarded;
        }

    }
}
