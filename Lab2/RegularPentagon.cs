using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RegularPentagon : Figure
    {
        //формула правильного пятиугольника 
        public double A { get; set; } //сторона пятиугольника

        public override double GetArea()
        {
            return ((A * A) / 4) * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }
    }
}
