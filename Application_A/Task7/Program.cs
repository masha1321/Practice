namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double a = -10; a <= 10; a += 0.1)
            {
                double z1, z2;
                try
                {
                    z1 = ((a + 2) * Math.Sqrt(2 * a) + a - 2) / (Math.Sqrt(2 * a) + 2) * Math.Sqrt(a - Math.Sqrt(2)) / (a + 2);
                    z2 = 1 / Math.Sqrt(a + Math.Sqrt(2));
                    Console.WriteLine($"For a = {a}, z1 = {z1} and z2 = {z2}");
                }
                catch
                {
                    Console.WriteLine($"Cannot calculate for a = {a}");
                }
            }
        }
    }
}