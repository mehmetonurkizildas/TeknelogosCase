namespace TekhnelogosCase.NeuronTypes
{
    // c.) İçsel değerini doğrudan ateşlemesi.
    // return toplam;
    public class CValueNeuron : CNeuron
    {
        public CValueNeuron(int inputCount) : base(inputCount) { }

        public override double Evaluate(List<double> inputs)
        {
            double total = inputs.Zip(weights, (input, weight) => input * weight).Sum();
            return total;
        }
    }
}
