using System;

class LearnArray
{
    public static void ShowArray()
    {
        int[] num = new int[3];
        num[0] = 10;
        num[1] = 20;
        num[2] = 30;
        Console.WriteLine($"Array elements:{num[0]}, {num[1]}, {num[2]}");
        Console.WriteLine("Length of array: " + num.Length);
        Console.WriteLine("Array type: " + num.GetType());
        Console.WriteLine("Array rank: " + num.Rank);//rank define the dimenion of the array

        //loop through the array using for loop and foreach loop
        // for (int i = 0; i < num.Length; i++)
        // {
        //     Console.WriteLine($"Element at index {i}: {num[i]}");
        // }

        foreach (int item in num)
        {
            Console.WriteLine($"Element in foreach loop: {item}");
        }
        //sum of numbers in an array
        int[] numarr = new int[3];
        int sum = 0;
        for (int i = 0; i < numarr.Length; i++)
        {
            Console.WriteLine($"Enter a Number");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            sum += usernumber;
        }
        Console.WriteLine($"Sum of the numbers: {sum}");
        Console.WriteLine(sum == 90 ? "valid" : "invalid");

        // Array.Clear(numbers1, 0, numbers1.Length);
        // Array.Clear() is a built-in method in C# used to remove (reset) all   the elements of an array by setting them to their default values.

        // Array.Clear() array ko delete nahi karta, sirf us ke elements ko default value (like 0 ya null) par set karta hai.
        //  Array ka size wahi rehta hai.

        int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        Array.Clear(values, 5, 3);
        foreach (var i in values)
        {
            Console.WriteLine(i);
        }

        //Example
        string[] names = new string[] { "Ali", "Ahmed", "Sara", "Zain" };
        Array.Clear(names, 1, 2);

        // Output: Ali, null, null, Zain
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //IndexOf()
        //Array.IndexOf() method C# mein kisi array mein kisi specific element ki index position ko dhoondne ke liye istemal hota hai.
        // Ye method array mein pehli dafa milne wale element ki index position return karta

        Console.WriteLine("Using for loop to find index:");

        int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };
        Console.WriteLine("Enter a number to find its index using builtin method");
        int search = Convert.ToInt32(Console.ReadLine());
        int position = Array.IndexOf(numbers1, search);
        if (position != -1)
        {
            Console.WriteLine($"Number {search} found at index: {position}");
        }
        else
        {
            Console.WriteLine($"Number {search} not found in the array.");
        }
        //same example using for loop not use any built-in method
        Console.WriteLine("Using for loop to find index:");
        int positionArr = -1;
        for (int i = 0; i <= numbers1.Length - 1; i++)
        {
            if (numbers1[i] == search)
            {
                positionArr = i;
                Console.WriteLine($"Number {search} found at index: {positionArr}");
                break; // Exit the loop once the number is found
            }
            else
            {
                positionArr = -1;
                Console.WriteLine($"Number {search} not found in the array.{positionArr}");
            }

        }

    }

}
