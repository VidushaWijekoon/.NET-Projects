using System;

class Arrays
{
    public static void ArrayList()
    {
        // Array giveen length
        string[] prices = new string[4] { "2.5", "1.75", "8.15", "2.215" };
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] numbers = { 2, 4, 6, 8, 23, 345, 5462, 132, 354, 756, 897, 34546, 23 };

        Console.WriteLine(prices.Length);
        // Access individual numbers
        Console.WriteLine(cars[0]);

        Array.Sort(numbers);
        // Sort Numbers
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        };

        for (int x = 0; x < cars.Length; x++)
        {
            Console.WriteLine(cars[x]);
        };

        Console.ReadLine();
    }
}

