namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;

          
            if (words.Length > 2)
            {
                words[1] = words[1] + words[2];
                words = words.Where((source, index) => index != 2).ToArray();
            }

            if (words.Length > 2)
            {
                char[] arr = words[2].ToCharArray();
                Array.Reverse(arr);
                words[2] = new string(arr);
            }

            if (words[0].Length > 2)
            {
                words[0] = words[0].Substring(2);
            }

            Console.WriteLine("Результат: " + string.Join(" ", words));
        }
    }
}