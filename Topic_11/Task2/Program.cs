using System;
using System.Collections.Generic;
using System.Linq;
namespace Task2
{
        public abstract class Figure
        {
            public abstract double GetArea();
        }

        public class Circle : Figure
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public class Rectangle : Figure
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double GetArea()
            {
                return Width * Height;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Figure> figures = new List<Figure>
        {
            new Circle(5),
            new Rectangle(4, 5),
            new Circle(7),
            new Rectangle(6, 9),
            new Circle(8)
        };

                foreach (var figure in figures)
                {
                    Console.WriteLine($"Площадь фигуры: {figure.GetArea()}");
                }

                double maxArea = figures.Max(figure => figure.GetArea());
                Console.WriteLine($"Максимальная площадь: {maxArea}");
            }
        }
    }