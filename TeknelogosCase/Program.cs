using TekhnelogosCase.NeuronTypes;

namespace TekhnelogosCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Yapay Sinir Ağının Kurulumu
            //a maddesi CNeuralNetwork neuralNetwork = new(x);

            CNeuralNetwork neuralNetwork = new(5);//b maddesi

            neuralNetwork.AddLayer(2,typeof(CSinusNeuron));

           
            List<double> inputValues = new() { 1.0, 0.0, 0.0, 1.0 };

            var outputValues = neuralNetwork.GetOutputValues(inputValues);

            
            Console.WriteLine("Ağ Çıktıları:");
            foreach (var output in outputValues)
            {
                Console.WriteLine(output);
            }


            Console.ReadLine();
        }
    }

}