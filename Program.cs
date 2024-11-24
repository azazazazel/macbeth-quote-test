using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("" +
    "Welcome to the Macbeth Key Quote Tester \n" +
    "Type the number of the act you would like to be tested on, or \"all\" for all acts. \n" +
    "---------------------------------------------------------------------------------");
        string actchoice = "";
        actchoice = Console.ReadLine();

        if (actchoice == "1")
            Console.WriteLine("" +
                "You have chosen Act " + actchoice, ". \n" +
                "Finish the quote, including punctuation.")
        Console.WriteLine();

        else if (actchoice == "2")
            Console.WriteLine("" +
                "You have chosen Act " + actchoice, ". \n" +
                "Finish the quote, including punctuation.");

        else if (actchoice == "3")
            Console.WriteLine("" +
                "You have chosen Act " + actchoice, ". \n" +
                "Finish the quote, including punctuation.");

        else if (actchoice == "4")
            Console.WriteLine("" +
                "You have chosen Act " + actchoice, ". \n" +
                "Finish the quote, including punctuation.");

        else if (actchoice == "5")
            Console.WriteLine("" +
                "You have chosen Act " + actchoice, ". \n" +
                "Finish the quote, including punctuation.");

        else if (actchoice == "all")
            Console.WriteLine("" +
                "You have chosen All Acts. \n" +
                "Finish the quote, including punctuation.");
        else if (actchoice == "quit")
            Environment.Exit(0);
        else
        {
            Console.WriteLine("" +
                "Please type a number between 1-5, \"all\" or \"quit.\"");
        }
    }
}