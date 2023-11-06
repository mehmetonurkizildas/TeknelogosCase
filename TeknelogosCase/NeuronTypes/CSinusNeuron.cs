namespace TekhnelogosCase.NeuronTypes
{
    // b.) İçsel durumunun eşik değerine yaklaşıklığını sinüzoidal bir formül ile hesaplayarak,
    // -­‐1 ve 1 arasında bir değer ateşlemesi.
    // return ( 1 / ( 1 + exp(-toplam / esikDeger)));
    public class CSinusNeuron : CNeuron
    {
        public CSinusNeuron(int inputCount) : base(inputCount) { }

        public override double Evaluate(List<double> inputs)
        {
            double total = inputs.Zip(weights, (input, weight) => input * weight).Sum();
            return 1 / (1 + Math.Exp(-total / threshold));
        }
    }
}
