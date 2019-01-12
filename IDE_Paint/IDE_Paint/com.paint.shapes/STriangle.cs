using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
    class STriangle : IShape
    {
        int x, y, width;
        public void Draw(Graphics g)
        {
            /*
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3
             };
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            // Draw polygon curve to screen.
            g.DrawPolygon(myBlackPen, curvePoints);
            */
           // float x = 50;
           // float y = 50;
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

        public void SetParam(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
        }

        public void setPoints(Point[] p)
        {
            throw new NotImplementedException();
        }
    }
}
