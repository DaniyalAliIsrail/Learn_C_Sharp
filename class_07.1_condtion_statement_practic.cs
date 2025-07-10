using System;

class ConditionStatement_practice
{
    public static void show_conditionState()
    {
        Console.WriteLine("Enter a Password:");
        var password = Console.ReadLine();
        Console.WriteLine(password);
        Console.WriteLine("Enter a Password again:");
        var againPassword = Console.ReadLine();
        Console.WriteLine(againPassword);

        if (!password.Equals("") && !againPassword.Equals(""))
        {
            if (password.Length >= 6 && againPassword.Length >= 6)
            {
                if (password.Equals(againPassword))
                {
                    Console.WriteLine("Password is match correct.");
                }
                else
                {
                    Console.WriteLine("Password does not match. Please try again.");
                }

            }
            else
            {
                Console.WriteLine("Password length must be at least 6 characters.");
            }
        }
        else
        {
            Console.WriteLine("Password cannot be empty. Please enter a valid password.");
        }
    }
}