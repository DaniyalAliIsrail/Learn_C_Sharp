using System;

class keywordInCSharp
{
  
    // const string AppName = "To-Do Manager";
    // Console.WriteLine("App Name: " + AppName);

    public static void show_Keyword()
    {
        // var – Implicitly Typed Variable
        // Jab aap value assign karte waqt C# khud hi data type guess kar leta hai, to var use hota hai.
        // Yeh sirf local scope (method ke andar) mein use hota hai.
        // Type compile-time pe fix ho jati hai, runtime pe nahi change hoti.
        //  Use jab value clear ho aur aapko type likhne ki zarurat na ho.
        // Type once fixed, badal nahi sakti.

        var number = 34.43434;
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Type of number: " + number.GetType());


    //const variable ki value kabhi change nahi ho sakti.
    // Iski value compile-time pe set hoti hai.
    // Mostly math ya configuration values ke liye use hota hai.
    // ✅ Use for fixed values like Pi, AppName, etc.
    // ❌ Value baad mein change karne ki koshish error dega.

    // const string AppName = "To-Do Manager";
    // Console.WriteLine("App Name: " + AppName);

    }
}




