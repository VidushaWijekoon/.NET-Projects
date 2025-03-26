
using System;

class ConditionalStatements
{
    public static void Conditions()
    {

        Console.WriteLine("Calculate BMI Using if else conditions");
        Console.Write("Enter Your Height (CM): ");
        double height = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter Your Weight (KG): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        double BMI = weight / (height * height);
        Console.WriteLine($"Your BMI is: {BMI:F2}");

        if (BMI < 16)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Severe Thinness", BMI);
        }
        else if (BMI >= 16 && BMI < 17)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Moderate Thinness", BMI);
        }
        else if (BMI >= 17 && BMI < 18.5)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Mild Thinness", BMI);
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Normal BMI", BMI);
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Overweight", BMI);
        }
        else if (BMI >= 30 && BMI < 35)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Obese Class I", BMI);
        }
        else if (BMI >= 35 && BMI < 40)
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Obese Class II", BMI);
        }
        else
        {
            Console.WriteLine("Your BMI level is {0} - Considered as Obese Class III", BMI);
        }


        Console.ReadLine();

    }
}


