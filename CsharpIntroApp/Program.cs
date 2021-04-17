using System;

namespace CsharpIntroApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chase Simmons";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
    }
}
