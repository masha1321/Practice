class Program
{
    delegate int RandomNumberDelegate();

    static void Main()
    {
     
        RandomNumberDelegate[] delegates = new RandomNumberDelegate[5];
        Random random = new Random();

        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate () { return random.Next(1, 100); };
        }

        Func<RandomNumberDelegate[], double> average = delegate (RandomNumberDelegate[] dels)
        {
            double sum = 0;
            foreach (var del in dels)
            {
                sum += del();
            }
            return sum / dels.Length;
        };

        Console.WriteLine("Среднее значение: " + average(delegates));
    }
}