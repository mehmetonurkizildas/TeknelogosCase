namespace TekhnelogosCase
{
    public class CNeuralLayer
    {
        public List<CNeuron> neurons;

        public CNeuralLayer(int inputCount, int neuronCount, Type neuronType)
        {
            neurons = new List<CNeuron>();
            for (int i = 0; i < neuronCount; i++)
            {
                neurons.Add((CNeuron)Activator.CreateInstance(neuronType, inputCount));
            }
        }

        public List<double> Evaluate(List<double> inputs)
        {
            return neurons.Select(neuron => neuron.Evaluate(inputs)).ToList();
        }
    }

}