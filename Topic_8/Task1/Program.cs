namespace Task1
{
    public enum Post
    {
        Worker,
        Manager,
       
    }

    public class Accauntant
    {
        private const int StandardHours = 160; 

        public bool AskForBonus(Post worker, int hours)
        {
            return hours > StandardHours;
        }

        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            Post worker = Post.Worker;
            int hours = 170; 

            bool isBonusGranted = accauntant.AskForBonus(worker, hours);

            Console.WriteLine($"Сотрудник: {worker}, Отработанные часы: {hours}");
            Console.WriteLine($"Премия положена: {isBonusGranted}");
        }
    }
}
