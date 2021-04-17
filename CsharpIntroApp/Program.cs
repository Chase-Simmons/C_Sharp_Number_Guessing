using System;

namespace CsharpIntroApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DETAILS
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chase Simmons";

            //VARS TO BE USED
            string userName;
            int userGuess = 0;
            int correctNumber = new Random().Next(1, 10);


            //STARTUP PREP
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.Write("What is your name? : ");

            userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);

            while (true)
            {

                Console.Write("Guess a number between 1 and 10 : ");


                while (userGuess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out userGuess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Not a number, please try again!");

                        Console.ResetColor();
                    }

                    userGuess = Int32.Parse(input);

                    if (userGuess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong number, please try again!");

                        Console.ResetColor();
                    }

                }

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You are CORRECT!!!");

                Console.ResetColor();

                Console.Write("Play Again? [Y or N] : ");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    userGuess = 0;
                    continue;
                } else if (answer == "N") {
                    return;
                }
            }
        }
    }
}
