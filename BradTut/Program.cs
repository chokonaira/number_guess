using System;

namespace BradTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                GetGameInfo();

                GetUserInfo();
                //Initialize a correct number
                //int correctNumber = 7;
                int correctNumber = RandomNumber();

                //intialize a guess
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while(guess != correctNumber)
                {
                //Get user input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        GameColor(ConsoleColor.Red, "Please enter an actual number");

                        //Keep going
                        continue;
                    }

                    //Cast it to int and put it in guess
                    guess = Int32.Parse(input);

                    //Match guess to the correct number
                    if(guess != correctNumber)
                    {
                            GameColor(ConsoleColor.Red, "Wrong Number, Please try again");
                    }
                }

                    GameColor(ConsoleColor.DarkYellow, "You are CORRECT!!!");

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

        static void GetGameInfo()
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
        }

        static void GetUserInfo()
        {
            //Ask for a user name
            Console.WriteLine("What is your name?");

            //Get User Input
            string input = Console.ReadLine();

            // Welcome message
            Console.WriteLine(" Hello {0}, Lets Play a game....", input);

        }
        static void GameColor(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell User its the wrong number
            Console.WriteLine(message);

            // Reset Text color
            Console.ResetColor();
        }
        static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }
    }
}
