using System;

//Namespace
namespace NumberGuesser
{
//Main class
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brittani Court";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // write out app info
            Console.WriteLine("{0}:Version {1} by {2}", appName, appVersion, appAuthor);
            // reset text color
            Console.ResetColor();
            Console.WriteLine("Goodbye");
        }
    }
}

