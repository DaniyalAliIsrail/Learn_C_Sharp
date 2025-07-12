using System;
using System.Linq;
class LearnListPractice
{
    public static void Show_list()
    {
        //List in C#
        //In C#, a List<T> is a dynamic collection that can store multiple values of the same type — just like an array, but more powerful because:
        // It automatically resizes when you add / remove elements.
        // You can use many useful methods like Add(), Remove(), Contains(), etc.
        //Add()        List may item add karta hai
        // Remove()    List say specific item hata deta hai
        // Clear()     Puri list ko empty kar deta hai
        // Contains()  Check karta hai item mojood hay ya nahi
        // IndexOf()   Kisi item ka index number return karta hai
        // Sort()      List ko A - Z ya choty se bary may arrange karta hai
        // Reverse()   List ko ulta kar deta hai
        // Find()      Pehla matching item return karta hai
        // FindAll()   Sab matching items return karta hai
        // Insert()    Kisi index pr item insert karta hai

        List<string> fruits = new List<string> { "jammun", "banana" };
        fruits.Add("apple");
        fruits.Add("mango");
        //list.remove(item) => "banana"
        fruits.Remove("banana");
        //list.COntains(item) => check banana is exist or not
        if (fruits.Contains("apple"))
        {
            Console.WriteLine("yes exist");
        }
        else
        {
            Console.WriteLine("Does not exist");
        }
        //Insert(index, item) => Inserts item at specified position
        fruits.Insert(0, "papita");
        //Any(predicate) => Returns true if any item matches the condition (using System.Linq)	
        bool hasMango = fruits.Any(x => x == "mango");
        Console.WriteLine(hasMango);

        //print all the list item
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //
        List<string> names = new List<string> { "Ali", "Ahmed", "Sara" };
        foreach (string item in names)
        {
            Console.WriteLine($"{item}");
        }
        //total count of fruits is
        Console.WriteLine("The total fruits count is " + fruits.Count);


    }
}