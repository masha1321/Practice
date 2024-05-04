using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> internalList = new List<T>();

    public void Add(T item)
    {
        internalList.Add(item);
    }
}

public static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        var type = list.GetType();
        var field = type.GetField("internalList", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var internalList = field.GetValue(list) as List<T>;
        return internalList.ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        var array = myList.GetArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

