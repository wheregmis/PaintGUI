using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
    class SPolygon : IShape
    {
        Point[] curvePoints;
        public void Draw(Graphics g)
        {
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            /*
            PointF point1 = new PointF(50.0F, 50.0F);
            PointF point2 = new PointF(100.0F, 25.0F);
            PointF point3 = new PointF(200.0F, 5.0F);
            PointF point4 = new PointF(250.0F, 50.0F);
            PointF point5 = new PointF(300.0F, 100.0F);
            PointF point6 = new PointF(350.0F, 200.0F);
            PointF point7 = new PointF(250.0F, 250.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

    */
            // Draw polygon curve to screen.
            g.DrawPolygon(myBlackPen, this.curvePoints);
        }

        public void SetParam(int x, int y, int width, int height)
        {
           
        }

        public void setPoints(Point[] p)
        {
            this.curvePoints = p;
        }
    }
}
