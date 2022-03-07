using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab3
{
    public class Triangle : Figure
    {
        //формула прямоугольного треугольника через катеты
        public double A { get; set; }
        public double B { get; set; }

        public override double GetArea()
        {
            return (A * B) / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + A / 2), (int)(Position.Y + B / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[3];
            points[0] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[1] = new Point((int)Position.X + 0, (int)Position.Y + (int)this.B);
            points[2] = new Point((int)Position.X + (int)this.A, Position.Y + (int)this.B);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
