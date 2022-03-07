using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    public class Parallelogram : Figure
    {
        //формула параллелограмма через высоту, проведенную к стороне
        public double A { get; set; } //сторона параллелограмма
        public double H { get; set; } //высота параллелграмма

        public override double GetArea()
        {
            return A * H;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + A / 2), (int)(Position.Y + H / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[4];
            points[0] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[3] = new Point((int)Position.X + (int)A, (int)Position.Y + 0);
            points[1] = new Point((int)Position.X + 20, (int)Position.Y + (int)H);
            points[2] = new Point((int)Position.X + (int)A + 20, (int)Position.Y + (int)H);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
