using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortune;
using System;

namespace WheelOfFortuneTest
{
    [TestClass]
    public class GameTest
    {
        /// <summary>
        /// Checks the type of Game instance created
        /// </summary>
        [TestMethod]
        public void GameInstance_CheckTypeOfInstance_ReturnsTypeOfGame()
        {
            // Arrange
            Game newGameInstance = new Game();

            // Act

            // Assert
            Assert.IsInstanceOfType(newGameInstance, typeof(Game));
        }

        /// <summary>
        /// Check if StartGame() would instantiate Player object as the CurrentPlayer attribute of Game instance.
        /// </summary>
        /// TODO: skipping because Console produces error
        [TestMethod]
        [Ignore]
        public void StartGame_VerifyTypeOfCurrentPlayerAttribute_ReturnsTrue()
        {
            // Arrange
            Game newGameInstance = new Game();

            // Act
            newGameInstance.StartGame();
            var currentPlayer = newGameInstance.CurrentPlayer;

            // Assert
            Assert.IsInstanceOfType(currentPlayer, typeof(Player));
        }

        /// <summary>
        /// Check if EndGame() reassigns CurrentPlayer attribute to be null.
        /// </summary>
        /// TODO: Skipping because console produces Error.
        [TestMethod]
        [Ignore]
        public void EndGame_VerifyCurrentPlayerAttributeToBeNull_ReturnsTrue()
        {
            // Arrange
            Game newGameInstance = new Game();

            // Act
            newGameInstance.StartGame();            
            newGameInstance.EndGame();

            // Assert
            Assert.IsNull(newGameInstance.CurrentPlayer);
        }
    }
}
