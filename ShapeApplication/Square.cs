using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeApplication
{
    public class Square : Shape
    {
        public double Length { get; set; }
        public static int counter=0;
        //public string Name { get; set; }
        public Square()
        {
            
            this.Name = "Square" + counter.ToString();
            
        }
        public override double Area()
        {
            return Length*Length;
        }

        public override void Draw(Panel panel)
        {
            if (panel != null)
            {
                using (Graphics g = panel.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawRectangle(pen, (float)Origin.X, (float)Origin.Y, (float)Length, (float)Length);
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
            Length *= factor;
        }
    }
}
