using System;

class Iteration_practice_question
{
    public static void Show_Iteration_practice()
    {
        // // Guess the number using while loop
        // Console.WriteLine("Guess the number");
        // int rightNumber = 90;
        // int userInput1, userInput2, multiplication;
        // while (true)

        // {

        //     Console.WriteLine("Enter your first Number");
        //     userInput1 = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Enter your second Number");
        //     userInput2 = Convert.ToInt32(Console.ReadLine());

        //     multiplication = userInput1 * userInput2;
        //     if (multiplication == rightNumber)
        //     {
        //         Console.WriteLine("You guessed it right!");
        //         break; // Exit the loop if the guess is correct
        //     }

        //     else if (multiplication < rightNumber)
        //     {
        //         Console.WriteLine("Your number is so close. Try again.");
        //     }
        //     else if (multiplication > rightNumber)
        //     {
        //         Console.WriteLine("Your number is so far. Try again.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it right!");
        //     }
        // }

        // //Print the table of user input number
        // Console.WriteLine("Enter a number to print its table:");
        // int userInput = Convert.ToInt32(Console.ReadLine());
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"{userInput} x {i} = {userInput * i}");

        // }

        // bool threeDiv = false;
        // bool fiveDiv = false;

        // for (int i = 1; i <= 24; i++)
        // {
        //     threeDiv = i % 3 == 0;
        //     fiveDiv = i % 5 == 0;

        //     if (threeDiv && fiveDiv)
        //     {
        //         Console.WriteLine("FizzBuzz");
        //     }
        //     else if (threeDiv)
        //     {
        //         Console.WriteLine("Fizz");
        //     }
        //     else if (fiveDiv)
        //     {
        //         Console.WriteLine("Buzz");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        //string iteration using loop

        string str = "daniyal ali is senior software engineer";
        for (int i = 0; i < str.Length - 1; i++)
        {
            Console.WriteLine(str[i]);
            Thread.Sleep(110);
        }
        Console.WriteLine(str.Contains("ali")); //true

        // reverse string using for loop
        string reverseStr = "daniyal";
        for (int r = reverseStr.Length - 1; r >= 0; r--)
        {
            Console.WriteLine(reverseStr[r]);
            // Thread.Sleep(110);
        }

    }
}