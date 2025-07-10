using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.InteropServices;
class Formating
{
    public static void Show_Formatting()
    {
        //What is Numeric Formatting?
        //Numeric formatting is a way to control how numbers appear when printed, such as rounding, adding currency symbols,   setting decimal places, etc.

        Console.WriteLine("String Formatting Examples:");

        double value = 1000D / 12.34D;
        Console.WriteLine(value); // Full double value
        Console.WriteLine(string.Format("{0:0}", value));      // Round off (no decimals)
        Console.WriteLine(string.Format("{0:0.0}", value));    // One decimal place
        Console.WriteLine(string.Format("{0:0.00}", value));   // Two decimal places
        Console.WriteLine(string.Format("${0:0.00}", value));  // Two decimal + $ symbol

        double money = -10D / 3D;
        Console.WriteLine(money);
        Console.WriteLine("{0:0.00}", money);
        Console.WriteLine(money.ToString("C0"));
        Console.WriteLine(money.ToString("C1"));
        Console.WriteLine(money.ToString("C2"));
        Console.WriteLine(money.ToString("C3"));

        //  Culture-Specific Currency Format:
        Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));



    }
}