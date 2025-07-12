using System;
using System.ComponentModel;

class LearnFunction
{
    public static void show_function()
    {
        // Function in C# (Complete Beginner Guide)
        // In C#, a function (also called a method) is a block of code that performs a task. You write it once and can use (call) it multiple times.
        createAndprintArray();
        int result = Addition(2, 2);
        Console.WriteLine(result);

        int saveInput = prntNum();
        Console.WriteLine(saveInput);

        Console.WriteLine("Enter a first name:");
        string name1 = Console.ReadLine();

        Console.WriteLine("Enter a last name:");
        string name2 = Console.ReadLine();

        // Function call with input values
        Console.WriteLine(Intro(name1, name2));

        ShowProfile(name: "daniyal", age: 25, city: "karachi");
        //out parameter
        int resultSum, resultProduct;
        // Call the function using out parameters
        Calculate(4, 5, out resultSum, out resultProduct);

        Console.WriteLine("Sum: " + resultSum);         // 9
        Console.WriteLine("Product: " + resultProduct); // 20

    }
    //void function 
    static void createAndprintArray()
    {
        int[] genNum = new int[] { 1, 2, 3, 4, 5 };
        foreach (var item in genNum)
        {
            Console.WriteLine($"{item}");
        }

    }

    // return function
    static int Addition(int a, int b)
    {
        return a + b;
    }
    //Enter a number and print
    static int prntNum()
    {
        Console.WriteLine("Enter a number");
        return Convert.ToInt32(Console.ReadLine());
    }

    //. Optional Parameters
    // Optional parameters have default values. If you don’t pass a value, the default will be used.

    static string Intro(string firstName = "John", string lastName = "Doe")
    {
        return firstName + " " + lastName;
    }

    //named parameter
    static void ShowProfile(string name, int age, string city)
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    //What is an out Parameter in C#?
    // An out parameter is used to return multiple values from a function.
    // Unlike return, which returns only one value, out allows extra values to be returned through parameters.
    // You must assign a value to out parameters inside the method.


    static void Calculate(int a, int b, out int sum, out int product)
    {
        sum = a + b;         // Assigning value to out parameter
        product = a * b;     // Assigning value to out parameter
    }

}