using System;

// From Traversy Media YouTube channel. https://www.youtube.com/watch?v=GcFJjpMFJvI

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Get app info

            GreetUser(); // 

            while (true) { 
            // Init correct number

                // Create a new Random object
                Random random = new Random();

                // Make the correct number a number between 1 and 10
                int correctNumber = random.Next(1, 10);


                // Init guess var
                int guess = 0;

                // Ask user to guess number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct number
                while(guess != correctNumber)
                {
                    // Get user input
                    string inputNumber = Console.ReadLine();

                    // Make sure it's a number
                    if(!int.TryParse(inputNumber, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Not a number, enter an actual number.");


                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set up variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "henrik3";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Get name and greet user
        static void GreetUser()
        {
            // Ask for users name
            Console.WriteLine("What is your name?");

            // User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
