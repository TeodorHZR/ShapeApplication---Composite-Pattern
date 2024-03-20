using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShapeApplication
{
    public class Picture : Shape
    {
        public List<Shape> _children;
        //public string Name { get; set; }
        public static int counter = 0;

        public Picture()
        {
            _children = new List<Shape>();
            this.Name = "Picture" + counter.ToString();
        }

        public override void Draw(Panel panel)
        {
            foreach (var c in _children)
            {
                c.Draw(panel);
            }
        }

        public override void Resize(double factor)
        {
            foreach (var c in _children)
            {
                c.Resize(factor);
            }
        }

        public override void MoveTo(Point2d point)
        {
            
            foreach (var child in _children)
            {
               
                child.MoveTo(point);
            }
        }


        public override double Area()
        {
            double totalArea = 0;
            foreach (var c in _children)
            {
                totalArea += c.Area();
            }
            return totalArea;
        }

        public override void AddChild(Shape child)
        {
            _children.Add(child);
        }
    }
}
