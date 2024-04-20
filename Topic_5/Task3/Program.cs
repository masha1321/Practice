namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

            Console.Write("Введите число H: ");
            int H = Convert.ToInt32(Console.ReadLine());

            int countLessThanH = 0;
            foreach (int i in matrix)
            {
                if (i < H)
                {
                    countLessThanH++;
                }
            }

            Console.WriteLine("Количество чисел меньше " + H + ": " + countLessThanH);

            Console.Write("Введите номер столбца k: ");
            int k = Convert.ToInt32(Console.ReadLine()) - 1;

            int countOddInColumnK = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, k] % 2 != 0)
                {
                    countOddInColumnK++;
                }
            }

            Console.WriteLine("Количество нечетных элементов в столбце " + (k + 1) + ": " + countOddInColumnK);
        }
    }
}