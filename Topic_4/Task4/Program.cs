namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = 1 / x;
                Console.WriteLine(" y ={ 0}", y);

                Console.WriteLine("блок try выполнилсь успешно");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение!");
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Ошибка: деление на 0!");

            }

            Console.WriteLine("конец программы");
        }
    }
}