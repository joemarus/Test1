using System;

class Int2Bin
{
    public static void Main()
    {
        Console.WriteLine("Please enter a whole number: ");
        string myInt = Console.ReadLine();
        int total = Int32.Parse(myInt);
        string myBin = "";
        while (total > 1)
        {
            int remainder = total % 2;
            total = total / 2;
            // Console.WriteLine("{0,5} : {1}", total, remainder);
            if (remainder == 1)
            {
                myBin = myBin.Insert(0, "1");
            }
            else
            {
                myBin = myBin.Insert(0, "0");
            }
        }
        if (total == 1)
        {
            myBin = myBin.Insert(0, "1");
        }
        else if (total == 0)
        {
            myBin = myBin.Insert(0, "0");
        }
        Console.WriteLine("The binary number is: {0}", myBin);


        Console.Write("\n\nPress any key to close");
        Console.ReadKey();
    }
}
