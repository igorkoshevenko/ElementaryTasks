using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Fibonacci
{
    public class Fibonacci
    {
        int min, max;
        int length;

        public Fibonacci(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public Fibonacci(int length)
        {
            this.length = length;
        }

        public int fib(int n)
        {
            int x = 1;
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                x += y;
                y = x - y;
            }
            return y;
        }

        public void PrintFibInterval()
        {
            for (int i = 0; i < 10000; i++)
            {
                if (fib(i) > min && fib(i) < max)

                    Console.Write(fib(i) + ", ");
            }
        }

        public void PrintFibLength()
        {

            for (int i = 0; i < 10000; i++)
            {

                if ((int)Math.Log10(fib(i)) + 1 == length)

                    Console.Write(fib(i) + ", ");
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number of ranks");
                int n = Int16.Parse(Console.ReadLine());
                if (n > 0)
                {
                    Fibonacci f = new Fibonacci(n);
                    f.PrintFibLength();
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 50));
                }
                else
                    Console.WriteLine("Incorrect value");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Enter numbers of interval");
                int min = Int16.Parse(Console.ReadLine());
                int max = Int16.Parse(Console.ReadLine());
                if (min > 0 && max > 0)
                {
                    if (min < max)
                    {
                        Fibonacci a = new Fibonacci(min, max);
                        a.PrintFibInterval();
                    }
                    else
                    {
                        Fibonacci b = new Fibonacci(max, min);
                        b.PrintFibInterval();
                    }
                }
                else
                    Console.WriteLine("Incorrect values");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
       
    }
}
