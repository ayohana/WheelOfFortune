using System;
using System.Collections.Generic;

namespace WheelOfFortune
{
    /// <summary>
    /// Game starts with one player and one word, keeps track of session and ends when the player wins.
    /// </summary>
    public class Game
    {
        public Player CurrentPlayer;
        public TargetWord word = new TargetWord();

        /// <summary>
        /// This method starts game and keeps track of current game session.
        /// </summary>
        // TO DO: refactor while loop into seperate method
        public void StartGame()
        {
            CurrentPlayer = new Player();

            Console.WriteLine("Welcome to Wheel of Fortune. A game by SpaceCoders.");
            word.GenerateDashes();

            while (word.ValidChars.Count > 0)
            {
                Console.WriteLine("Press 1 to guess character, 2 to guess full word.");
                char choice = Console.ReadKey(true).KeyChar;

                if (choice == '1')
                {

                    char letter = CurrentPlayer.ReadInput();
                    if (!word.IsCorrect(letter))
                    {
                        Console.WriteLine($"Incorrect Letter {letter}");
                    }
                }
                else if (choice == '2')
                {
                    string guessedWord = CurrentPlayer.ReadWordInput();
                    if (!word.IsWordCorrect(guessedWord))
                    {
                        Console.WriteLine($"Incorrect word {guessedWord}");
                    }
                    else
                    {
                        // Whole word is found. So, we set valid characters to empty.
                        word.ValidChars = new HashSet<char>();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter correct choice.");
                }
            }

            EndGame();
        }

        /// <summary>
        /// Ends the game.
        /// </summary>
        public void EndGame()
        {
            CurrentPlayer = null;
            Console.WriteLine("You've reached end of the game!");
            Console.ReadLine();
        }
    }
}
