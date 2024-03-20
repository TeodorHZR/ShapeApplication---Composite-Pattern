using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeApplication
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public static int counter = 0;
        
        //public string Name { get; set; }

        public Circle()
        {
           this.Name = "Circle" + counter.ToString();
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw(Panel panel)
        {
            if (panel != null)
            {
                using (Graphics g = panel.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawEllipse(pen, (float)(Origin.X - Radius), (float)(Origin.Y - Radius), (float)(2 * Radius), (float)(2 * Radius));
                    g.DrawString(this.Name.ToString(), new Font("Arial", 6), Brushes.Black, (float)Origin.X, (float)Origin.Y);
                }
            }
        }

        public override void MoveTo(Point2d point)
        {
            Origin = point;
        }

        public override void Resize(double factor)
        {
            Radius *= factor;
        }
    }
}
