using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task4\\files\\1.txt");
        File.WriteAllLines("D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task4\\files\\2.txt", lines.Where((line, index) => index % 2 != 0));
        File.WriteAllLines("D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task4\\files\\3.txt", lines.Where((line, index) => index % 2 == 0));
    }
}
