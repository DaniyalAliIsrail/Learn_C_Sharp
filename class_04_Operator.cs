using System;
class OperatorInCSharp
{
    public static void Show_Operator()
    {
        Console.WriteLine("Operator");

        int num1 = 20;
        int num2 = 10;
        Console.WriteLine("Adding of two Number: " + (num1 + num2));
        Console.WriteLine("Subtraction of two Number: " + (num1 - num2));
        Console.WriteLine("Multiplication of two Number: " + (num1 * num2));
        //Division
        Console.WriteLine("Division of two Number: " + (num1 / num2));
        Console.WriteLine("Division of two Number: " + (num1 /= 3));
        //Modules
        Console.WriteLine("Modulus of two Number: " + (num1 % num2));

    }
}
