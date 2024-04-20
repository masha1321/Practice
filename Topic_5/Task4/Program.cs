namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int k = 1; 
            int s = 2; 

          
            int rowSum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                rowSum += array[k, i];
            }

          
            int columnSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                columnSum += array[i, s];
            }

            int maxSum = Math.Max(rowSum, columnSum);

            Console.WriteLine("Максимальное из двух чисел: " + maxSum);
        }
    }
}