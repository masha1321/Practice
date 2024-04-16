namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 3 * Math.PI;
            int M = 10;
            double H = (B - A) / M;

            for (int i = 0; i <= M; i++)
            {
                double x = A + H * i;
                double F = x * Math.Sin(x);
                Console.WriteLine($"x = {x}, F(x) = {F}");
            }
        }
    }
}