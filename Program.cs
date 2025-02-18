﻿using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
           //Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo(); // Run GetAppInfo function

            GreetUser(); // Ask for users name greet

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Input number only!!");

                        // Keep going 
                        continue;
                    }


                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print Error message
                        PrintColorMessage(ConsoleColor.DarkGray, "Wrong number, please try again");
                    }

                }

                // Print Success message
                PrintColorMessage(ConsoleColor.DarkYellow, "Good job on guessing the number");

                // Ask to play again 
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer =="N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }


        /* add function to refactor code on top */ 

        // Get and display app info  
        static void GetAppInfo()
        {
            // Set app vars
            var appName = "Number Guesser";
            var appVersion = "1.0.0";
            var appAuthor = "Andy Dang";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color 
            Console.ResetColor();
        }

        //Ask users name and greet 
        static void GreetUser()
        {
            // Ask the user name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message )
        {
            //Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
