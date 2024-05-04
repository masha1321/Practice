using System;
using System.Collections.Generic;

public class MyDictionary<TKey, TValue>
{
    private List<TKey> keys;
    private List<TValue> values;

    public MyDictionary()
    {
        keys = new List<TKey>();
        values = new List<TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        if (keys.Contains(key))
        {
            throw new ArgumentException("Элемент с таким же ключом уже существует в MyDictionary.");
        }
        keys.Add(key);
        values.Add(value);
    }

    public TValue this[TKey key]
    {
        get
        {
            int index = keys.IndexOf(key);
            if (index == -1)
            {
                throw new KeyNotFoundException("The key was not found in the MyDictionary.");
            }
            return values[index];
        }
    }

    public int Count
    {
        get
        {
            return keys.Count;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var myDict = new MyDictionary<string, int>();
        try
        {
            myDict.Add("one", 1);
            myDict.Add("two", 2);
            Console.WriteLine(myDict["one"]); 
            Console.WriteLine(myDict.Count); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
