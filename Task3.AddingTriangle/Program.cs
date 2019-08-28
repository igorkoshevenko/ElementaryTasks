using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3.AddingTriangle
{
    class Triangle : IComparable<Triangle>
    {
        double a, b, c, p;
        string name;
        public Triangle(string name, double a, double b, double c)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Square()
        {
            p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public void Print()
        {
            Console.WriteLine("[{0}]: {1}", name, Square());
        }

        public int CompareTo(Triangle a)
        {
            if (this.Square() < a.Square())
                return 1;
            if (this.Square() > a.Square())
                return -1;
            else
                return 0;
        }
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> TriangleList = new List<Triangle>();
         
            while (true)
            {
                Console.WriteLine("Enter parameters");
                try
                {
                    var separator = ".";
                    var nfiDot = (NumberFormatInfo)CultureInfo.GetCultureInfo("ru-RU").NumberFormat.Clone();
                    nfiDot.NumberDecimalSeparator = nfiDot.CurrencyDecimalSeparator = nfiDot.PercentDecimalSeparator = separator;

                    string info = Console.ReadLine();
                    var triangleInfo = info.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    var triangleName = triangleInfo[0].Trim();
                    var triangleSide1 = double.Parse(triangleInfo[1].Trim(), nfiDot);
                    var triangleSide2 = double.Parse(triangleInfo[2].Trim(), nfiDot);
                    var triangleSide3 = double.Parse(triangleInfo[3].Trim(), nfiDot);

                    if (triangleSide1 > 0 && triangleSide2 > 0 && triangleSide3 > 0)
                    {
                        double p = (triangleSide1 + triangleSide2 + triangleSide3) / 2;
                        if ((p - triangleSide1) > 0 && (p - triangleSide2) > 0 && (p - triangleSide3) > 0)
                        {
                            Triangle tr = new Triangle(triangleName, triangleSide1, triangleSide2, triangleSide3);
                            TriangleList.Add(tr);
                        }
                        else
                            Console.WriteLine("There is no such triangle");
                    }
                    else
                        Console.WriteLine("There is no such triangle");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                
                Console.WriteLine("Will you countinue");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y" ||  answer == "yes")
                    continue;
                else
                    if (answer.ToLower() == "n" || answer.ToLower() == "no")
                    {
                        TriangleList.Sort();
                        Console.WriteLine("==================Triangles List==================");
                        foreach (var item in TriangleList)
                        {
                            item.Print();
                        }
                        break;
                    }
                else
                        Console.WriteLine("Incorrect symbol");
                continue;
            }
            Console.ReadKey();
            
        }
    }
}
