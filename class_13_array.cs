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

    }
}