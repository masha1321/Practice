using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "abc#d##c";
        Console.WriteLine("Исходная строка: " + input);
        Console.WriteLine("Преобразованная строка: " + TransformString(input));
    }

    static string TransformString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c != '#')
            {
                stack.Push(c);
            }
            else if (stack.Count > 0)
            {
                stack.Pop();
            }
        }

        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
