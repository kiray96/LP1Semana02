using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask for the user for the height input 
            Console.Write("Insere número com a altura do cilindro: ");

            // Read the input
            string altura = Console.ReadLine();

            // Ask for the user for the radius input 
            Console.Write("Insere número com o raio do cilindro: ");

            // Read the input
            string raio = Console.ReadLine();

            // Convert the height input in to a double
            double a = double.Parse(altura);

            // Convert the radius input in to a double
            double r = double.Parse(raio);

        }
    }
}
