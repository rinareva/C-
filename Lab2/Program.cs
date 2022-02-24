using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");
            Console.WriteLine("Выполнила - Григорьева Екатерина ВИС32");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник А",
                Width = 15.2,
                Height = 13.7
            };
            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник Б",
                Width = 5.1,
                Height = 2.8
            };

            Circle c = new Circle()
            {
                Name = "Круг",
                Radius = 7
            };

            Square d = new Square()
            {
                Name = "Квадрат",
                Width = 8,
                Height = 8
            };

            Triangle f = new Triangle()
            {
                Name = "Прямоугольный треугольник",
                A = 4,
                B = 6
            };

            Trapezoid g = new Trapezoid()
            {
                Name = "Трапеция",
                A = 4,
                B = 6,
                H = 5
            };

            Rhomb h = new Rhomb()
            {
                Name = "Ромб",
                d1 = 10,
                d2 = 12
            };

            Parallelogram j = new Parallelogram()
            {
                Name = "Параллелограмм",
                A = 4,
                H = 5
            };

            RegularPentagon k = new RegularPentagon()
            {
                Name = "Правильный пятиугольник",
                A = 4
            };

            RegularDecagon l = new RegularDecagon()
            {
                Name = "Правильный десятиугольник",
                A = 4

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}", c.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", d.Name);
            Console.WriteLine("Площадь фигуры: {0}", d.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", f.Name);
            Console.WriteLine("Площадь фигуры: {0}", f.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", g.Name);
            Console.WriteLine("Площадь фигуры: {0}", g.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", h.Name);
            Console.WriteLine("Площадь фигуры: {0}", h.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", j.Name);
            Console.WriteLine("Площадь фигуры: {0}", j.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", k.Name);
            Console.WriteLine("Площадь фигуры: {0}", k.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", l.Name);
            Console.WriteLine("Площадь фигуры: {0}", l.GetArea());
        }
    }
}
