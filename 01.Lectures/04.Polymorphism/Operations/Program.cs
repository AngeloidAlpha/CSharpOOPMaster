﻿using Operations;

public class StartUp
{
    public static void Main ()
    {
        MathOperations noNumber = new MathOperations();

        Console.WriteLine(noNumber.Add(2, 3));
        Console.WriteLine(noNumber.Add(2.2, 3.3, 5.5));
        Console.WriteLine(noNumber.Add(2.2m, 3.3m ,4.4m));

    }
}