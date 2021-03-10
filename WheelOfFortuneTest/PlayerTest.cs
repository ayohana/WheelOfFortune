using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortune;
using System;

namespace WheelOfFortuneTest
{
    [TestClass]
    public class PlayerTest
    {
        /// <summary>
        /// Checks the type of Player instance created
        /// </summary>
        [TestMethod]
        public void PlayerInstance_CheckTypeOfInstance_ReturnsTrue()
        {
            // Arrange
            Player newPlayerInstance = new Player();

            // Act

            //Assert
            Assert.IsInstanceOfType(newPlayerInstance, typeof(Player));
        }
        /// <summary>
        /// Checks the type of the letter to be evaluated
        /// </summary>
        [TestMethod]
        public void PlayerInstance_CheckTypeOfLetterToEvaluate_ReturnsTrue()
        {

            //Arrange
            Player newPlayerInstance = new Player();

            //Act
            Char charToEval = newPlayerInstance.ReadInput();

            //Assert
        }

    }
}
