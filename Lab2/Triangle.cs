using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Triangle : Figure
    {
        //формула прямоугольного треугольника через катеты
        public double A { get; set; }
        public double B { get; set; }

        public override double GetArea()
        {
            return (A * B) / 2;
        }
    }
}
