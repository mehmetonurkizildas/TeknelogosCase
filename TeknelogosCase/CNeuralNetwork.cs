using TekhnelogosCase.NeuronTypes;

namespace TekhnelogosCase
{
    public class CNeuralNetwork
    {
        private List<CNeuralLayer> layers;

        public CNeuralNetwork(int inputCount)
        {
            layers = new List<CNeuralLayer>
            {
                new CNeuralLayer(inputCount, inputCount, typeof(CValueNeuron))
            };
        }

        public void AddLayer(int neuronCount, Type neuronType)
        {
            int inputCount = layers.Count;
            layers.Add(new CNeuralLayer(inputCount, neuronCount, neuronType));
        }

        public List<double> GetOutputValues(List<double> inputs)
        {
            List<double> output = inputs;
            foreach (CNeuralLayer layer in layers)
            {
                output = layer.Evaluate(output);
            }
            return output;
        }
    }

}