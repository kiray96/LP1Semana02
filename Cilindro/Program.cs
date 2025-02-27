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




            // Calculate the volume of the cylinder
            // Using Math.PI for the PI
            // Using Math.Pow to raise by 2 
            double v = Math.PI * Math.Pow(r, 2) * a;
            // Calculate the surface area of the cylinder
            double s = 2 * Math.PI * r * (r + a);




            // Format the the doubles into 3 decimal places 
            string volume = $"{v:f3}";
            string superficie = $"{s:f3}";

            Console.WriteLine(volume);
            Console.WriteLine(superficie);
            

        }
    }
}
