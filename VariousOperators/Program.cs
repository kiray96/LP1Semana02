using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for the integral non negative number input 
            Console.Write("Insere número inteiro não negativo: ");

            // Read the input from the user
            string number = Console.ReadLine();

            // Convert and save the input in to a byte variable
            byte n = byte.Parse(number);

            // Print the input divided by 2
            Console.WriteLine(n/2);

            // Print the input shifted left by 3
            Console.WriteLine(n<<3);

            // Print the input using XOR by 6
            Console.WriteLine(n^6);

            // Print boolean representing if the input is over 10
            Console.WriteLine(n>10);

        }
    }
}
