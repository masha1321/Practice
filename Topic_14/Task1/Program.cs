using System;
using System.Threading;
namespace Task1
{
    class Program
    {
        static AutoResetEvent autoEvent1 = new AutoResetEvent(false);
        static AutoResetEvent autoEvent2 = new AutoResetEvent(false);
        static AutoResetEvent autoEvent3 = new AutoResetEvent(false);

        static void Main()
        {
            Thread t1 = new Thread(PrintNumbers1);
            Thread t2 = new Thread(PrintNumbers2);
            Thread t3 = new Thread(PrintNumbers3);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void PrintNumbers1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                autoEvent1.Set();
                autoEvent3.WaitOne();
            }
        }

        static void PrintNumbers2()
        {
            for (int i = 10; i < 20; i++)
            {
                autoEvent1.WaitOne();
                Console.WriteLine(i);
                autoEvent2.Set();
            }
        }

        static void PrintNumbers3()
        {
            for (int i = 20; i < 30; i++)
            {
                autoEvent2.WaitOne();
                Console.WriteLine(i);
                autoEvent3.Set();
            }
        }
    }

}