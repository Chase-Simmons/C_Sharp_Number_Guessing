using System;

namespace CsharpIntroApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GetAppInfo();

            //VARS TO BE USED
            string userName;
            int userGuess = 0;
            int correctNumber = new Random().Next(1, 10);

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
                        NotNumber();
                    }

                    userGuess = Int32.Parse(input);

                    if (userGuess != correctNumber)
                    {
                        WrongNumber();
                    }

                }

                CorrectNumber();

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

        static void GetAppInfo()
        {
            //DETAILS
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chase Simmons";

            //STARTUP PREP
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

        }

        static void CorrectNumber()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("You are CORRECT!!!");

            Console.ResetColor();
        }

        static void WrongNumber()
        { 
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Wrong number, please try again!");

            Console.ResetColor();
        }

        static void NotNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Not a number, please try again!");

            Console.ResetColor();
        }
    }
}
