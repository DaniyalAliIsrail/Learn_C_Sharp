using System;
using System.Formats.Asn1;
class Function_Practice
{
    static int[] arrNum = new int[10];

    public static void show_functionPractice()
    {
        int result = calAreaOfTriangle(10, 15);
        Console.WriteLine($"the area of triangle is {result}");


        for (int i = 1; i < arrNum.Length; i++)
        {
            arrNum[i] = i;
        }
        foreach (var item in arrNum)
        {
            Console.WriteLine($"arr value{item}");
        }

        int sumofarrauresult = SumOfArr(arrNum);
        Console.WriteLine(sumofarrauresult);

    }

    static int calAreaOfTriangle(int widht, int height)
    {
        int area = widht * height / 2;
        return area;
    }



    static int SumOfArr(int[] arrNum)
    {
        int sum = 0;
        for (int i = 0; i < arrNum.Length; i++)
        {
            sum += arrNum[i];  // Add each element
        }
        return sum;
    }
}