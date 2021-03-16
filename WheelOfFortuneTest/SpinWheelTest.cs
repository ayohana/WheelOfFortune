using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortune;
using System;


namespace WheelOfFortuneTest
{
    [TestClass]
    public class SpinWheelTest
    { 
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
