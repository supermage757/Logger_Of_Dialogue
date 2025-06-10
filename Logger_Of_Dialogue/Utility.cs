using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Of_Dialogue
{
    internal static class Utility
    {
        // First character checker
        // Useful for Y/N inputs, as well as other necessary functions
        internal static string FirstCharacterChecker(string text)
        {
            string firstChar = (text.Substring(0, 1)).ToUpper();
            return firstChar;
        }
        // Tested, works as intended
        // Works with both upper and lowercase characters

        // Is null or empty
        // Very straightforward
        internal static bool NullOrNot(string text)
        {
            if (String.IsNullOrEmpty(text))
                { return true; }
            else
                { return false; }
        }
        // Phew, almost made a major fucky here
        // Works as intended though
        
    }
}
