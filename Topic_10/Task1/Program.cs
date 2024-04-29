
namespace Task1
{
        public class Телефон
        {
            private int k; // количество функций

            public Телефон(int k)
            {
                this.k = k;
            }

            public int GetK()
            {
                return this.k;
            }

            public void SetK(int k)
            {
                this.k = k;
            }

            public virtual double Стоимость()
            {
                return 40 * Math.Log(k);
            }
        }

        public class Сотовый : Телефон
        {
            private string модель; // модель

            public Сотовый(int k, string модель) : base(k)
            {
                this.модель = модель;
            }

            public string GetМодель()
            {
                return this.модель;
            }

            public void SetМодель(string модель)
            {
                this.модель = модель;
            }

            public override double Стоимость()
            {
                return base.Стоимость() * 3;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Телефон телефон = new Телефон(5);
                Console.WriteLine("Телефон стоимость: " + телефон.Стоимость());

                Сотовый сотовый = new Сотовый(5, "iPhone");
                Console.WriteLine("Сотовый стоимость: " + сотовый.Стоимость());
            }
        }
    }