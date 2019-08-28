using System;

namespace Task5.TrasformationToString
{
    enum Values
    {
        ноль = 0,
        один = 1,
        два = 2,
        три,
        четыре,
        пять,
        шесть,
        семь,
        восемь,
        девять,
        десять = 10,
        одиннадцать,
        двенадцать,
        тринадцать,
        четырнадцать,
        пятнадцать,
        шестнадцать,
        семнадцать,
        восемнадцать,
        девятнадцать,
        двадцать,
        тридцать = 30,
        сорок = 40,
        пятьдесят = 50,
        шестьдесять = 60,
        семдесят = 70,
        восемьдесят = 80,
        девяносто = 90,
        сто = 100,
        двести = 200,
        триста = 300,
        четыреста = 400,
        пятсот = 500,
        шестсот = 600,
        семьсот = 700,
        восемьсот = 800,
        девятсот = 900
    }

    class Transform
    {
        long number;

        #region Constants

        public const int QUANTITY_OF_RANKS = 12;
        public const int RANK_DIVIDE = 3;

        #endregion

        public Transform(long x)
        {
            number = x;
        }

        public void GetStringFromNumber()
        {
            long[] rank = new long[QUANTITY_OF_RANKS];
            long div = 100000000000;
            long var = number;
            long rest;

            for (int i = 0; i < QUANTITY_OF_RANKS; i++)
            {
                rest = (long)var / div;
                rank[i] = rest;
                var = var - rest * div;
                div = div / 10;
            }

            long[] billions = new long[RANK_DIVIDE];
            for (int i = 0; i < RANK_DIVIDE; i++)
            {
                billions[i] = rank[i];
            }

            long[] mil = new long[RANK_DIVIDE];
            for (int i = 0; i < RANK_DIVIDE; i++)
            {
                mil[i] = rank[i + 3];
            }

            long[] thousands = new long[RANK_DIVIDE];
            for (int i = 0; i < RANK_DIVIDE; i++)
            {
                thousands[i] = rank[i + 6];
            }

            long[] numbers = new long[RANK_DIVIDE];
            for (int i = 0; i < RANK_DIVIDE; i++)
            {
                numbers[i] = rank[i + 9];
            }

            PrintNumbers(billions);
            if (billions[0] != 0 || billions[1] != 0 || billions[2] != 0)
            {

                if (billions[2] == 1)
                    Console.Write("миллиард ");
                else if (billions[2] == 2 || billions[2] == 3 || billions[2] == 4)
                    Console.Write("миллиарда ");
                else
                    Console.Write("миллиардов ");
            }
            else
                Console.Write("");


            PrintNumbers(mil);
            if (mil[0] != 0 || mil[1] != 0 || mil[2] != 0)
            {
                if (mil[2] == 1 || mil[2] == 2 || mil[2] == 3 || mil[2] == 4)
                    Console.Write("миллиона ");
                else
                    Console.Write("миллионов ");
            }
            else
                Console.Write("");


            PrintNumbers(thousands);
            if (thousands[0] != 0 || thousands[1] != 0 || thousands[2] != 0)
            {
                if (thousands[2] == 1 || thousands[2] == 2)
                    Console.Write("тысяча ");
                else if (thousands[2] == 3 || thousands[2] == 4)
                    Console.Write("тысячи ");
                else
                    Console.Write("тысяч ");
            }
            else
                Console.Write("");

            PrintNumbers(numbers);
        }


        public void PrintNumbers(long[] rank)
        {
            switch (rank[0])
            {
                case 1:
                    Console.Write(Values.сто + " ");
                    break;
                case 2:
                    Console.Write(Values.двести + " ");
                    break;
                case 3:
                    Console.Write(Values.триста + " ");
                    break;
                case 4:
                    Console.Write(Values.четыреста + " ");
                    break;
                case 5:
                    Console.Write(Values.пятсот + " ");
                    break;
                case 6:
                    Console.Write(Values.шестсот + " ");
                    break;
                case 7:
                    Console.Write(Values.семьсот + " ");
                    break;
                case 8:
                    Console.Write(Values.восемьсот + " ");
                    break;
                case 9:
                    Console.Write(Values.девятсот + " ");
                    break;
                default: break;
            }

            switch (rank[1])
            {
                case 1:
                    switch (rank[2])
                    {
                        case 0:
                            Console.Write(Values.десять + " ");
                            break;
                        case 1:
                            Console.Write(Values.одиннадцать + " ");
                            break;
                        case 2:
                            Console.Write(Values.двенадцать + " ");
                            break;
                        case 3:
                            Console.Write(Values.тринадцать + " ");
                            break;
                        case 4:
                            Console.Write(Values.четырнадцать + " ");
                            break;
                        case 5:
                            Console.Write(Values.пятнадцать + " ");
                            break;
                        case 6:
                            Console.Write(Values.шестнадцать + " ");
                            break;
                        case 7:
                            Console.Write(Values.семнадцать + " ");
                            break;
                        case 8:
                            Console.Write(Values.восемнадцать + " ");
                            break;
                        case 9:
                            Console.Write(Values.девятнадцать + " ");
                            break;
                    }

                    rank[2] = 0;
                    break;
                case 2:
                    Console.Write(Values.двадцать + " ");
                    break;
                case 3:
                    Console.Write(Values.тридцать + " ");
                    break;
                case 4:
                    Console.Write(Values.сорок + " ");
                    break;
                case 5:
                    Console.Write(Values.пятьдесят + " ");
                    break;
                case 6:
                    Console.Write(Values.шестьдесять + " ");
                    break;
                case 7:
                    Console.Write(Values.семдесят + " ");
                    break;
                case 8:
                    Console.Write(Values.восемьдесят + " ");
                    break;
                case 9:
                    Console.Write(Values.девяносто + " ");
                    break;
                default: break;

            }

            switch (rank[2])
            {
                case 1:
                    Console.Write(Values.один + " ");
                    break;
                case 2:
                    Console.Write(Values.два + " ");
                    break;
                case 3:
                    Console.Write(Values.три + " ");
                    break;
                case 4:
                    Console.Write(Values.четыре + " ");
                    break;
                case 5:
                    Console.Write(Values.пять + " ");
                    break;
                case 6:
                    Console.Write(Values.шесть + " ");
                    break;
                case 7:
                    Console.Write(Values.семь + " ");
                    break;
                case 8:
                    Console.Write(Values.восемь + " ");
                    break;
                case 9:
                    Console.Write(Values.девять + " ");
                    break;
                default: break;
            }
        }

    }
}