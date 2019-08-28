using System;

namespace Task5.TrasformationToString
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("");
                long a = Convert.ToInt64(Console.ReadLine());
                if (a >= 0)
                {
                    Transform t = new Transform(a);
                    t.GetStringFromNumber();
                }
                else
                {
                    long b = -a;
                    Console.Write("минус ");
                    Transform t = new Transform(b);
                    t.GetStringFromNumber();
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
