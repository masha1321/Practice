namespace Task3
{
    public class MyInfo
    {
        // Событие, которое вызывается при изменении имени
        public event Action<string> NameChanged;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    // Вызов события при изменении имени
                    NameChanged?.Invoke(_name);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyInfo myInfo = new MyInfo();

            // Подписка на событие
            myInfo.NameChanged += name => Console.WriteLine($"Имя было изменено на: {name}");

            // Изменение имени, что приведет к вызову события
            myInfo.Name = "Мария";
        }
    }
}