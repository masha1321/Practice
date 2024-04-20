namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = 7;
            int[,] spiralArray = new int[size, size];

            int value = 1;
            int minCol = 0;
            int maxCol = size - 1;
            int minRow = 0;
            int maxRow = size - 1;

            while (value <= size * size)
            {
                for (int i = minCol; i <= maxCol; i++)
                {
                    spiralArray[minRow, i] = value++;
                }
                minRow++;

                for (int i = minRow; i <= maxRow; i++)
                {
                    spiralArray[i, maxCol] = value++;
                }
                maxCol--;

                for (int i = maxCol; i >= minCol; i--)
                {
                    spiralArray[maxRow, i] = value++;
                }
                maxRow--;

                for (int i = maxRow; i >= minRow; i--)
                {
                    spiralArray[i, minCol] = value++;
                }
                minCol++;
            }

 
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(spiralArray[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}