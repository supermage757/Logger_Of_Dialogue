using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Of_Dialogue
{
    internal class GeneralLogger
    {

        // DEFAULT FILE PATH
        internal const string DEFAULT_FILE_PATH = "ManippyLogger.json";

        // set up the whole dictionary thingy
        // to verify if user wants to load or use new dictionary
        internal bool LoadFromFile()
        {
            string tempChoice;
            Console.WriteLine("Load from previously existing file? (Y/N)");
            tempChoice = Utility.FirstCharacterChecker(Console.ReadLine());
            // get users choice
            // solely for user choice
            // will handle actual processes elsewhere
            if (tempChoice == "Y")
            {
                // return true
                return true;
            }
            else
            {
                // return false
                return false;
            }
        }

        // 
    }
}
