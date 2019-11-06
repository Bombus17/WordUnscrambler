using System;
using System.Collections.Generic;
using System.Text;

namespace WordUnscrambler
{
    class Constants
    {
        public const string EnterTestOption = "Enter scrambled word(s) manually or as a file: F - File, M - Manual:";
        public const string ContinueProgram = "Would you like to continue? Y/N";
        
        public const string EnterTestViaFile = "Enter full path including the file name: ";
        public const string EnterTestManually = "Enter words manually (separated by commas):";
        public const string ScrambledWordsNotRecognised = "Option not recognised";
        
        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words cannot be loaded:";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated";
        
        public const string MatchFound = "Match Found for {0}: {1}";
        public const string MatchNotFound = "No matches found";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFileName = "wordlist.txt";
    }
}
