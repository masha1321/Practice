using System;
using System.Collections.Generic;

namespace Task1
{
    public class MyList<T>
    {
        private List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T this[int index]
        {
            get
            {
                try
                {
                    return _list[index];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне диапазона!");
                    return default(T);
                }
            }
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine(myList.Count); 
        }
    }
}
