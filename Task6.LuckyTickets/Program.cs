using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Task6.LuckyTickets
{
    public class LuckyTicket
    {
        int min, max;
        public LuckyTicket(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public void Compare()
        {
            if (Simple() > Difficult())
                Console.WriteLine("Simple win " + Simple());
            else
                if (Simple() < Difficult())
                    Console.WriteLine("Difficult win " + Difficult());
                else
                    Console.WriteLine("Simple and Difficult are the same");

        }

        public int Simple()
        {
            int quantity1 = 0;
            for (int i = min; i < max + 1; i++)
            {
                if ((i / 100000 + (i / 10000) % 10 + (i / 1000) % 10) == ((i / 100) % 10 + (i / 10) % 10 + i % 10))
                {
                    quantity1++;
                }
            }
            return quantity1;
        }

        public int Difficult()
        {
            int quantity2 = 0;
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = min; i < max + 1; i++)
            {
                if ((i / 100000) % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                if (((i / 10000) % 10) % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                if (((i / 1000) % 10) % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                if (((i / 100) % 10) % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                if (((i / 10) % 10) % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                if ((i % 10) % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;

                if (sumEven == sumOdd)
                    quantity2++;

            }
            return quantity2;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter first ticket");
                int firstticket = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second ticket");
                int secondticket = Convert.ToInt32(Console.ReadLine());
                if (firstticket < 0 || secondticket < 0)
                    Console.WriteLine("Incorrect values");
                else
                {
                    LuckyTicket lt = new LuckyTicket(firstticket, secondticket);
                    lt.Compare();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
