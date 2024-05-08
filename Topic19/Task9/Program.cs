class Program
{
    /// <summary>
    /// Делегат для генерации случайного числа.
    /// </summary>
    delegate int RandomNumberDelegate();

    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        // Создание массива делегатов
        RandomNumberDelegate[] delegates = new RandomNumberDelegate[5];
        Random random = new Random();

        // Инициализация делегатов анонимной функцией, генерирующей случайное число
        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate () { return random.Next(1, 100); };
        }

        // Создание делегата для вычисления среднего значения
        Func<RandomNumberDelegate[], double> average = delegate (RandomNumberDelegate[] dels)
        {
            double sum = 0;
            foreach (var del in dels)
            {
                sum += del();
            }
            return sum / dels.Length;
        };

        // Вывод среднего значения
        Console.WriteLine("Среднее значение: " + average(delegates));
    }
}
