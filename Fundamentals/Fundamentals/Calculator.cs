
using System;
class Calculator
{
    public static void Calc()
    {
        Console.Clear();
        Console.Write("Add First Number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Add Second Number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter Operator +, -, *, /");
        string oper = Console.ReadLine();

        double total;

        switch (oper)
        {
            case "+":
                total = num1 + num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, total);
                break;
            case "*":
                total = num1 * num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, total);
                break;
            case "/":
                total = num1 / num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, total);
                break;
            case "-":
                total = num1 + num2;
                Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, total);
                break;
            default:
                Console.WriteLine("Invalid Operator or Value");
                break;
        }
    }
}

