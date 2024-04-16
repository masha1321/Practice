namespace Task4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20; 

            for (int i = A; i <= B; i++)
            {
                if (i % 10 % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}