namespace Task3
{
    public class MyInfo
    {
       
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

        
            myInfo.NameChanged += name => Console.WriteLine($"Имя было изменено на: {name}");

            myInfo.Name = "Мария";
        }
    }
}