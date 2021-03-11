using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortune;
using System;

namespace WheelOfFortuneTest
{
    [TestClass]
    public class TargetWordTest
    {
        /// <summary>
        /// Checks the type of Game instance created
        /// </summary>
        [TestMethod]
        public void GenerateTargetWord_CheckReturnType_ReturnTrue()
        {
            // Arrange
            TargetWord word = new TargetWord();

            // Act
            string createdWord = word.GenerateTargetWord();

            // Assert
            Assert.AreEqual(createdWord, "programming");
           
        }

  
      
    }
}
