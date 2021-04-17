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
            int correctNumber = 7;


            //STARTUP PREP
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //SEEK RES
            Console.Write("What is your name? : ");

            //GRAB RES
            userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);

            Console.Write("Guess a number between 1 and 10 : ");


           while (userGuess != correctNumber)
            {
                string input = Console.ReadLine();

                userGuess = Int32.Parse(input);

                if(userGuess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong number, please try again!");
                }
                    Console.ResetColor();

            }
        }
    }
}
