using System;
internal class Program
{
    private static void Main()
    {
        Console.WriteLine("" +
            "Welcome to the Macbeth Key Quote Tester \n" +
            "Type the number of the act you would like to be tested on, or \"all\" for all acts. \n" +
            "If you want to quit, type \"quit\". \n" +
            "---------------------------------------------------------------------------------");
        string actchoice = Console.ReadLine()!;
        bool continueLooping = true;
        int result;

        while (continueLooping == true)
        {
            if (actchoice == "1")
            {
                Console.WriteLine("" +
                    "You have chosen Act " + actchoice, ". \n" +
                    "Finish the quotes, including punctuation.");
                continueLooping = false;
            }
            else if (actchoice == "2")
            {
                Console.WriteLine("" +
                    "You have chosen Act " + actchoice, ". \n" +
                    "Finish the quotes, including punctuation.");
                continueLooping = false;
            }

            else if (actchoice == "3")
            {
                Console.WriteLine("" +
                    "You have chosen Act " + actchoice, ". \n" +
                    "Finish the quotes, including punctuation.");
                continueLooping = false;
            }

            else if (actchoice == "4")
            {
                Console.WriteLine("" +
                    "You have chosen Act " + actchoice, ". \n" +
                    "Finish the quotes, including punctuation.");
                continueLooping = false;
            }

            else if (actchoice == "5")
            {
                Console.WriteLine("" +
                    "You have chosen Act " + actchoice, ". \n" +
                    "Finish the quotes, including punctuation.");
                continueLooping = false;
            }

            else if (actchoice == "all")
            {
                Console.WriteLine("" +
                    "You have chosen all Acts. \n" +
                    "Finish the quotes, including punctuation.");
                continueLooping = false;
            }

            else if (actchoice == "milk")
            {
                Console.WriteLine("" +
                    "lady macbeth milkies...");
            }

            else if (actchoice == "quit")
            {
                continueLooping = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("" +
                    "Please type a number between 1-5, \"all\" or \"quit.\"");
                actchoice = Console.ReadLine()!;
            }
        }

    }
}