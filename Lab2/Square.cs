using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Square()
        {
            if (!Height.Equals(Width))
                throw new Exception();
        }

        public override double GetArea()
        {
            return Height * Width;
        }
    }
}
