using System.Diagnostics;

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
        int result = 0;
        int quotenum = 0;
        int quotemax = 30;
        int quotesdone = 0;
        string judgement;
        string[] quotestart = [
                "Fair is foul, ",
                "The instruments of darkness ",
                "Yet I do fear thy nature; It is too ",
                "Come you spirits that tend ",
                "Look like the ",
                "That we but teach bloody instruction, ",
                "I have no spur to ",
                "False face must ", // eoa1 / 7
                "Had he not resembled ",
                "My hands are of ",
                "A little water ",
                "Most sacrilegious murder ", // eoa2 / 11
                "Nought’s had, ",
                "O, full of  ",
                "Be innocent ",
                "But now I am cabined, ",
                "I am in blood stepped ", // eoa3 / 16
                "Double, double, toil ",
                "Macbeth: beware ",
                "None of ",
                "Macbeth shall never ", // eoa4 / 20
                "Out, damned ",
                "Here’s the smell of the blood still ",
                "More needs she the ",
                "Unnatural deeds ",
                "And that which should accompany old age ",
                "I’ll fight till from my ",
                "I have supped ",
                "Producing forth the cruel ministers of this dead ",
                "Out, Out, brief candle, life’s but a walking shadow, a poor player "]; // eoa5 / 29

        string[] quoteend = [
            "and foul is fair, hover through the fog and filthy air",
            "tell us truths, win us with honest trifles to betray 's in deepest consequence",
            "full o' the milk of human kindness to catch the nearest way",
            "on mortal thoughts, unsex me now, and fill me from crown to the toe top-full of direst cruelty",
            "innocent flower, but be the serpent under 't",
            "which, being taught, return to plague th’ inventor",
            "prick the sides of my intent, but only vaulting ambition",
            "hide what the false heart doth know",
            "my father as he slept, I had done 't",
            "your colour, but I shame to wear a heart so white",
            "clears us of this deed",
            "hath broke ope the Lord's anointed temple, and hence stole the life o'th' building",
            "all's spent, where our desire is got without content",
            "scorpions is my mind, dear wife",
            "of the knowledge, dearest chuck",
            "cribbed, confined, bound by saucy doubts and fears",
            "in so far, that should I wade no more, returning were as tedious as go o'er",
            "and trouble, fire burn and cauldron bubble",
            "the Thane of Fife",
            "woman born shall harm Macbeth",
            "vanquished be, until Great Birnam wood to high Dunsinane hill shall come against him",
            "spot, out, I say",
            "All the perfumes of Arabia will not sweeten this little hand",
            "divine than the physician",
            "do breed unnatural troubles",
            "As honour, love, obedience, troops of friends, I must not look to have, but in their stead curses, not loud but deep, mouth-honour, breath. Which the poor heart would fain deny and dare not",
            "bones my flesh be hacked",
            "full with horrors",
            "butcher and his fiend-like queen",
            "that struts and frets his hour upon the stage and then is heard no more. It is a tale told by an idiot, full of sound and fury, signifying nothing"
            ];

        while (continueLooping == true)
        {
            if (actchoice == "1" || actchoice == "2" || actchoice == "3" || actchoice == "4" || actchoice == "5")
            {
                Console.WriteLine("" +
                    "You have chosen Act " + actchoice + ". \n" +
                    "Finish the quotes (Capitalisation doesn't matter).");
                continueLooping = false;

                if (actchoice == "1")
                {
                    Process.Start("http://www.google.com");
                    quotenum = 0;
                    quotemax = 7;
                }
                else if (actchoice == "2")
                {
                    quotenum = 8;
                    quotemax = 11;
                }

                else if (actchoice == "3")
                {
                    quotenum = 12;
                    quotemax = 16;
                }

                else if (actchoice == "4")
                {
                    quotenum = 17;
                    quotemax = 20;
                }

                else if (actchoice == "5")
                {
                    quotenum = 21;
                    quotemax = 30;
                }
            }


            else if (actchoice == "all")
            {
                Console.WriteLine("" +
                    "You have chosen all Acts. \n" +
                    "Finish the quotes (Capitalisation doesn't matter).");
                continueLooping = false;
                quotenum = 0;
                quotemax = 30;
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

        while (quotenum < quotemax)
        {
            quotesdone++;
            Console.WriteLine("#" + quotesdone + ":" + quotestart[quotenum]);
            string answer = Console.ReadLine()!;
            if (answer.ToLower() == "menu" || answer.ToLower() == "reset" || answer.ToLower() == "reload" || answer.ToLower() == "quit")
                Main();
            if (answer.ToLower() == quoteend[quotenum].ToLower())
            {
                result++;
            }
            else
            {
                Console.WriteLine(quotestart[quotenum] + quoteend[quotenum]);
            }
            quotenum++;
        }

        if (result == quotesdone)
            judgement = "Perfect, Congratulations!";
        else if (result == 0)
            judgement = "damnnn you suck lol";
        else
            judgement = "Pretty good, but you can do better!!";


        if (quotenum >= quotemax)
        {
            Console.WriteLine("Quote test finished. Result: " + result + "/" + quotesdone + ". " + judgement + "\n" +
                "Try again? \n" +
                "Yes/No");
            string tryagain = Console.ReadLine()!;
            if (tryagain.ToLower() == "yes")
                Main();
            else
                System.Environment.Exit(0);
        }
    }
}