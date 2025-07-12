using System;
using System.Linq;
class ArrayPractice
{
    public static void show_array_practice()
    {
        int[] numbers = new int[] { 1, 8, 3, 7, 2, 4, 5, 3, };

        Array.Sort(numbers);
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        int[] numbers1 = { 5, 2, 8, 2, 3, 5, 1 };

        // Step 1: Remove duplicates using Distinct
        int[] uniqueNumbers = numbers1.Distinct().ToArray();
        Array.Sort(uniqueNumbers);

        //Print result
        Console.WriteLine("Sorted unique numbers:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(" sorted AND unique numbers: ");
            Console.WriteLine(num);
        }

        

    }
}