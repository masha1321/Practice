namespace Task3
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат для выполнения операций над строками.
        /// </summary>
        delegate string StringDelegate(string s);

        /// <summary>
        /// Метод для преобразования строки в верхний регистр.
        /// </summary>
        static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        /// <summary>
        /// Метод для преобразования строки в нижний регистр.
        /// </summary>
        static string ToLower(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// Метод для обращения строки.
        /// </summary>
        static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Главный метод программы.
        /// </summary>
        static void Main(string[] args)
        {
            StringDelegate myDelegate = ToUpper;
            Console.WriteLine(myDelegate("Hello, World!"));

            myDelegate += ToLower;
            Console.WriteLine(myDelegate("Hello, World!"));

            myDelegate += Reverse;
            Console.WriteLine(myDelegate("Hello, World!"));
        }
    }
}
