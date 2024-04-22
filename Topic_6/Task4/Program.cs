namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Код личности: " + GetPersonalityCode(fullName));
        }

        public static int GetPersonalityCode(string fullName)
        {
            int sum = fullName.ToUpper()
                              .Where(char.IsLetter)
                              .Select(c => c - 'А' + 1)
                              .Sum();

            while (sum > 9)
            {
                sum = sum.ToString().Select(c => c - '0').Sum();
            }

            return sum;
        }
    }
}