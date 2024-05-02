namespace Task3
{
    class Program
    {
        // Определение делегата
        delegate string StringDelegate(string s);

        // Метод 1: Преобразование строки в верхний регистр
        static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        // Метод 2: Преобразование строки в нижний регистр
        static string ToLower(string s)
        {
            return s.ToLower();
        }

        // Метод 3: Обращение строки
        static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            // Создание экземпляра делегата
            StringDelegate myDelegate = ToUpper;
            Console.WriteLine(myDelegate("Hello, World!"));  // Вывод: "HELLO, WORLD!"

            // Добавление методов в цепочку вызовов
            myDelegate += ToLower;
            Console.WriteLine(myDelegate("Hello, World!"));  // Вывод: "hello, world!"

            myDelegate += Reverse;
            Console.WriteLine(myDelegate("Hello, World!"));  // Вывод: "!dlroW ,olleH"
        }
    }
}