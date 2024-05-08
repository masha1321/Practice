using System.IO;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        // Путь к папке
        string path = @"D:\с рабочего стола\Практика C#\Practice\Topic_16\Task2\New_folder";

        // Проверка на существование папки и создание, если она отсутствует
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}
