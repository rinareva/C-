using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Trapezoid : Figure
    {
        //формула трапеции через основания и высоту
        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }

        public override double GetArea()
        {
            return ((A + B) / 2) * H;
        }
    }
}
