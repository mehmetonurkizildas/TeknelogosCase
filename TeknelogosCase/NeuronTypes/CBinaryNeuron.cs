namespace TekhnelogosCase.NeuronTypes
{
    // a.) İçsel durumunun belirli bir eşik değeri aşmasını kontrol ederek 1 veya 0 ateşlemesi.
    // if (toplam > esikDeger) return 1 else return 0;

    public class CBinaryNeuron : CNeuron
    {
        public CBinaryNeuron(int inputCount) : base(inputCount) { }

        public override double Evaluate(List<double> inputs)
        {
            double total = inputs.Zip(weights, (input, weight) => input * weight).Sum();
            return total > threshold ? 1 : 0;
        }
    }
}
