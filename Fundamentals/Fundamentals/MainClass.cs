using System;

namespace Fundamentals
{
    internal class MainClass
    {
        public static void Main()
        {
            int userInputConverUserInput = UserInput();

            switch (userInputConverUserInput)
            {
                case 1:
                    // Console.WriteLine("C# Data Types");
                    // List of Data Types in C# .NET
                    DataTypes.ListOfDataTypes();
                    break;
                case 2:
                    // Console.WriteLine("C# Conditions (if else)");
                    // C# Conditions (if else)
                    ConditionalStatements.Conditions();
                    break;
                case 3:
                    // Console.WriteLine("C# forloops and foreach");
                    // Create Calculator using Switch Statement and Operators
                    Calculator.Calc();
                    break;
                case 4:
                    // Console.WriteLine("C# Arrays");
                    Arrays.ArrayList();
                    break;
                case 5:
                    // Console.WriteLine("C# while loops");
                    WorkingWithStrings.StringClass();
                    break;
                case 6:
                    Console.WriteLine("C# strings");
                    break;
                case 7:
                    // Date Time Formats
                    // Console.WriteLine("C# data and timings");
                    WorkingWithDateAndTime.time();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }

        public static int UserInput()
        {
            Console.Clear();
            Console.WriteLine("--- Please Enter Option---");
            Console.WriteLine("1) C# .NET Data Types: ");
            Console.WriteLine("2) C# .NET Conditions (if else): ");
            Console.WriteLine("3) C# .NET Switch statement and Operator Basic Calculator: ");
            Console.WriteLine("4) C# .NET Arrays: ");
            Console.WriteLine("5) C# .NET strings: ");
            Console.WriteLine("6) C# .NET while loops: ");
            Console.WriteLine("7) C# .NET data and timings: ");
            string chooseNumber = Console.ReadLine();
            int converUserInput = int.Parse(chooseNumber);

            return converUserInput;
        }
    }
}
