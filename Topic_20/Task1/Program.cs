public class Task
{
    public int Number { get; set; }

    public Task(int number)
    {
        Number = number;
    }

    public int ReverseNumber()
    {
        int reversedNumber = 0;
        while (Number > 0)
        {
            reversedNumber = reversedNumber * 10 + Number % 10;
            Number /= 10;
        }
        return reversedNumber;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // 1
        Task task1 = new Task(1234);
        Console.WriteLine(task1.ReverseNumber());  

        // 2
        Task CreateTask(int number) => new Task(number);
        Task task2 = CreateTask(5678);
        Console.WriteLine(task2.ReverseNumber());  

        // 3
        Func<int, Task> taskFactory = num => new Task(num);
        Task task3 = taskFactory(9012);
        Console.WriteLine(task3.ReverseNumber());  
    }
}
