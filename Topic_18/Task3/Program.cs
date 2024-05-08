using System;
using System.Collections.Generic;

public class Library<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    public Library<T> Clone()
    {
        Library<T> clone = new Library<T>();
        clone.items = new List<T>(this.items);
        return clone;
    }

    public void PrintItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library<Book> library = new Library<Book>();
        library.AddItem(new Book { Title = "Book1", Author = "Author1" });
        library.AddItem(new Book { Title = "Book2", Author = "Author2" });

        Console.WriteLine("Original library:");
        library.PrintItems();

        Library<Book> clonedLibrary = library.Clone();
        Console.WriteLine("\nCloned library:");
        clonedLibrary.PrintItems();

        library.RemoveItem(new Book { Title = "Book1", Author = "Author1" });
        Console.WriteLine("\nOriginal library after removal:");
        library.PrintItems();

        Console.WriteLine("\nCloned library after removal in original:");
        clonedLibrary.PrintItems();
    }
}
