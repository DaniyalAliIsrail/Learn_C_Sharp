using System;

class SwitchCase
{
    public static void Show_switchCase()
    {
        // switch-case C# ka aik control statement hai jo kisi aik variable ya expression ki value ko check karta hai aur us value ke hisaab se koi 
        // specific code block chalata hai.
        // Agar kisi case ka value variable se match karta hai, to us case ka code execute hota hai.
        // Agar koi bhi case match nahi karta, to default block run hota hais.

        Console.WriteLine("Enter a Weekday (1-7):");
        int day = Convert.ToInt32(Console.ReadLine());

        // if (day == 1)
        // {
        //     Console.WriteLine("Monday");
        // }
        // else if (day == 2)
        // {
        //     Console.WriteLine("Tuesday");
        // }
        // else if (day == 3)
        // {
        //     Console.WriteLine("Wednesday");
        // }
        // else if (day == 4)
        // {
        //     Console.WriteLine("Thursday");
        // }
        // else if (day == 5)
        // {
        //     Console.WriteLine("Friday");
        // }
        // else if (day == 6)
        // {
        //     Console.WriteLine("Saturday");
        // }
        // else if (day == 7)
        // {
        //     Console.WriteLine("Sunday");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid day");
        // }
        //SWITCH CASE
        // all the conditional statement code convert into switch case
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("thursday");
                break;
            case 5:
                Console.WriteLine("friday");
                break;
            case 6:
                Console.WriteLine("saturday");
                break;
            case 7:
                Console.WriteLine("sunday");
                break;
            case 700:
                Console.WriteLine("hello daniyal");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

    }
}

