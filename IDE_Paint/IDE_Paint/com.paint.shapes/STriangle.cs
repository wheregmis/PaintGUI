using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
   public class STriangle : IShape
    {
        int x, y, width;

        /// <summary>
        /// method to draw triangle 
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
           
          int distance = this.width;
            float angle = 0;

           // SolidBrush brs = new SolidBrush(Color.Black);
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            PointF[] p = new PointF[3];

            p[0].X = this.x;

            p[0].Y = this.y;

            p[1].Y = (int)(this.x + distance * Math.Cos(angle + Math.PI / 3));

            p[1].X = (int)(this.y + distance * Math.Sin(angle + Math.PI / 3));

            p[2].Y = (int)(this.x + distance * Math.Cos(angle - Math.PI / 3));

            p[2].X = (int)(this.y + distance * Math.Sin(angle - Math.PI / 3));

            g.DrawPolygon(myBlackPen, p);
        }

        /// <summary>
        /// method to set values for triangle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void SetParam(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
        }

        public void setPath(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// method to set points for triangle
        /// </summary>
        /// <param name="p"></param>
        public void setPoints(Point[] p)
        {
            throw new NotImplementedException();
        }
    }
}
