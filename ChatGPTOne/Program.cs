﻿using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Auxiliary variables
            string question, response;

            // Bool so i can make the while loop end
            bool running = true;

            while (running)
            {
                // Ask the user a question
                Console.Write("Place your question: ");
                question = Console.ReadLine(); 

                 //Check if it is a known issue and determine an appropriate
                 // response
                switch (question)
                {
                    case "What's your name?":
                        response = "Megan";
                        break;
                    case "How old are you?":
                        response = "3 years old";
                        break;
                    case "Are you a ghost?":
                        response = "Yes and you?";
                        break;
                    case "You want to kill me?":
                        response = "Obviously!";
                        break;
                    case "Are you alive?":
                        response = "I don't know, am I?";
                        break;
                    // Used the bool to end the loop
                    case "EXIT":
                        response = "";
                        running = false;
                        break;
                    default:
                        response = "I don't know that information sorry :(";
                        break;       
                }

                // Response
                Console.WriteLine(response);

            }
        }
    }
}








            