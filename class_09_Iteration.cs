using System;
using System.Globalization;

class Iteration
{
    public static void Show_Iteration()
    {
        // for Loop
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("For Loop: " + i);
        }

        //While Loop
        int j = 1;
        while (j < 6)
        {
            Console.WriteLine("While Loop: " + j);
            j++;
        }

        // Do While Loop
        //do while 1 bar lazmy run hota hay bager condtion check kiye
        int k = 0;
        do
        {
            Console.WriteLine("Do While Loop: " + k);
            k++;
        }
        while (k > 5);

        // foreach Loop
        string[] names = { "daniyal", "ali", "usman", "sami", "sajid" };
        foreach (string name in names)
        {
            Console.WriteLine("Foreach Loop: " + name);
        }

        //Nested Loops ;
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 2; n++)
            {
                Console.WriteLine("Nested Loop: m=" + m + ", n=" + n);
            }
        }
        

    }
}