namespace Task2
{
    public class A
    {
        public int a;
        public int b;

        public A(int aValue, int bValue)
        {
            a = aValue;
            b = bValue;
        }

        public double CalculateExpression()
        {
            return Math.Pow(Math.Pow(a, b), Math.Sin(a));
        }

        public (int, int) GetValues()
        {
            return (a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            A obj = new A(5, 10);

            Console.WriteLine("Значение 'a' равно: " + obj.a);
            Console.WriteLine("Значение 'b' равно: " + obj.b);
            Console.WriteLine("Результат вычисления выражения (a^b)^sin равен: " + obj.CalculateExpression());
            Console.WriteLine("Значения 'a' и 'b': " + obj.GetValues());
        }
    }
}