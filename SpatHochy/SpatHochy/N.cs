using System;
using System.Collections.Generic;

public class N
{

    private static double[,] weight = new double[100,20];
    static double[,] Fill()
    {
        for (var i = 0; i < weight.GetLength(0); i++)
        {
            for (var j = 0; j < weight.GetLength(1); j++)
            {
                var t = new Random();
                weight[i, j] = Math.Round(t.NextDouble(), 3);
            }
            
        }
        return weight;
    }
    
    public static double[,] Weight
    {
        get
        {
            return Fill();
        }
        set
        {
            for (var i=0; i<weight.GetLength(0); i++)
            {
                for (var j=0; j<weight.GetLength(1); j++)
                  weight[i,j] = Weight[i,j];
            }
        }
    }

    public static double[] Output
    {
        get
        {
            return Output;
        }
        set
        {
            Output = new double[10];
        }
    }


    public static double[] GetPower (double [,]input)
    {
        for (var i = 0; i < input.GetLength(0); i++)
        {
            for (var j = 0; j < input.GetLength(1); j++)
            {
                double power = 0;
                power += input[i, j] * Weight[i, j];
                power = 1 / (1 + Math.Exp(-power));
                Output[i] = power;
            }
        }
        
        return Output;
    }

    
    public static double[,] BackPropagation (int learningRate)
    {
        var temp = Output[0];
        for (var i=0; i<Output.Length; i++)
        {
            if (Output[i] > temp)
                temp = Output[i];
        }

        var weightDelta = 1 / (1 + Math.Exp(-temp)) * (1 - 1 / (1 + Math.Exp(-temp)));

        for (var i=0; i<Weight.GetLength(0); i++)
        {
            for (var j=0; j<Weight.GetLength(1); j++)
            {
                Weight[i, j] = Weight[i, j] - Output[j] * weightDelta * learningRate;
            }
        }
        return Weight;
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
