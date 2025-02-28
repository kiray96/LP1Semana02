using System;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string start, step, response;

            Console.Write("Start number: ");
                start = Console.ReadLine(); 

            Console.Write("Step number: ");
                step = Console.ReadLine();

            int s = int.Parse(start);
            int st = int.Parse(step);

            int maxTurns = st;
            
            while (true)
            {
                s--;
                response = ("");

                if (s > 1)
                {
                    response = "Out-of-range start or step. Try again.";
                    break;
                }


                if  (s<=st)
                {
                    response = "Start must be higher than step. Try again";
                    break;
                }

                // Ends loop if we're over the maximum number of turns
             
                if (s % st == 0)
                {
                    response = "Star not divisible by step. Try again.";
                    break;
                }

                // Print number of last turn
                Console.WriteLine(response);
            }
        }    
    }
}


