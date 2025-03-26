using System;

class MultiplicationTable
{
    public static void Table()
    {
        Console.WriteLine("<h1>---------Multiplication>---------</h1>");

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("Number {0}", i);
            Console.WriteLine(" ");
            for (int j = 1; j <= 12; j++)
            {
                Console.WriteLine(i + "x" + j + "=" + i * j);
            }
        }
    }
}

