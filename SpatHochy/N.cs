using System;
using System.Collections.Generic;

public class N
{

    private static double[] weight = new double[60];
    static double[] Fill()
    {
        for (var i = 0; i < weight.GetLength(0); i++)
        {
            
             var t = new Random();
                weight[i] =Math.Round( t.NextDouble(), 3);
            
        }
        return weight;
    }
    
    public static double[] Weight
    {
        get
        {
            return Fill();
        }
        set
        {
            for (var i=0; i<weight.GetLength(0); i++)
            {
                  weight[i] = Weight[i];
            }
        }
    }


    public double GetPower (double [,]input)
    {
        double power = 0;
        for (var i = 0; i < Weight.GetLength(0); i++)
        {
            for (var j = 0; j < Weight.GetLength(0); j++)
            {
                power += input[i, j] * Weight[j];
            }
        }
        power = 1 / (1 + Math.Exp(-power) );
        return power;
    }

    //public static void Print()
    //{
    //    for (var i = 0; i < Weight.GetLength(0); i++)
    //    {
    //        Console.Write(Weight[i] + "  ");

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine(Weight.GetLength(0));
    //}
}
