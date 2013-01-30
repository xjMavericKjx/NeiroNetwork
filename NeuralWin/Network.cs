using System;
using System.Linq;


namespace NeuralWin
{
    public class Network
    {
        public Neuron[] InputLayer = new Neuron[35];
        public Neuron[] IntermediateLayer = new Neuron[18];
        public Neuron[] OutputLayer = new Neuron[2];

        public Network(int entrancesNumber)
        {
            var r = new Random();
            FillNeyronLayer(InputLayer, r, entrancesNumber);
            FillNeyronLayer(IntermediateLayer, r, InputLayer.Count());
            FillNeyronLayer(OutputLayer, r, IntermediateLayer.Count());
        }

        private void FillNeyronLayer(Neuron[] layer, Random rnd, int entrancesNumber)
        {
            for (int i = 0; i < layer.Count(); i++)
                layer[i] = new Neuron(entrancesNumber, rnd.Next(10000));
        }

        public bool Validate(double[] entranceValues, double[] validValues)
        {
            var currentResultsOfNetworkWork = Entrance(entranceValues);

            var d = new double[2];
            if (currentResultsOfNetworkWork[0] >= currentResultsOfNetworkWork[1])
            {
                d[0] = 1;
                d[1] = 0;
            }
            else
            {
                d[0] = 0;
                d[1] = 1;
            }
            return ((validValues[0] == d[0]) && (validValues[1] == d[1]));
        }

        public double[] Entrance(double[] entranceValue)
        {
            return GetLayerEntrance(OutputLayer,
                   GetLayerEntrance(IntermediateLayer,
                   GetLayerEntrance(InputLayer, entranceValue)));
        }

        private double[] GetLayerEntrance(Neuron[] layer, double[] inputValue)
        {
            foreach (var value in layer)
                value.Entrance(inputValue);

            var intermediateResult = new double[layer.Count()];
            for (int i = 0; i < layer.Count(); i++)
                intermediateResult[i] = layer[i].ActivateFunction();
            return intermediateResult;
        }

        public void Teach(double[] entranceValues, double[] validValues)
        {
            var currentResultsOfNetworkWork = Entrance(entranceValues);
            const double alpha = 1;

            var outputLayerError = new double[2];

            for (int i = 0; i < outputLayerError.Count(); i++)
            {
                outputLayerError[i] = alpha * currentResultsOfNetworkWork[i] * (1 - currentResultsOfNetworkWork[i]) 
                    * (currentResultsOfNetworkWork[i] - validValues[i]);
            }

            double[] intermediateLayerError = ErrorInLayer(alpha, IntermediateLayer, OutputLayer, outputLayerError);
            double[] inputLayerError = ErrorInLayer(alpha, InputLayer, IntermediateLayer, intermediateLayerError);

            CorrectionLayerWeight(InputLayer, inputLayerError);
            CorrectionLayerWeight(IntermediateLayer, intermediateLayerError);
            CorrectionLayerWeight(OutputLayer, outputLayerError);
        }

        private double[] ErrorInLayer(double alpha, Neuron[] currentLayer, Neuron[] nextLayer, double[] nextLayerError)
        {
            var layerError = new double[currentLayer.Count()];

            for (int i = 0; i < layerError.Count(); i++)
            {
                double weight = 0;
                for (int j = 0; j < nextLayer.Count(); j++)
                {
                    weight += nextLayer[j].EntrancesWeight[i] * nextLayerError[j];
                }
                layerError[i] = alpha * currentLayer[i].ActivateFunction() * (1 - currentLayer[i].ActivateFunction()) * weight;
            }
            return layerError;
        }

        private void CorrectionLayerWeight(Neuron[] layer, double[] layerError)
        {
            const double learningSpeed = 0.8;
            for (int j = 0; j < layer.Count(); j++)
            {
                for (int i = 0; i < layer[j].EntrancesWeight.Count(); i++)
                {
                    var delta = (-1) * learningSpeed * layerError[j] * layer[j].EntranceValue[i];
                    layer[j].EntrancesWeight[i] += delta;
                }
            }
        }
    }
}
