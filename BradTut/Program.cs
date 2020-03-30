using System;

namespace BradTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
            //Declare game Variables
            string appName = "Number Guesser";
            string appVersion = "Version 1.0.0";
            string appAuthor = "Henry Okonkwo";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Write out App info
            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text color
            Console.ResetColor();

            //Ask for a user name
            Console.WriteLine("What is your name?");

            //Get User Input
            string input;

            input = Console.ReadLine();

            // Welcome message
            Console.WriteLine(" Hello {0}, Lets Play a game....", input);

            //Initialize a correct number
            //int correctNumber = 7;
            Random random = new Random();
            int correctNumber = random.Next(1, 11);

            //intialize a guess
            int guess;

            guess = 0;

            //Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber)
            {
                //Get user input
                input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell User its not a number
                    Console.WriteLine("Please enter an actual number");

                    // Reset Text color
                    Console.ResetColor();

                    //Keep going
                    continue;
                }

                //Cast it to int and put it in guess
                guess = Int32.Parse(input);

                //Match guess to the correct number
                if(guess != correctNumber)
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell User its the wrong number
                    Console.WriteLine("Wrong Number, please try again");

                    // Reset Text color
                    Console.ResetColor();
                }
            }

                //Change text color
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                //Tell User its the right number
                Console.WriteLine("You are CORRECT!!!");

                // Reset Text color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play Again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }

            }

        }
    }
}
