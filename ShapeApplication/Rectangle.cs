using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeApplication
{
    public class Rectangle : Shape
    {
        public Point2d point;
        public static int counter = 0;
     
        //public string Name { get; set; }
        public Rectangle()
        {
            this.Name = "Rectangle" + counter.ToString();
        }
        public override double Area()
        {
            //    return ((b.Getx()-_origin.Getx()) *(a.Gety()-_origin.Gety()));

            return (point.X - Origin.X) * (point.Y - Origin.Y);
        }


        public override void Draw(Panel panel)
        {
            if (panel != null)
            {
                using (Graphics g = panel.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawRectangle(pen, (float)Origin.X, (float)Origin.Y, (float)(point.X - Origin.X), (float)(point.Y - Origin.Y));
                    g.DrawString(this.Name.ToString(), new Font("Arial", 6), Brushes.Black, (float)Origin.X, (float)Origin.Y);
                }
            }
        }

        public override void MoveTo(Point2d point)
        {
            double width = point.X - Origin.X;
            double height = point.Y - Origin.Y;

            this.Origin = point;
            this.point = new Point2d { X = Convert.ToInt32(this.Origin.X + width), Y = Convert.ToInt32(this.Origin.Y + height) };
        }


        public override void Resize(double factor)
        {
            double newWidth = (point.X - Origin.X) * factor;
            double newHeight = (point.Y - Origin.Y) * factor;

            point.X = Convert.ToInt32(Origin.X + newWidth);
            point.Y = Convert.ToInt32(Origin.Y + newHeight);
        }
    }
}


