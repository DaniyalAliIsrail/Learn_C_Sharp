using System;
using System.Globalization;


class TryPraseMethod
{
    public static void Show_TryParse()
    {
        Console.WriteLine("TryParse Method ");

        // Definition(Roman Urdu):
        // TryParse ek method hoti hai jo string ko number(ya kisi aur type) mein convert karti hai bina program crash kiye.
        // Agar conversion successful ho jaye to=> true return karta hai
        // converted value ko out variable mein store karta hai Agar conversion fail ho jaye to => false return karta hai

        Console.WriteLine("Enter a number");
        string num_input = Console.ReadLine();
        int number = 0;
        bool result = int.TryParse(num_input, out number);
        if (result)
        {
            Console.WriteLine($"Conversion successful: {number}");
        }
        else
        {
            Console.WriteLine("Conversion failed.");
        }

        //Example

        bool success = true;

        while (success)
        {
            Console.WriteLine("Enter a number:");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int parsedNumber))
            {
                success = false;
                Console.WriteLine($"Parsed number: {parsedNumber}");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }
        }

        // Example : Parsing a DateTime
        // string dateString = "2023-10-01";
        // if (DateTime.TryParse(dateString, out DateTime dateValue))
        // {
        //     Console.WriteLine($"Parsed DateTime: {dateValue}");
        // }
        // else
        // {
        //     Console.WriteLine("Failed to parse DateTime.");
        // }
    }
}