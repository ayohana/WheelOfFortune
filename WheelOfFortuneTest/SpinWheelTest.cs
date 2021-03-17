using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortune;
using System;


namespace WheelOfFortuneTest
{
    [TestClass]
    public class SpinWheelTest
    {

        /// <summary>
        /// The test method checks if the SpinWheelForCorrectGuessedLetter returns a value or not
        /// </summary>
        [TestMethod]
        public void SpinWheelForCorrectGuessedLetter_CheckIsNotNull_ReturnTrue()
        {
            //Arrange
             SpinWheel wheel = new SpinWheel();

            //Act
            int value = wheel.SpinWheelForCorrectGuessedLetter();

            //Assert
            Assert.IsNotNull(value);
        }
        /// <summary>
        /// The test method checks if the SpinWheelForCorrectWord returns a value or not
        /// </summary>
        [TestMethod]
        public void SpinWheelForCorrectWord_CheckIsNotNull_ReturnTrue()
        {
            //Arrange
            SpinWheel wheel = new SpinWheel();

            //Act
            int value = wheel.SpinWheelForCorrectWord();

            //Assert
            Assert.IsNotNull(value);
        }
    }
}
