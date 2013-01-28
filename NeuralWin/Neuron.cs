using System;
using System.Linq;

namespace NeuralWin
{
    [Serializable]
    public class Neuron
    {
        public double[] EntrancesWeight;
        public double[] EntranceValue;

        private double _sum;

        public int EntrancesNumber { get { return EntrancesWeight.Count(); } }

        public Neuron(int entrancesNumber, int shift)
        {
            EntrancesWeight = new double[entrancesNumber];
            EntranceValue = new double[entrancesNumber];

            var r = new Random(shift);

            for (int i = 0; i < entrancesNumber; i++)
            {
                var weight=0.0;
                while (weight < 0.01)
                {
                    weight = r.NextDouble() * 0.1;
                }

                if (r.Next(2) == 1) weight *= -1;
                EntrancesWeight[i] = weight;
            }
        }

        public double ActivateFunction()
        {
            return 1 / (1 + Math.Pow(Math.E, -2 * _sum));
        }

        public void Entrance(double[] d)
        {
            EntranceValue = d;
            _sum = 0;
            for (int i = 0; i < d.Count(); i++)
                _sum += EntrancesWeight[i] * d[i];
        }
    }
}
