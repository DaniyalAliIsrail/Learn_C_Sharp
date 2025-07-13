using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;

class LearnFunction
{
    public static void show_function()
    {
        // Function in C# (Complete Beginner Guide)
        // In C#, a function (also called a method) is a block of code that performs a task. You write it once and can use (call) it multiple times.

        createAndprintArray();
        int result = Addition(2, 2);
        Console.WriteLine(result);

        int saveInput = prntNum();
        Console.WriteLine(saveInput);

        Console.WriteLine("Enter a first name:");
        string name1 = Console.ReadLine();

        Console.WriteLine("Enter a last name:");
        string name2 = Console.ReadLine();

        // Function call with input values
        Console.WriteLine(Intro(name1, name2));
        ShowProfile(name: "daniyal", age: 25, city: "karachi");

        //out parameter

        int resultSum, resultProduct;
        // Call the function using out parameters
        Calculate(4, 5, out resultSum, out resultProduct);

        Console.WriteLine("Sum: " + resultSum);         // 9
        Console.WriteLine("Product: " + resultProduct); // 20

        int num = 0;
        bool success = test(out num);
        Console.WriteLine(num);
        Console.WriteLine(success);


        List<string> shoppingList = new List<string> { "coffe", "milk" };
        bool found = findInList("milkk", shoppingList, out int index);
        Console.WriteLine("Found: " + found);
        Console.WriteLine("Index: " + index);

        //ref parameter 
        
        int num1 = 10;
        changeNumber(ref num1);
        Console.WriteLine(num1);

        Console.WriteLine("Enter a old name");   
        string oldName = Console.ReadLine();// daniyal
        Console.WriteLine("Enter a new name");
        string newName = Console.ReadLine(); //huzaifa
        changeName(ref oldName, newName);
        Console.WriteLine($"old name is {oldName} and new name is {newName}"); // oldnama or newname may "huzaifa" ana chahye 
    }
    //void function 
    static void createAndprintArray()
    {
        int[] genNum = new int[] { 1, 2, 3, 4, 5 };
        foreach (var item in genNum)
        {
            Console.WriteLine($"{item}");
        }

    }

    // return function
    static int Addition(int a, int b)
    {
        return a + b;
    }
    //Enter a number and print
    static int prntNum()
    {
        Console.WriteLine("Enter a number");
        return Convert.ToInt32(Console.ReadLine());
    }

    //. Optional Parameters
    // Optional parameters have default values. If you don’t pass a value, the default will be used.

    static string Intro(string firstName = "John", string lastName = "Doe")
    {
        return firstName + " " + lastName;
    }

    //named parameter
    static void ShowProfile(string name, int age, string city)
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    //What is an out Parameter in C#?
    // An out parameter is used to return multiple values from a function.
    // Unlike return, which returns only one value, out allows extra values to be returned through parameters.
    // You must assign a value to out parameters inside the method.


    // out prameter function
    static bool test(out int num)
    {
        num = 5;
        return true;
    }
    static void Calculate(int a, int b, out int sum, out int product)
    {
        sum = a + b;         // Assigning value to out parameter
        product = a * b;     // Assigning value to out parameter
    }

    static bool findInList(string s, List<string> list, out int index)
    {
        index = -1;
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("list value: {0}", list[i]); // show each item

            if (list[i].ToLower().Equals(s.ToLower()))
            {
                index = i;
                break;
            }
        }
        return index > -1;
    }
    // In C#, a reference parameter is a parameter that is passed by reference using the ref keyword. This means the method can modify the original variable from the calling function.
    //ab aap kisi method ke andar value ko modify karna chahtay hain aur chahte hain ke woh asli (original) variable bhi change ho jaye, tab ref use hota hai.
    // Agar aap normally parameter pass karte ho (by value), to method ke andar uski copy banti hai.


    static void changeNumber(ref int num)
    {
        num++;
    }

    static void changeName(ref string name, string newName)
    {
        name = newName;
    }




}