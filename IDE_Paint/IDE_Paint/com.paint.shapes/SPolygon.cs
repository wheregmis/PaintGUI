using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
    public class SPolygon : IShape
    {
        Point[] curvePoints;

        /// <summary>
        /// method to draw polygon in picturebox
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
           
            // Draw polygon curve to screen.
            g.DrawPolygon(myBlackPen, this.curvePoints);
        }

        /// <summary>
        /// method to set values for polygon
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void SetParam(int x, int y, int width, int height)
        {
           
        }

        public void setPath(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// method to set points for polygon
        /// </summary>
        /// <param name="p"></param>
        public void setPoints(Point[] p)
        {
            this.curvePoints = p;
        }
    }
}
