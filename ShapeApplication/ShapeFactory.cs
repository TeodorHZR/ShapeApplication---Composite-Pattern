using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public class ShapeFactory
    {
        public static Shape CreateShape(ShapeType type, Dictionary<string, object> parameters)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return CreateCircle(parameters);
                case ShapeType.Square:
                    return CreateSquare(parameters);
                case ShapeType.Rectangle:
                    return CreateRectangle(parameters);
                case ShapeType.Triangle:
                    return CreateTriangle(parameters);
                case ShapeType.Line:
                    return CreateLine(parameters);
                case ShapeType.Picture:
                    return CreatePicture(parameters);

            }

            return null;
        }

        public static Shape CreateCircle(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("radius") && parameters.ContainsKey("origin"))
            {
                var radius = (double)parameters["radius"];
                var origin = (Point2d)parameters["origin"];
                Circle.counter++;
                return new Circle() { Radius = radius, Origin = origin };
                
            }

            return null;
        }
        public static Shape CreateSquare(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("length") && parameters.ContainsKey("origin"))
            {
                var length = (double)parameters["length"];
                var origin = (Point2d)parameters["origin"];
                Square.counter++;
                return new Square() { Length = length, Origin = origin };
                
            }

            return null;
        }

        public static Shape CreateRectangle(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("point") && parameters.ContainsKey("origin"))
            {
                var _point = (Point2d)parameters["point"];
                var origin = (Point2d)parameters["origin"];
                Rectangle.counter++;
                return new Rectangle() { point = _point , Origin = origin };
            }

            return null;
        }

        public static Shape CreateTriangle(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("point1") && parameters.ContainsKey("point2") && parameters.ContainsKey("origin"))
            {
                var _point1 = (Point2d)parameters["point1"];
                var _point2 = (Point2d)parameters["point2"];
                var origin = (Point2d)parameters["origin"];
                Triangle.counter++;
                return new Triangle() { point1 = _point1, point2 = _point2, Origin = origin };
            }

            return null;
        }
        public static Shape CreateLine(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("EndPoint") && parameters.ContainsKey("origin"))
            {
                var _point = (Point2d)parameters["EndPoint"];
                var origin = (Point2d)parameters["origin"];
                Line.counter++;
                return new Line() { EndPoint = _point, Origin = origin };
            }

            return null;
        }
        public static Shape CreatePicture(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("name") && parameters.ContainsKey("children"))
            {
                var name = (string)parameters["name"];
                var children = (List<Shape>)parameters["children"];
                
                Picture.counter++;
                return new Picture() { Name = name, _children = children };

            }
            return null;
        }

    }

}
