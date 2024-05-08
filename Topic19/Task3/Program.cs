namespace Task3
{
    /// <summary>
    /// Класс для работы с матрицами вещественных чисел.
    /// </summary>
    public class RealMatrix
    {
        private double[,] matrix;

        /// <summary>
        /// Конструктор класса RealMatrix.
        /// </summary>
        /// <param name="rows">Количество строк матрицы.</param>
        /// <param name="columns">Количество столбцов матрицы.</param>
        public RealMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Размеры матрицы должны быть больше нуля.");
            }

            matrix = new double[rows, columns];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы.
        /// </summary>
        /// <param name="i">Индекс строки.</param>
        /// <param name="j">Индекс столбца.</param>
        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= matrix.GetLength(0) || j < 0 || j >= matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Индекс выходит за границы матрицы.");
                }

                return matrix[i, j];
            }
            set
            {
                if (i < 0 || i >= matrix.GetLength(0) || j < 0 || j >= matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Индекс выходит за границы матрицы.");
                }

                matrix[i, j] = value;
            }
        }

        /// <summary>
        /// Оператор для циклического сдвига элементов матрицы вправо.
        /// </summary>
        /// <param name="m">Матрица для сдвига.</param>
        public static RealMatrix operator ++(RealMatrix m)
        {
            int rows = m.matrix.GetLength(0);
            int columns = m.matrix.GetLength(1);
            RealMatrix result = new RealMatrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, (j + 1) % columns] = m[i, j];
                }
            }

            return result;
        }
    }

    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        static void Main(string[] args)
        {
            RealMatrix matrix = new RealMatrix(3, 3);

            matrix[0, 0] = 1.0;
            matrix[0, 1] = 2.0;
            matrix[0, 2] = 3.0;
            matrix[1, 0] = 4.0;
            matrix[1, 1] = 5.0;
            matrix[1, 2] = 6.0;
            matrix[2, 0] = 7.0;
            matrix[2, 1] = 8.0;
            matrix[2, 2] = 9.0;

            matrix++;
        }
    }
}
