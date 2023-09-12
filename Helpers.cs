using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcMan
{
    /// <summary>
    /// The class that contains methods that are easy to have trhougout the game. 
    /// </summary>
    static class Helpers
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="question">The question to be displayed on the screen.</param>
        /// <returns>The players input, converted to lowercase</returns>
        static public string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine().ToLower();
        }
    }
}
