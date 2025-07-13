using System;
using System.Globalization;
class Dictionary_practice
{
    public static void show_dict_practice()
    {
        // create odd list
        List<int> odd = new List<int>();
        List<int> even = new List<int>();

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);

            }
        }

        foreach (var item in even)
        {
            Console.WriteLine($"even no {item}");
        }

        foreach (var item in odd)
        {
            Console.WriteLine($"odd no {item}");
        }

        //create a array and array may value table k form m hogy

        int num = 7;
        int length1 = 5;
        int[] result = new int[length1];
        for (int i = 0; i <= result.Length - 1; i++)
        {
            result[i] = num * i;
        }
        Console.WriteLine(result);

        // Print result
        foreach (int value in result)
        {
            Console.WriteLine(value);
        }

    }
}