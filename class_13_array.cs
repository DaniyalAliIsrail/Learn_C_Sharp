using System;

class LearnArray
{
    public static void ShowArray()
    {
        Console.WriteLine("=== ARRAY BASICS & CREATION ===\n");

        // 1. Basic Array Creation
        int[] num = new int[3];
        num[0] = 10;
        num[1] = 20;
        num[2] = 30;

        Console.WriteLine($"Array elements: {num[0]}, {num[1]}, {num[2]}");
        Console.WriteLine("Length of array: " + num.Length);
        Console.WriteLine("Array type: " + num.GetType());
        Console.WriteLine("Array rank (dimensions): " + num.Rank);

        // 2. Loop through array using foreach
        Console.WriteLine("\nLoop using foreach:");
        foreach (int item in num)
        {
            Console.WriteLine("Element: " + item);
        }

        // 3. Sum of numbers using user input
        Console.WriteLine("\nEnter 3 numbers to calculate sum:");
        int[] numarr = new int[3];
        int sum = 0;
        for (int i = 0; i < numarr.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numarr[i] = Convert.ToInt32(Console.ReadLine());
            sum += numarr[i];
        }
        Console.WriteLine($"Sum of the numbers: {sum}");
        Console.WriteLine(sum == 90 ? "Valid" : "Invalid");

        // 4. Array.Clear() demonstration
        Console.WriteLine("\nArray.Clear() Demo:");
        int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        Array.Clear(values, 5, 3);
        Console.WriteLine("Values after clearing from index 5 (3 elements):");
        foreach (var i in values)
        {
            Console.WriteLine(i);
        }

        string[] names = new string[] { "Ali", "Ahmed", "Sara", "Zain" };
        Array.Clear(names, 1, 2);
        Console.WriteLine("\nNames after clearing index 1-2:");
        foreach (string name in names)
        {
            Console.WriteLine(name ?? "null");
        }

        // 5. Array.IndexOf()
        int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };
        Console.Write("\nEnter a number to find its index: ");
        int search = Convert.ToInt32(Console.ReadLine());
        int position = Array.IndexOf(numbers1, search);

        if (position != -1)
            Console.WriteLine($"Number {search} found at index: {position}");
        else
            Console.WriteLine($"Number {search} not found in array.");

        // 6. Index search using custom for loop
        Console.WriteLine("\nCustom for loop index search:");
        int foundIndex = -1;
        for (int i = 0; i < numbers1.Length; i++)
        {
            if (numbers1[i] == search)
            {
                foundIndex = i;
                Console.WriteLine($"Found at index: {foundIndex}");
                break;
            }
        }
        if (foundIndex == -1)
        {
            Console.WriteLine("Not found");
        }

        // 7. Sorting arrays
        Console.WriteLine("\nArray Sorting:");
        string[] fruits = { "Banana", "Apple", "Mango", "Orange" };
        Console.WriteLine("Before sort: " + string.Join(", ", fruits));
        Array.Sort(fruits);
        Console.WriteLine("After sort (A-Z): " + string.Join(", ", fruits));

        int[] unsortedNums = { 42, 5, 18, 23, 7 };
        Array.Sort(unsortedNums);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", unsortedNums));

        // 8. Reversing arrays
        Console.WriteLine("\nArray Reversing:");
        Array.Reverse(fruits);
        Console.WriteLine("Reversed fruits: " + string.Join(", ", fruits));
        Array.Reverse(unsortedNums);
        Console.WriteLine("Reversed numbers: " + string.Join(", ", unsortedNums));

        // 9. Array initialization techniques
        Console.WriteLine("\nArray Initialization Techniques:");
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = new int[] { 4, 5, 6 };
        var arr3 = new[] { 7, 8, 9 };
        Console.WriteLine("arr1: " + string.Join(", ", arr1));
        Console.WriteLine("arr2: " + string.Join(", ", arr2));
        Console.WriteLine("arr3 (with var): " + string.Join(", ", arr3));
    }
}