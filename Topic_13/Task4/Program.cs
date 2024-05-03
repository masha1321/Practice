namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();
            var observer1 = new Observer1();
            var observer2 = new Observer2();

            publisher.MyEvent += observer1.Handler1;
            publisher.MyEvent += observer1.Handler2;
            publisher.MyEvent += observer2.Handler;

            publisher.InvokeEvent();
            Console.WriteLine();

            publisher.MyEvent -= observer1.Handler2;
            publisher.InvokeEvent();
        }
    }

    class Publisher
    {
        public delegate void MyDelegate();
        public event MyDelegate MyEvent;

        public void InvokeEvent()
        {
            MyEvent?.Invoke();
        }
    }

    class Observer1
    {
        public void Handler1()
        {
            Console.WriteLine("Обработчик 1 из Observer1 сработал.");
        }

        public void Handler2()
        {
            Console.WriteLine("Обработчик 2 из Observer1 сработал.");
        }
    }

    class Observer2
    {
        public void Handler()
        {
            Console.WriteLine("Обработчик из Observer2 сработал.");
        }
    }
}