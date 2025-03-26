using System;

class WorkingWithStrings
{
    public static void StringClass() {

        string myString = @"access to my c:\ drive";
        Console.WriteLine(myString);

        Console.WriteLine(string.Format("Add Currency Dollor: {0:C}", 123.45));
        Console.WriteLine(string.Format("Adding Comma Separator: {0:N}", 123654654886513));
        Console.WriteLine(string.Format("Precentage: {0:P}", .45));
        Console.WriteLine(string.Format("Phone Number : {0:(###) ### ####}", 123456789));

        string sentence = "  The summber we took threes across the board   ";
        Console.WriteLine("Remove White Spaces in String: ", sentence.Trim());
        Console.WriteLine("Text Transform: ", sentence.ToUpper());
        Console.WriteLine("Read Between 5 to 10: ", sentence.Substring(5, 10));
        Console.WriteLine("Remove Between 5 to 10: ", sentence.Remove(5, 10));
        Console.WriteLine("Lenth before triming {0} and after trim {1}", sentence.Length, sentence.Trim().Length);

        Console.ReadLine();
    }

}

