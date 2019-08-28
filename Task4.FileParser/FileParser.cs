using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task4.FileParser
{
    public enum FileParserMode
    {
        SearchAndCountMode = 1,
        SearchAndReplace
    }

    public class FileParser
    {
        #region Constants

        public const string FILE_MATCHES_DONT_FOUND = "Match does not found";
        public const string FILE_MATCHES_FOUND = "Matches quantity - {0}";

        #endregion

        string _filename;
        string _search;
        string _change;

        public FileParser(string filename, string search)
        {
            _filename = filename;
            _search = search;
        }

        public FileParser(string filename, string search, string change)
        {
            _filename = filename;
            _search = search;
            _change = change;
        }

        public string ReadFile()
        {
            FileStream file = new FileStream(_filename, FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string readFile = reader.ReadToEnd();
            reader.Close();
            return readFile;
        }

        public void FirstMode()
        {
            var regex = new Regex(_search);
            if (regex.Matches(ReadFile()).Count == 0)
                Console.WriteLine(FILE_MATCHES_DONT_FOUND);
            else
                Console.WriteLine(FILE_MATCHES_FOUND, regex.Matches(ReadFile()).Count);
        }

        public void SecondMode()
        {
            string result = Regex.Replace(ReadFile(), _search, _change);
            StreamWriter writer = new StreamWriter(_filename, false);
            writer.WriteLine(result);
            writer.Close();
            Console.WriteLine(result);
        }
    }
}