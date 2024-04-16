namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 1; 
            int B = 10; 

            while (A <= B)
            {
                if (A % 2 == 0) 
                {
                    Console.WriteLine(A);
                }
                A++;
            }
        }
    }
}