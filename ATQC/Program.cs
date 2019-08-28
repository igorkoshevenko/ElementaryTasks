using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATQC
{
    class Envelope
    {
        double a, b;
        public double A
        {
            set { a = value; }
            get { return a; }
        }

        public double B
        {
            set { b = value; }
            get { return b; }
        }

        public Envelope(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class Comparison
    {
        Envelope env1;
        Envelope env2;

       
        public Comparison(double a, double b, double c, double d)
        {
            env1 = new Envelope(a, b);
            env2 = new Envelope(c, d);
            CompareEnvelopes(env1, env2);
        }

        public void CompareEnvelopes(Envelope env1, Envelope env2)
        {
            if (env1.A > env2.A && env1.B > env2.B)
                Console.WriteLine("You can put envelope 2 into evelope 1");
            else
                if (env1.A < env2.A && env1.B < env2.B)
                    Console.WriteLine("You can put envelope 1 into evelope 2");
                else
                    Console.WriteLine("You can't put envelope 2 into evelope 1");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Enter sides of evnelope 1: length and width");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter sides of evnelope 2: length and width");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double d = Convert.ToDouble(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0 || d <= 0)
                    {
                        Console.WriteLine("You enter wrong sides");
                    }
                    else
                    {
                        Comparison com = new Comparison(a, b, c, d);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Will you  continue");
                string answer = Console.ReadLine();
                if(answer.ToLower()=="y" || answer.ToLower()=="yes")
                    continue;
                else
                    break;

            }

        }
    }
}
