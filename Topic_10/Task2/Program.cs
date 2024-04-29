using System;

namespace Task2
{
    public class A
    {
        private int a;
        private int b;

        public A(int a = 5, int b = 10)
        {
            this.a = a;
            this.b = b;
        }

        public int c
        {
            get { return a + b; }
        }
    }

    public class B : A
    {
        private int d;

        public B() : base()
        {
            d = 20;
        }

        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }

        public int c2
        {
            get
            {
                int result = 0;
                do
                {
                    result = c + d;
                } while (false);
                return result;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Значение свойства c класса A: " + a.c);

            B b1 = new B();
            Console.WriteLine("Значение свойства c2 класса B (конструктор по умолчанию): " + b1.c2);

            B b2 = new B(3, 4, 5);
            Console.WriteLine("Значение свойства c2 класса B (собственный конструктор): " + b2.c2);
        }
    }
}