using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab3
{
    class Program
    {
        public static Figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат 1",
                Color = Color.DarkRed,
                Position = new Point(30, 30),
                Width = 50,
                Height = 50
            },
            new Rectangle()
            {
                Name = "Квадрат 2",
                Color = Color.Green,
                Position = new Point(60, 100),
                Width = 100,
                Height = 100
            },
            new Rectangle()
            {
                Name = "Прямоугольник",
                Color = Color.Blue,
                Position = new Point(200, 200),
                Width = 100,
                Height = 50
            },
            new Circle()
            {
                Name = "Круг",
                Color = Color.Red,
                Position = new Point(200, 300),
                Radius = 100
            },
            new Triangle()
            {
                Name = "Треугольник",
                Color = Color.HotPink,
                Position = new Point(60, 250),
                A = 60,
                B = 80
            },
            new Rhomb()
            {
                Name = "Ромб",
                Color = Color.Brown,
                Position = new Point(200, 100),
                d1 = 80,
                d2 = 80
            },
            new Trapezoid()
            {
                Name = "Трапеция",
                Color = Color.Black,
                Position = new Point(200, 30),
                A = 70,
                B = 120,
                H = 50
            },
            new Parallelogram()
            {
                Name = "Параллелограмм",
                Color = Color.YellowGreen,
                Position = new Point(350, 30),
                A = 100,
                H = 50
            },
            new RegularDecagon()
            {
                Name = "Десятиугольник",
                Color = Color.Peru,
                Position = new Point(400, 150),
                A = 100,
                Radius = 50
            },
            new RegularPentagon()
            {
                Name = "Пятиугольник",
                Color = Color.MediumPurple,
                Position = new Point(400, 300),
                A = 100,
                Radius = 50
            }
        };
        static void Main(string[] args)
        {
            //Console.WriteLine("Лабораторная работа №3 - Полиморфизм");
            //Console.WriteLine("Выполнила - Григорьева Екатерина ВИС32");
        
        //Figure f = new Rectangle()
        //{
        //    Name = "Квадрат",
        //    Color = System.Drawing.Color.DarkRed,
        //    Position = new System.Drawing.Point(30, 30),
        //    Width = 50,
        //    Height = 50
        //};

        //Console.WriteLine("Фигура: " + f.Name);
        //Console.WriteLine("Площадь: " + f.GetArea());
        //Console.WriteLine("Цвет" + f.Color);
        //Console.WriteLine("Положение фигуры: " + f.Position);
        //Console.WriteLine("Координаты центра: " + f.GetCenter());

        Form frm = new Form()
        {
            Text = "Лабораторная работа #3 - Полиморфизм",
            Size = new System.Drawing.Size(800, 600),
            StartPosition = FormStartPosition.CenterScreen
        };

        frm.Paint += Frm_Paint;

        Application.Run(frm);
        }
        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
