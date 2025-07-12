using System;
class StringFormatting
{
    public static void ShowStringFormatting()
    {
        // Verbatim String -> Agar tum @ string ke start mein lagao ge to C# us string ke andar \n, \t, \\\ ko escape sequences nahi samjhega.
        Console.WriteLine(@"Hello \ Daniyal Ali"); // output: Hello \ Daniyal Ali
        string path1 = @"C:\Users\Dani\Documents\MyFile.txt";
        Console.WriteLine(path1);

        // --> \t , \n , \" , \\ , =\

        // \t → Tab space -> ye aik tab space deta hai(jaise keyboard ka Tab button deta hay). 
        Console.WriteLine("Hello \t Daniyal Ali "); // output: Hello     Daniyal Ali
        Console.WriteLine("Hello \t mama \t how are you?"); // output: Hello     mama    how are you?

        // \n → New Line -> (nayi line) ye aik nayi line se likhna shuru karta hai.
        Console.WriteLine("Hello \n Daniyal Ali "); // output: Hello 
                                                    // Daniyal Ali

        // \" -> Double Quote -> (Do baar " ka istemal) ye aik double quote ko print karta hai.
        Console.WriteLine("Hello \"Daniyal Ali\""); // output: Hello "Daniyal Ali"

        // \\ -> Backslash -> (ek backslash ka istemal) ye aik backslash ko print karta hai.
        Console.WriteLine("Hello \\ Daniyal Ali"); // output: Hello \ Daniyal Ali

        string path = "C:\\Users\\Dani\\Documents\\MyFile.txt";
        Console.WriteLine(path); // output: C:\Users\Dani\Documents\MyFile.txt  

        // // 1. Basic String Formatting
        int englishSub = 85;
        int mathSub = 90;
        Console.WriteLine("englishSub: " + englishSub);
        Console.WriteLine("mathSub: " + mathSub);
        Console.WriteLine("English:" + englishSub + "\nMath:" + mathSub);
        Console.WriteLine("your English mark is" + " " + englishSub + "math subjec marks is" + "\nMath:" + mathSub);


        string name = "daniyal";
        int age = 22;
        Console.WriteLine("My name is {0} and I am {1} years old.", name, age);

        // 2. String Interpolation
        Console.WriteLine($"My name is {name} and I am {age} years old.");


        //string concatenation using string.Concat method:
        string myNameinUni = "daniyal ali";
        string field = "Computer Science";
        string university = "University of Karachi UBIT";
        string test = string.Concat("my name is ", myNameinUni, " and i am studying ", field, "at", university);
        Console.WriteLine(test);


        // 3. string.Empty method in C#
        string emptyString = string.Empty; // This creates an empty string
        Console.WriteLine($"empty string: '{emptyString}'"); // return empty string like this -> ''

        Console.WriteLine("Enter your name :");
        string userName = Console.ReadLine();
        if (userName != string.Empty)
        {
            Console.WriteLine($"Hello, {userName}!");
        }
        else
        {
            Console.WriteLine("You didn't enter a name.");
        }


        //String.Equals() method do strings ko compare karta hai — jaise:
        //kya dono barabar hain?
        //ya konsa string pehlay aata hai dictionary order(a → z) mein ?

        Console.WriteLine("Enter Any word");
        string firstWord = Console.ReadLine();
        if (!firstWord.Equals(""))
        {
            Console.WriteLine($"You entered: {firstWord}");
        }
        else
        {
            Console.WriteLine("You didn't enter a word.");
        }

        // string.IsNullOrEmpty() ek built-in static method hai jo check karta hai:
        // Kya string null hai ya empty ("") hai? null or empty pr true return karta hai.

        string name11 = null;
        string name22 = "";
        string name33 = "Daniyal";

        Console.WriteLine(string.IsNullOrEmpty(name11));  // Output: True
        Console.WriteLine(string.IsNullOrEmpty(name22));  // Output: True
        Console.WriteLine(string.IsNullOrEmpty(name33));  // Output: False

        Console.WriteLine("Enter any words:");
        string EnterAnyWords = Console.ReadLine();
        if (string.IsNullOrEmpty(EnterAnyWords))
        {
            Console.WriteLine("The string is  null or empty.");
        }
        else
        {
            Console.WriteLine("The string is  not null or empty.");
        }

        // // 4. Date and Time Formatting
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date: {0:dd MMM, yyyy}", now);
    }
}