namespace Task1
{
    
 
        public abstract class PrintProduct
        {
            public string Name { get; set; }

            public PrintProduct(string name)
            {
                Name = name;
            }

            public abstract double CalculateCost();
        }

        public class Magazine : PrintProduct
        {
            public int Circulation { get; set; }
            public double Price { get; set; }

            public Magazine(string name, int circulation, double price) : base(name)
            {
                Circulation = circulation;
                Price = price;
            }

            public override double CalculateCost()
            {
                return Circulation * Price;
            }
        }

        public class Newspaper : PrintProduct
        {
            public int NumberOfSheets { get; set; }
            public double SheetCost { get; set; }
            public int Circulation { get; set; }

            public Newspaper(string name, int numberOfSheets, double sheetCost, int circulation) : base(name)
            {
                NumberOfSheets = numberOfSheets;
                SheetCost = sheetCost;
                Circulation = circulation;
            }

            public override double CalculateCost()
            {
                return NumberOfSheets * SheetCost * Circulation;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                PrintProduct[] products = new PrintProduct[5]
                {
            new Magazine("Magazine1", 1000, 2.5),
            new Newspaper("Newspaper1", 16, 0.1, 5000),
            new Magazine("Magazine2", 2000, 3.0),
            new Newspaper("Newspaper2", 20, 0.15, 7000),
            new Magazine("Magazine3", 1500, 2.75)
                };

                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Cost: {product.CalculateCost()}");
                }
            }
        }
    }