using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.SquareNumber
{
    class SquareNumber
    {
        int RowLength;
        int Square;


        public SquareNumber(int RowLength, int Square)
        {
            this.RowLength = RowLength;
            this.Square = Square;
        }
 
      
        public void Print()
        {
            int quantity = 0;
            double RootNumber = Math.Sqrt(Square);
            for (int i = 0; i < 100000; i++)
            {
                if (i >= RootNumber)
                {
                    Console.Write(i + ", ");
                    quantity++;
                    if (quantity == RowLength)
                        break;
                }
                
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter square of number");
                int square = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter row length");
                int rowlength = Convert.ToInt16(Console.ReadLine());
                if (square < 0 || rowlength <= 0)
                    Console.WriteLine("Incorrect values");
                else
                {
                    SquareNumber sn = new SquareNumber(rowlength, square);
                    sn.Print();
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
