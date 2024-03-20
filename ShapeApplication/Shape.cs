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
    public abstract class Shape
    {
        public Point2d Origin { get; set; }
        public string Name { get; set; }

        public abstract void Draw(Panel panel);
        public abstract void Resize(double factor);
        public abstract void MoveTo(Point2d point);
        public abstract double Area();
        public virtual void AddChild(Shape child)
        {
            throw new NotImplementedException();
        }

    }
}
