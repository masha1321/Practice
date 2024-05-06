using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
     
        string drive = @"D:\с рабочего стола\f7";
        Console.WriteLine($"Drive: {drive}");
        string[] files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

    
        string dirPath = @"D:\Exmple_36tp";
        Directory.CreateDirectory(dirPath);

        string sourceDir = @"D:\с рабочего стола\f7";
        var sourceFiles = Directory.GetFiles(sourceDir).Take(3);
        foreach (var file in sourceFiles)
        {
            string destFile = Path.Combine(dirPath, Path.GetFileName(file));
            File.Copy(file, destFile, true);
        }

       
        var filesInDir = Directory.GetFiles(dirPath);
        foreach (var file in filesInDir)
        {
            File.SetAttributes(file, FileAttributes.Hidden);
        }

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
