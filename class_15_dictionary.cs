using System;
class Learn_Dictionary
{
    public static void Show_Dict()
    {
        //Dictionary in C#
        // A Dictionary in C# is a collection of key-value pairs. It's similar to a real dictionary:
        // You look up a key, and it gives you a value.

        // Dictionary<TKey, TValue> name = new Dictionary<TKey, TValue>();
        // TKey = type of the key (e.g. string, int)
        // TValue = type of the value (e.g. string, List<int>)

        Dictionary<int, string> Week = new Dictionary<int, string>()
        {
            {1,"Monday"},{2,"tuesday"},{3,"wednesday"}
        };
        if (Week.TryGetValue(1, out string day))
        {
            Console.WriteLine($"Day for key 1 is: {day}");
            Week[1] = "daniyal";
        }
        //remove the monday in week
        if (Week.ContainsKey(1))
        {
            Week.Remove(1);
        }
        else
        {
            Console.WriteLine("keys not found");
        }

        // for (int i = 0; i < Week.Count; i++)
        // {
        //     KeyValuePair<int, string> pair = Week.ElementAt(i);
        //     Console.WriteLine($"{pair.Key} - {pair.Value}");
        // }

        foreach (KeyValuePair<int, string> item in Week)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");

        }
    }
}