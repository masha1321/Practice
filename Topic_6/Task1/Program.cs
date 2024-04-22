namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Введите ваше сообщение здесь";
            int n = 5; 

            var words = message.Split(' ')
                               .Where(word => word.Length <= n);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}