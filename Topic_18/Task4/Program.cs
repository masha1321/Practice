using System;
using System.Collections;

class CD
{
    public string Title { get; set; }
    public Hashtable Songs { get; set; }

    public CD(string title)
    {
        Title = title;
        Songs = new Hashtable();
    }

    public void AddSong(string song)
    {
        if (!Songs.ContainsKey(song))
        {
            Songs.Add(song, song);
        }
    }

    public void RemoveSong(string song)
    {
        if (Songs.ContainsKey(song))
        {
            Songs.Remove(song);
        }
    }

    public void DisplaySongs()
    {
        foreach (DictionaryEntry song in Songs)
        {
            Console.WriteLine(song.Value);
        }
    }
}

class Catalog
{
    private Hashtable CDs;

    public Catalog()
    {
        CDs = new Hashtable();
    }

    public void AddCD(string title)
    {
        if (!CDs.ContainsKey(title))
        {
            CDs.Add(title, new CD(title));
        }
    }

    public void RemoveCD(string title)
    {
        if (CDs.ContainsKey(title))
        {
            CDs.Remove(title);
        }
    }

    public CD GetCD(string title)
    {
        if (CDs.ContainsKey(title))
        {
            return (CD)CDs[title];
        }
        else
        {
            return null;
        }
    }

    public void DisplayCatalog()
    {
        foreach (DictionaryEntry cd in CDs)
        {
            Console.WriteLine(((CD)cd.Value).Title);
            ((CD)cd.Value).DisplaySongs();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        catalog.AddCD("CD1");
        catalog.AddCD("CD2");

        CD cd1 = catalog.GetCD("CD1");
        cd1.AddSong("Mimimamu");
        cd1.AddSong("Wow");

        CD cd2 = catalog.GetCD("CD2");
        cd2.AddSong("Цунами");
        cd2.AddSong("Май");

        catalog.DisplayCatalog();

        Console.ReadKey();
    }
}
