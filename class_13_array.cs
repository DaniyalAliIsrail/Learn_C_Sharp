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
        Console.WriteLine("Array rank: " + num.Rank);
        // Console.WriteLine("Array is of type: " + num.GetType().Name);
        // Console.WriteLine("Array is of type: " + num.GetType().FullName);
    }
}