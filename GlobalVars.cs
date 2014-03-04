using System;

class GlobalVars
{
    static int Test = 1;

    static void Main()
    {
        Console.WriteLine("The value of Test is {0}.", Test);
        MyFunc();
        Console.WriteLine("After calling MyFunc, the value of Test is {0}.", Test);
        
        Console.Write("\n\nPress any key to close");
        Console.ReadKey();
    }

    static void MyFunc()
    {
        Console.WriteLine("Inside of MyFunc, Test is {0}", Test);
        Test = 5;  // Let's see if I can change its value
    }
}
