using System;

public class MyProg
{
    // This program is a simaple guessing game that has examples
    // of loops, if statements, and functions.
    //
    public static void Main()
    {
        // These next two lines set up a random number generator
        // and get a random number between 0 and 10 and put it in the "answer"
        // variable.  To get more details about the Random class,
        // put your cursor on it in Visual Studio and press F1.
        Random rnd = new Random();
        int answer = rnd.Next(10);

        Console.WriteLine("Guess a number between 0 and 10.");
        string line = Console.ReadLine();
        int x = CheckInput(line);  // This is a call to a function defined below
        while (x != answer)
        {
            if (x > answer)
            {
                Console.WriteLine("You are too high.  Try again.");
            }
            else
            {
                Console.WriteLine("You are too low.  Try again.");
            }
            line = Console.ReadLine();
            x = CheckInput(line);
        }
        Celebrate("You Got It!");  // this is another call to a function defined below
        Console.Write("\n\nPress any key to close");
        Console.ReadKey();
    }

    private static int CheckInput(string str)
    {
        //
        // This function checks the input to make sure it is a number.
        // It will keep looping until the user inputs an integer, and it
        // returns that integer back to the caller.
        //
        int temp;
        while (!Int32.TryParse(str, out temp))
        {
            Console.WriteLine("That is not a number, silly.  Try again.");
            str = Console.ReadLine();
        }
        return temp;
    }

    private static void Celebrate(string str)
    {
        //
        // This function prints out a message and makes it flash by changing the
        // color very quickly lots and lots of times.  It uses the CursorLeft
        // property to put the cursor back to the start of the line so that you
        // keep writing the text over and over itself.
        //
        for (int x = 0; x < 5000; x++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(str);
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(str);
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(str);
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(str);
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(str);
            Console.CursorLeft = 0;
        }
        Console.ResetColor();  // put the color back to normal

    }
}
