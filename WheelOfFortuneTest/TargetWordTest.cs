using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortune;
using System;
using System.Collections.Generic;

namespace WheelOfFortuneTest
{
    [TestClass]
    public class TargetWordTest
    {
        /// <summary>
        /// Checks if the randomly generated word came from the list as expected
        /// </summary>
        [TestMethod]
        public void GenerateTargetWord_CheckReturnType_ReturnTrue()
        {
            // Arrange
            TargetWord word = new TargetWord();
            List<string> expectedList = word.TargetWordsList;

            // Act
            string randomWordGenerated = word.GenerateTargetWord();

            // Assert
            Assert.IsTrue(expectedList.Contains(randomWordGenerated));           
        }

        /// <summary>
        /// Skipping test
        /// </summary>
        /// TO DO: console.clear() produces error
        [TestMethod, Ignore]
        public void IsCorrect_CheckReturnType_ReturnTrue()
        {
            // Arrange 
            TargetWord word = new TargetWord();

            // Act
            bool isCorrectLetter = word.IsCorrect('p');

            // Assert
            Assert.IsTrue(isCorrectLetter);
        }
    }
}
