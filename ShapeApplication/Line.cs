using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShapeApplication
{
    public class Line : Shape
    {
        public Point2d EndPoint { get; set; }
        public static int counter = 0;
        //public string Name { get; set; }

        public Line()
        {
            this.Name = "Line" + counter.ToString();
        }
        public override double Area()
        {
            return 0;
        }

        public override void Draw(Panel panel)
        {
            if (panel != null)
            {
                using (Graphics g = panel.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawLine(pen, (float)Origin.X, (float)Origin.Y, (float)EndPoint.X, (float)EndPoint.Y);
                    g.DrawString(this.Name.ToString(), new Font("Arial", 6), Brushes.Black, (float)Origin.X, (float)Origin.Y);

                }
            }
        }

        public override void MoveTo(Point2d point)
        {
            EndPoint = new Point2d { X = EndPoint.X - Origin.X + point.X, Y = EndPoint.Y - Origin.Y + point.Y };
            Origin = point;
        }

        public override void Resize(double factor)
        {
            EndPoint = new Point2d { X = Convert.ToInt32(Origin.X + (EndPoint.X - Origin.X) * factor), Y = Convert.ToInt32(Origin.Y + (EndPoint.Y - Origin.Y) * factor) };
        }
    }
}
