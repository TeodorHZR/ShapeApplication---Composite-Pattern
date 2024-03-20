using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeApplication
{
    public class Triangle : Shape
    {
        public Point2d point1 { get; set; }
        public Point2d point2 { get; set; }
        public static int counter = 0;

        //public string Name { get; set; }
        public Triangle() 
        {
            this.Name = "Triangle" + counter.ToString();
        }
        public override double Area()
        {
            // Calculate the area of the triangle using the shoelace formula
            double a = point1.X * point2.Y;
            double b = point2.X * Origin.Y;
            double c = Origin.X * point1.Y;
            double d = point1.X * Origin.Y;
            double e = point2.X * point1.Y;
            double f = Origin.X * point2.Y;
            return Math.Abs(0.5 * (a + b + c - d - e - f));
        }

        public override void Draw(Panel panel)
        {
            if (panel != null)
            {
                using (Graphics g = panel.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawLine(pen, (float)Origin.X, (float)Origin.Y, (float)point1.X, (float)point1.Y);
                    g.DrawLine(pen, (float)point1.X, (float)point1.Y, (float)point2.X, (float)point2.Y);
                    g.DrawLine(pen, (float)point2.X, (float)point2.Y, (float)Origin.X, (float)Origin.Y);
                    g.DrawString(this.Name.ToString(), new Font("Arial", 6), Brushes.Black, (float)Origin.X, (float)Origin.Y);

                }
            }
        }

        public override void MoveTo(Point2d point)
        {
            double xDiff = point.X - Origin.X;
            double yDiff = point.Y - Origin.Y;

            Origin = point;
            point1 = new Point2d { X = Convert.ToInt32(point1.X + xDiff), Y = Convert.ToInt32(point1.Y + yDiff) };
            point2 =new Point2d { X = Convert.ToInt32(point2.X + xDiff), Y = Convert.ToInt32(point2.Y + yDiff) };
        }


        public override void Resize(double factor)
        {
            point1.X = Convert.ToInt32(Origin.X + factor * (point1.X - Origin.X));
            point1.Y = Convert.ToInt32(Origin.Y + factor * (point1.Y - Origin.Y));
            point2.X = Convert.ToInt32(Origin.X + factor * (point2.X - Origin.X));
            point2.Y = Convert.ToInt32(Origin.Y + factor * (point2.Y - Origin.Y));
        }
    }
}