using System;
using System.Globalization;
class String_To_Number_class
{
    public static void Show_Str_TO_Num()
    {
        Console.WriteLine("String to Number Conversion");

        string text_Age = "-23";
        int age = Convert.ToInt32(text_Age);
        Console.WriteLine(text_Age.GetType() + " ka int mein conversion: " + age);

        string textBigNumber = "-900000000";
        long bigNumber = Convert.ToInt64(textBigNumber);
        Console.WriteLine(textBigNumber + " ka long mein conversion: " + bigNumber);

        string textDecimal = "5.000001";
        float decimalNumber = Convert.ToSingle(textDecimal, CultureInfo.InvariantCulture);
        // CultureInfo.InvariantCulture use hota hai taake decimal conversion universally dot(.) se ho,
       // aur system locale (jaise comma ,) ka effect na aaye. Isse conversion error-free hoti hai.
       Console.WriteLine(textDecimal + " ka float mein conversion: " + decimalNumber);

        string textMoney = "1000.50";
        decimal money = Convert.ToDecimal(textMoney);
        Console.WriteLine(textMoney + " ka decimal mein conversion: " + money);

    }
}