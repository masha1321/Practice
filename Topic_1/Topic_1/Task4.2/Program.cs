namespace Task4._2
{
    internal class Program
    {
        static void Main()
        {
            int A = 10; 
            int B = 30; 

            int i = A;
            do
            {
                if (i % 10 % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= B);
        }
    }
}