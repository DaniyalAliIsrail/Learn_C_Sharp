using System;
class InputOutput
{
    public static void show_InputOutputfromUser()
    {
        Console.WriteLine("Enter your name:");
        string? nameInput = Console.ReadLine();
        string name = nameInput ?? string.Empty;
        Console.WriteLine("Hello, " + name + "!");

        Console.WriteLine("Enter your Father's name:");
        string? fatherNameInput = Console.ReadLine();
        string fatherName = fatherNameInput ?? string.Empty;
        Console.WriteLine("Hello, " + fatherName + "!");

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are " + age + " years old.");
    }
}