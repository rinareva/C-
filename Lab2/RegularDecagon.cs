using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RegularDecagon : Figure
    {
        //формула правильного десятиугольника
        public double A { get; set; } //сторона десятиугольника

        public override double GetArea()
        {
            return ((5 * A * A) / 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
    }
}
