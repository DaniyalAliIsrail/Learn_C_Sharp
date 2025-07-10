using System;
class DataTypes
{
    public static void ShowTypes()
    {
        int age = 20;
        double height = 5.9;
        char initial = 'A';
        string name = "Alice";
        bool isStudent = true;

        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height is: " + height);
        Console.WriteLine("Initial: " + initial);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Is Student: " + isStudent);

        //input user from userName and print userName
        Console.WriteLine("Enter your name:");
        // string userNameInput = Console.ReadLine();
        // string userName = userNameInput ?? string.Empty; 
        // Console.WriteLine("Hello, " + userName + "!");
    }
}