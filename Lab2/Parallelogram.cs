using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Parallelogram : Figure
    {
        //формула параллелограмма через высоту, проведенную к стороне
        public double A { get; set; } //сторона параллелограмма
        public double H { get; set; } //высота параллелграмма

        public override double GetArea()
        {
            return A * H;
        }
    }
}
