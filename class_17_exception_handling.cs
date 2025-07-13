using System;
using System.ComponentModel;
using System.Reflection.Metadata;
class Exception_Handling
{
    public static void show_exception_handling()
    {
        // Syntax
        // try
        // {
        //     // Code that might throw an exception
        // }
        // catch (Exception ex)
        // {
        //     // Handle the exception
        // }
        // finally
        // {
        //     // Always executes (optional)
        // }

        //------------------------------------------------------------------------------
        // Basic Try-Catch

        Console.WriteLine("Basic Try-Catch Example");
        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());// user put letter then then throw error
            Console.WriteLine($"You entered: {number}");
        }
        catch
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
        Console.WriteLine("Program continues...\n");

        //-------------------------------------------------------------------------------
        //Specific Exception (FormatException)
        Console.WriteLine("2Specific Exception Type Example");
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {num}");
        }
        catch (FormatException ex) //Sirf FormatError handle karega.
        {
            Console.WriteLine("Please enter only numeric value!");
            Console.WriteLine("Details: " + ex.Message); // ex.Message se exact message mlgya.
        }
        Console.WriteLine("Code continues after specific catch.\n");

        //--------------------------------------------------------------------------
        //Multiple Catch Blocks
        // OverflowException:4
        // Jab number limit se bara ho (e.g. 99999999999).
        // 🔸 FormatException:
        // Jab number ki jagah text diya ho.
        // 🔸 Exception (last catch):
        // Ye sab kuch pakar leta hai jo upar walay catch nahi pakar saktay.

        // Console.WriteLine("Multiple Catch Blocks");
        // try
        // {
        //     Console.Write("Enter a number: ");
        //     int num = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine($"You entered: {num}");


        // }
        // catch (OverflowException)
        // {
        //     Console.WriteLine("Number too big! Must be less than 2 billion.");
        // }
        // catch (FormatException)
        // {
        //     Console.WriteLine("Only enter numbers, no text!");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("Unknown Error: " + ex.Message);
        // }
        // Console.WriteLine("Chaining done, code continues...\n");

        //--------------------------------------------------------------------------
        // Exception Object & GetType()
        Console.WriteLine("Using Exception Object");
        try
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {n}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred!");
            Console.WriteLine("Error Message: " + ex.Message);
            Console.WriteLine("Error Type: " + ex.GetType()); //ex.GetType(): Kis type ki error thi? (e.g., System.FormatException)
        }
        Console.WriteLine("✅ Error info shown, program continues.\n");

        //---------------------------------------------------------------------
        // Finally Block Example
        Console.WriteLine("----Finally Block-------");
        try
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {x}");
        }
        catch
        {
            Console.WriteLine("Something went wrong.");
        }
        finally
        {
            Console.WriteLine("finally block always runs.");
        }

        //example
        Console.WriteLine("6️⃣ Tumhari Image Wali Example (Clean Format)");
        int userInput = 0;
        try
        {
            Console.Write("Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {userInput}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Please enter a number less than 2 billion!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only enter valid numeric value!");
        }
        catch (Exception)
        {
            Console.WriteLine("Something has gone wrong!");
        }
        finally
        {
            Console.WriteLine("Goodbye from image-style example.");
        }

        // General Catch Only
        // Sirf ek catch use kiya gaya.
        // Har exception isme aa jati hai — lekin specific error ka pata nahi chalta.

        Console.WriteLine("Only General Catch Example (Quick)");
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("General catch: " + ex.Message);
        }


        // ====================================================
        // 8️⃣ What happens after error? (Agla code chalega?)
        // ====================================================

        Console.WriteLine("8️⃣ Try ke andar error ke baad agla code chalega?");
        try
        {
            Console.WriteLine("Line A - Before Error");
            int num = int.Parse("abc"); // Format error here
            Console.WriteLine("Line B - This won't run"); // Ye skip hoga
        }
        catch
        {
            Console.WriteLine(" Error caught!");
        }
        Console.WriteLine("✅ Line C - Code continues normally\n");





    }
}