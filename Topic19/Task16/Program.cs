using System;
using System.IO;
using System.Linq;

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
        // Путь к директории
        string drive = @"D:\с рабочего стола\f7";
        Console.WriteLine($"Drive: {drive}");

        // Получение списка файлов в директории
        string[] files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        // Создание новой директории
        string dirPath = @"D:\Exmple_36tp";
        Directory.CreateDirectory(dirPath);

        // Копирование файлов из исходной директории в новую
        string sourceDir = @"D:\с рабочего стола\f7";
        var sourceFiles = Directory.GetFiles(sourceDir).Take(3);
        foreach (var file in sourceFiles)
        {
            string destFile = Path.Combine(dirPath, Path.GetFileName(file));
            File.Copy(file, destFile, true);
        }

        // Установка атрибута "скрытый" для файлов в новой директории
        var filesInDir = Directory.GetFiles(dirPath);
        foreach (var file in filesInDir)
        {
            File.SetAttributes(file, FileAttributes.Hidden);
        }

        // Создание ссылок на файлы в новой директории
        foreach (var file in filesInDir)
        {
            string linkPath = Path.Combine(dirPath, Path.GetFileNameWithoutExtension(file) + "_link" + Path.GetExtension(file));
            using (StreamWriter sw = File.CreateText(linkPath))
            {
                sw.WriteLine($"This is a link to {file}");
            }
        }
    }
}
