namespace Task1
{
    /// <summary>
    /// Делегат для выполнения математических операций над фигурами.
    /// </summary>
    public delegate double CalcFigure(double r);

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
            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine("Длина окружности: " + CF(5));

            CF = Get_Area;
            Console.WriteLine("Площадь круга: " + CF(5));

            CF = Get_Volume;
            Console.WriteLine("Объем шара: " + CF(5));
        }

        /// <summary>
        /// Метод для вычисления длины окружности.
        /// </summary>
        /// <param name="r">Радиус окружности.</param>
        static double Get_Length(double r)
        {
            return 2 * Math.PI * r;
        }

        /// <summary>
        /// Метод для вычисления площади круга.
        /// </summary>
        /// <param name="r">Радиус круга.</param>
        static double Get_Area(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// Метод для вычисления объема шара.
        /// </summary>
        /// <param name="r">Радиус шара.</param>
        static double Get_Volume(double r)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
        }
    }
}
