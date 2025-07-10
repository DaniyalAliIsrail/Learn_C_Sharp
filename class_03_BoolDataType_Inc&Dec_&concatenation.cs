using System;
class BooleanDataTypes
{
    public static void Show_BoolDataTypes()
    {
        Console.WriteLine("Boolean Data Types");

        bool isTrue = true;
        bool isFalse = false;

        Console.WriteLine("isTrue: " + isTrue);
        Console.WriteLine("isFalse: " + isFalse);

        // Boolean operations
        bool andOperation = isTrue && isFalse; // AND operation
        bool orOperation = isTrue || isFalse;  // OR operation
        bool notOperation = !isTrue;            // NOT operation

        Console.WriteLine("AND Operation (isTrue && isFalse): " + andOperation);
        Console.WriteLine("OR Operation (isTrue || isFalse): " + orOperation);
        Console.WriteLine("NOT Operation (!isTrue): " + notOperation);

        //Increment OR decrement Operator
        int age = 25;
        Console.WriteLine("Initial Age: " + age);

        // Increment Operator
        age++; // increment by 1 only
        Console.WriteLine("Age after Increment: " + age);
        // age += 10; age = age + 40; Both are valid 

        age += 20;  // <-- Compound Assignment Operators increment by 20
        Console.WriteLine("Age after adding 20: " + age);
        age = age + 20; // increment by 40
        Console.WriteLine("Age after adding 40: " + age);

        // Decrement Operator
        int marks = 100;
        Console.WriteLine("Marks after Decrement: " + marks);
        marks--; // decrement by 1 only
        Console.WriteLine("Marks after Decrement: " + marks);
        marks -= 10; // decrement by 10
        Console.WriteLine("Marks after subtracting 10: " + marks);
        marks = marks - 20; // decrement by 20

        //CONCATENATION
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName; // Concatenation using +
        Console.WriteLine("Full Name: " + fullName);

        string name = "daniyal";
        name += "Ali"; // Concatenation using +=
        Console.WriteLine("Concatenated Name: " + name);
    }
}