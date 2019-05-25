using System;
using System.Collections.Generic;

namespace SpatHochy
{

    public class N
    {
        public static double[,] Weight
        {
            get;
            set
            {
                for (var i = 0; i < Weight.GetLength(0); i++)
                {
                    for (var j = 0; j < Weight.GetLength(1); j++)
                    {
                        var t = new Random();
                        Weight[i, j] = t.NextDouble();
                    }
                }
            }
        }


        public static double Power(double[,] input)
        {
            double power = 0;
            for (var i = 0; i < Weight.GetLength(0); i++)
            {
                for (var j = 0; j < Weight.GetLength(1); j++)
                {
                    power += input[i, j] * Weight[i, j];
                }
            }
            power = 1 / (1 + Math.Pow(Math.Exp, -power));
            return power;//sigmoid
        }

        public static void Print()
        {
            foreach (var i in Weight)
            {
                Console.WriteLine(i);
            }
        }
    }
}
