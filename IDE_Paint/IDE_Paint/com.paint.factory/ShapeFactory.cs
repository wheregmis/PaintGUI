using IDE_Paint.com.paint.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.factory
{
    public class ShapeFactory
    {
        //use getShape method to get object of type shape 
        public static IShape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("ELLIPSE"))
            {
                return new SEllipse();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new SRectangle();

            }
            else if (shapeType.Equals("TRIANGLE"))
            {
                return new STriangle();

            }
            else if (shapeType.Equals("CUBE"))
            {
                return new SCube();

            }
            else if (shapeType.Equals("POLYGON"))
            {
                return new SPolygon();

            }
            else if (shapeType.Equals("TEXTURE"))
            {
                return new STexture();

            }

            return null;
        }
    }
}
