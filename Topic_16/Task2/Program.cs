using System.IO;

class Program
{
    static void Main()
    {
      
        string path = @"D:\с рабочего стола\Практика C#\Practice\Topic_16\Task2\New_folder";

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}

