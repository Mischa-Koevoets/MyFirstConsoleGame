using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcMan
{
    /// <summary>
    /// The Program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args"></param>
        static public void Main(String[] args)
        {
            // Clear the console
            Console.Clear();

            // Ask if the player wants to play a new game. Play a new game, as long as the
            // player doesn't type 'x'
            while (Helpers.Ask("New game? Type 'Y' for new game, 'X' for exit.") != "x")
            {
                // Hide the cursor
                Console.CursorVisible = false;

                // Create a new game
                Game game = new Game();
                game.Play();

                // Set the cursorposition and show the cursor again
                Console.SetCursorPosition(0, 25);
                Console.CursorVisible = true;
            }

            // Goodbye message
            Console.WriteLine("Exit Game!");
        }
    }
}