using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    public class Trapezoid : Figure
    {
        //формула трапеции через основания и высоту
        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }

        public override double GetArea()
        {
            return ((A + B) / 2) * H;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + A / 2), (int)(Position.Y + H / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[4];
            points[3] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[2] = new Point((int)Position.X, (int)Position.Y + (int)H);
            points[1] = new Point((int)Position.X + (int)B, (int)Position.Y + (int)H);
            points[0] = new Point((int)Position.X + (int) + (int)A, (int)Position.Y + 0);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
