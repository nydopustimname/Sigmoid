using System;
using System.Collections.Generic;
using System.Text;

namespace SpatHochy
{
    public class NN
    {
        public N[] Neurons
        {
            get
            {
                return Neurons;
            }
            set
            {
                Neurons = new N[60];
            }
        }

        public int Answer (double[,] input)
        {
            var answers = new double[Neurons.Length];
            for (var i=0; i<Neurons.Length; i++)
            {
                answers[i]=Neurons[i].GetPower(input);
            }
            var correct = 0;
            for (var i=0; i<answers.Length; i++)
            {
                if (answers[i] > answers[correct])
                    correct = i;
            }
            return correct;
            ///хуйняяяя
            ///возвращает индексы, знач придется вводить словарь (индекс->значение)
        }
    }
}
