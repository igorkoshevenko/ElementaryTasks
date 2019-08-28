using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ChessBoard
{
    class ChessBoard
    {
        int x, y;
        public ChessBoard(int x, int y)
        {
            this.x = x;
            this.y = y;
            DrawChessBoard();
        }


        public void DrawChessBoard()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i % 2 == 0)
                    Console.Write("* ");
                    else
                        Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter width and length");
                try
                {
                    int a = Convert.ToInt16(Console.ReadLine());
                    int b = Convert.ToInt16(Console.ReadLine());
                    if (a <= 0 || b <= 0)
                        Console.WriteLine("Incorrect value of parameters");
                    else
                    {
                        ChessBoard chess = new ChessBoard(a, b);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Will you countinue");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                    continue;
                else
                    break;

            }
            
            Console.ReadKey();
            
        }
    }
}
