﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void PlayerInstance_CheckTypeOfInstance_ReturnsTypeOfPlayer()
        {
            // Arrange
            Player newPlayerInstance = new Player();

            // Act

            //Assert
            Assert.IsInstanceOfType(newPlayerInstance, typeof(Player));
        }

    }
}