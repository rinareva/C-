using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    public class Rhomb : Figure
    {
        //формула ромба через его диагонали
        public double d1 { get; set; }
        public double d2 { get; set; }

        public override double GetArea()
        {
            return (d1 * d2) / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + d1 / 2), (int)(Position.Y + d2 / 2));
        }

        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[4];
            points[0] = new Point((int)Position.X + 0, (int)Position.Y + (int)d1 / 2);
            points[1] = new Point((int)Position.X + ((int)d2 / 2), (int)Position.Y + 0);
            points[2] = new Point((int)Position.X + (int)d2, (int)Position.Y + ((int)d1 / 2));
            points[3] = new Point((int)Position.X + ((int)d2 / 2), (int)Position.Y + (int)d1);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
