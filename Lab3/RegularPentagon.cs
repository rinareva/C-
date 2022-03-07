using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    public class RegularPentagon : Figure
    {
        //формула правильного пятиугольника 
        public double A { get; set; } //сторона пятиугольника
        public double Radius { get; set; } //радиус пятиугольника
        public override double GetArea()
        {
            return ((A * A) / 4) * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[5];
            for (int a = 0; a < 5; a++)
            {
                points[a] = new Point(
                    (int)(Position.X + Radius * (float)Math.Cos(a * 72 * Math.PI / 180f)),
                    (int)(Position.Y + Radius * (float)Math.Sin(a * 72 * Math.PI / 180f)));
            }

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
