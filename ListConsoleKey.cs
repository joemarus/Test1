using System;

public class ListConsoleKey
{
    public static void Main()
    {
        //
        // This program outputs a list of all the key names that are in
        // the ConsoleKey enumeration.  It also prints out what the value of each
        // key is when it is converted to an integer.
        //
        // First, we get an array of all the names.
        string[] keynames = Enum.GetNames(typeof(ConsoleKey));

        // Now we will loop through each name in the array.
        foreach (string keyname in keynames)
        {
            // This statement creates a ConsoleKey object depending on the value of keyname.
            ConsoleKey key = (ConsoleKey) Enum.Parse(typeof(ConsoleKey),keyname);
            // This statement formats the output using the optional width parameter on the first format item.
            Console.WriteLine("{0,5} : {1}", (int)key, keyname);
        }
        Console.Write("\n\nPress any key to close");
        Console.ReadKey();
    }
}
