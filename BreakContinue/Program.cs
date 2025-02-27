﻿using System;

namespace BreakContinue
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //const is constant, cant change the value 
            const int maxTurns = 20;
            int turn = 0;
            while (true)
            {
                turn++;

                // Ends loop if we're over the maximum number of turns
                if (turn >= maxTurns)
                {
                    break;
                }
                
                // Skips number 10
                if (turn == 10)
                {
                    continue;
                }

                // Skips current cycle if current turn is divisible by 3
                if (turn % 3 == 0)
                {
                    continue;
                }

                // Print turn number
                Console.WriteLine($"Turn number {turn}");
            }

            // Print number of last turn
            Console.WriteLine($"Last turn was {turn}");
        }
    }
}
