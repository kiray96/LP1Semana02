using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the player to insert an integral number
            Console.Write("Insere número inteiro: ");

            // Read the input of the player
            string number = Console.ReadLine();

            // Convert the string in to a sbyte
            sbyte n = sbyte.Parse(number);

            // Print the number with the decrement and increment
            Console.WriteLine(--n);
            Console.WriteLine(++n);

        }
    }
}
