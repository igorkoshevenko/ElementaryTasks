using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task4.FileParser
{
    class Program
    {
        private static bool flag = true;

        static void Main(string[] args)
        {
            Controller controller = new Controller();
            while (flag)
            {
                Console.WriteLine("Enter name of the file");
                string name = Console.ReadLine();
                controller.ChooseMode(name);
                flag = controller.Continue();
            }
        }
    }
}
