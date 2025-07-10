using System;

class CondtionStatement
{
    public static void condtionState_if_ifelse_else()

    {
        //Question:
        // Write a C# program that:
        // Asks the user to enter their age.
        // Asks the user to enter their marks out of 100.
        // Based on the inputs, apply the following conditions:
        // If the age is greater than 18 AND marks are greater than or equal to 50, print:
        // "You are eligible for the test."
        // If the age is 18 or less AND marks are greater than or equal to 50, print:
        // "You are too young, but your marks are good."
        // If the age is greater than 18 AND marks are less than 50, print:
        // "You are old enough, but need to improve your marks."
        // Otherwise, print:
        // "You are not eligible currently."
        // Then, check scholarship eligibility using the following condition:
        // If marks are greater than or equal to 90 OR age is less than 20, print:
        // "You are eligible for scholarship."
        // Otherwise, print:
        // "You are not eligible for scholarship."


        Console.WriteLine("Enter Your Age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Your Marks:");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (age > 18 && marks >= 50)
        {
            Console.WriteLine("You are eligible for the test");
        }

        else if (age <= 18 && marks >= 50)
        {
            Console.WriteLine("You are too young, but your marks are good.");
        }

        else if (age > 18 && marks < 50)
        {
            Console.WriteLine("You are old enough, but need to improve your marks.");
        }
        else
        {
            Console.WriteLine("You are not eligible currently.");
        }
        // Additional example with logical OR (||)
        Console.WriteLine("\nChecking scholarship eligibility...");

        if (marks >= 90 || age < 20)
        {
            Console.WriteLine("You are eligible for scholarship.");
        }
        else if (marks >= 90 || age < 20)
        {
            Console.WriteLine("You are eligible for scholarship.");
        }
        else
        {
            Console.WriteLine("You are not eligible for scholarship.");
        }


        //CONDITIONAL OPERATORS
        // Conditional operators are used to evaluate conditions and return values based on the evaluation.
        // The most common conditional operator is the ternary operator (?:), which is a shorthand way of writing an if-else statement.
        // It takes three operands: a condition, a value if the condition is true, and a value if the condition is false.
        // Here's an example:

        int number = 10;
        //condtion ? true : false
        string result = (number > 0) ? "Positive" : "Negative";
        Console.WriteLine("The number is: " + result);

    }
}