namespace TekhnelogosCase
{
    public abstract class CNeuron
    {
        protected List<double> weights; // Nöronun ağırlık değerleri
        protected double threshold; // Eşik değeri 

        public CNeuron(int inputCount)
        {
            Random random = new Random();
            weights = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                weights.Add(random.NextDouble() * 2 - 1); // Rastgele ağırlık değerleri (-1 ile 1 arasında)
            }

            threshold = random.NextDouble() * 2 - 1; // Rastgele eşik değeri (-1 ile 1 arasında)
        }

        public abstract double Evaluate(List<double> inputs);
    }

}