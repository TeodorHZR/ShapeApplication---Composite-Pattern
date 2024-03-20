using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShapeApplication
{
    public class GraphicTool
    {
        public List<Shape> Shapes { get; private set; }

        public GraphicTool()
        {
            Shapes = new List<Shape>();
        }

        //add
        public void Add(ShapeType type, Dictionary<string, object> parameters)
        {
            var newShape = ShapeFactory.CreateShape(type, parameters);

            if (newShape != null)
            {
                Shapes.Add(newShape);
            }
        }

        //remove
        public void Remove(Shape shape)
        {
            Shapes.Remove(shape);
        }

        //drawAll
        public void DrawAll(Panel panel)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(panel);
            }
        }
    }
}
