using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace PcMan
{
    /// <summary>
    /// The Game class
    /// </summary>
    internal class Game
    {
        private ConsoleKey lastPressed;
        private int top;
        private int left;


        /// <summary>
        /// The constructor
        /// </summary>
        public Game()
        {
            // Set start position for character
            top = 10; 
            left = 40;
            Move(0, 0); // Done to draw character to the screen at start
        }

        /// <summary>
        /// The Play method, this starts the game.
        /// </summary>
        public void Play()
        {
            while (true)
            {
                Update();
            }
        }
        /// <summary>
        /// Update, gets called continuously while the game is playing.
        /// </summary>
        private void Update()
        {
            // Get the last key pressed from the Console (if one is available)
            if (Console.KeyAvailable)
            {
                lastPressed = Console.ReadKey(true).Key;
            }

            // Handle keypress
            // Gebruik lastPressed, en probeer dan de character in de juiste richting te verplaatsen.
            if (lastPressed == ConsoleKey.UpArrow)
            {
                Move(-1, 0);
            }
            if (lastPressed == ConsoleKey.DownArrow)
            {
                Move(1, 0);
            }

            // Reset keypress
            lastPressed = 0;            
        }

        // Method to check wether we can move by given integers for top and left
        /// <summary>
        /// Checks wether it is possible for the character to move by the specified params.
        /// </summary>
        /// <param name="deltaTop"></param>
        /// <param name="deltaLeft"></param>
        /// <returns>
        /// A bool that indicates wether it is possible to move.
        /// </returns>
        public bool CanMove(int deltaTop, int deltaLeft)
        {
            if (top + deltaTop < 0 || top + deltaTop > 24)
            {
                return false;
            }
            if (left + deltaLeft < 0 || left + deltaLeft > 79)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Moves the character by the specified params.
        /// </summary>
        /// <param name="deltaTop"></param>
        /// <param name="deltaLeft"></param>
        public void Move(int deltaTop, int deltaLeft)
        {
            // Clear current position
            Console.SetCursorPosition(left, top);
            Console.Write(" ");
            
            top += deltaTop;
            left += deltaLeft;

            // Draw new position
            Console.SetCursorPosition(left, top);
            Console.Write("@");
        }

        /// <summary>
        /// Tries to move the charachter by the specified params. 
        /// </summary>
        /// <param name="deltaTop"></param>
        /// <param name="deltaLeft"></param>
        /// <returns>
        /// A bool that indicates wether the character has been succesfully moved.
        /// </returns>
        public bool TryMove(int deltaTop, int deltaLeft)
        {
            if (CanMove(deltaTop, deltaLeft))
            {
                Move(deltaTop, deltaLeft);
                return true;
            }
            return false;
        }
    }
}
