using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Of_Dialogue
{
    internal class Architecture
    {
        // ARCHITECTURE CLASS
        // SOLELY MEANT FOR PLANNING OUT WHAT CLASSES ARE NEEDED

        // First, test to make sure repo works and is connected.
        // Okay, this works. We smoove.

        // I want this program to effectively:
            // log statements/actions
            // including the day/time of the statement/action
            // and who made the statement/action

        // This is made with manipulative people in mind
            // People who deflect blame
            // People who downplay their own actions constantly
            // People who perpetually ask "when did i say/do that?" when confronted


        // CLASSES NEEDED:::
            // Utility class (guh doy) for all utility methods
            // Class for the general logger software (including interface)
            // Class to handle file saving and loading
            // Dictionary class to handle appending/removing/altering entries
            
            // SIDE NOTE:: I'm honestly surprised with how little classes this needs
            // It isn't that complex of a program, but that's okay




        // STUFF EACH CLASS NEEDS:::
        // UTILITY
            // first character checker for user input
                // check AS CAPITAL LETTERS for consistency! (toUpper)
            // isnullorempty
                // could possibly fold into the first character checker


        // GENERAL LOGGER SOFTWARE
            // access file save/load class
            // access utility class
            // access dictionary class


        // SAVING/LOADING
            // has:
                // default file to create if none exist
                // default file path if none exist

            // verify if file exists
                // if file doesn't exist create one
            // load file
                // if file doesn't exist don't crash program


        // DICTIONARY
            // instance the dictionary itself 
            // has:
                // KEY: person name followed by date
                    // key is string
                    // avoids conflicting keys if two things are entered for same date with different people
                // VALUES : type of 'event', event itself, (add to this if needed)

            // append entries
            // option to remove entries if desired
                // search for entry by date
           
            
    }
}
