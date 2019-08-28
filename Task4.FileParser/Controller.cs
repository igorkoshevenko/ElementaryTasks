using System;
using System.Data;
using System.IO;

namespace Task4.FileParser
{
    public class Controller
    {
        #region Constants

        public const string CHOOSE_MODE = "Choose mode for program = 1(count text) or 2(search and change)";
        public const string ENTER_STRING_FOR = "Enter string for {0}";
        public const string COUNT = "count";
        public const string SEARCH = "search";
        public const string CHANGE = "change";
        public const string INCORRECT = "Incorrect {0}";
        public const string MODE = "mode";
        public const string INPUT = "input";
        public const string FILE_EXCEPTION = "There is no file with such name or empty string";
        public const string CONTINUE = "Would you like to continue";

        #endregion

        FileParser _fileParser;

        public void ChooseMode(string name)
        {
            if (File.Exists(name) && !string.IsNullOrWhiteSpace(name))
            {
                int mode = 0;
                Console.WriteLine(CHOOSE_MODE);
                try
                {
                    mode = Convert.ToInt16(Console.ReadLine());
                    switch (mode)
                    {
                        case (int)FileParserMode.SearchAndCountMode:
                            Console.WriteLine(ENTER_STRING_FOR, COUNT);
                            string searchString = Console.ReadLine();
                            _fileParser = new FileParser(name, searchString);
                            _fileParser.FirstMode();
                            break;
                        case (int)FileParserMode.SearchAndReplace:
                            Console.WriteLine(ENTER_STRING_FOR, SEARCH);
                            string search = Console.ReadLine();
                            Console.WriteLine(ENTER_STRING_FOR, CHANGE);
                            string change = Console.ReadLine();
                            Console.WriteLine(new string('-', 50));
                            _fileParser = new FileParser(name, search, change);
                            _fileParser.SecondMode();
                            break;
                        default:
                            Console.WriteLine(INCORRECT, MODE);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(INCORRECT, INPUT);
                }
            }
            else
            {
                Console.WriteLine(FILE_EXCEPTION);
            }
        }

        public bool Continue()
        {
            Console.WriteLine(CONTINUE);
            string answer = Console.ReadLine();
            if ((answer.ToLower().Equals("n") || answer.ToLower().Equals("no")) && string.IsNullOrWhiteSpace(answer))
                return false;
            return true;
        }
    }
}
