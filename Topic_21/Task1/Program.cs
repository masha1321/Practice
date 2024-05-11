namespace Task1
{
    public interface IDogBehavior
    {
        void Act();
    }

    public class BarkBehavior : IDogBehavior
    {
        public void Act()
        {
            Console.WriteLine("Гав-гав");
        }
    }

    public class HowlBehavior : IDogBehavior
    {
        public void Act()
        {
            Console.WriteLine("Аф-Аф");
        }
    }

    public class Dog
    {
        private IDogBehavior _behavior;

        public Dog(IDogBehavior initialBehavior)
        {
            _behavior = initialBehavior;
        }

        public void SetBehavior(IDogBehavior newBehavior)
        {
            _behavior = newBehavior;
        }

        public void PerformAct()
        {
            _behavior.Act();
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog(new BarkBehavior());
            myDog.PerformAct(); 

            myDog.SetBehavior(new HowlBehavior());
            myDog.PerformAct(); 
        }
    }
}
