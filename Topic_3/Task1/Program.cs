namespace Task1
{
    class Program
    {
        static void Minmax(ref double X, ref double Y)
        {
            if (X > Y)
            {
                double temp = X;
                X = Y;
                Y = temp;
            }
        }

        static void Main()
        {
            double A = 10, B = 20, C = 30, D = 40;
            Minmax(ref A, ref B);
            Minmax(ref A, ref C);
            Minmax(ref A, ref D);
            Minmax(ref B, ref C);
            Minmax(ref B, ref D);
            Minmax(ref C, ref D);

            Console.WriteLine("Минимальное число: " + A);
            Console.WriteLine("Максимальное число: " + D);
        }
    }
}
