using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
    class SCube : IShape
    {
        private int y;
        private int x;
        private int width;
        private int height;
        public void Draw(Graphics g)
        {
            Console.WriteLine(this.height.ToString());
          //  Rectangle rect1 = new Rectangle(this.x, this.y, this.width, this.height); // rect1 object

           Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
          //  g.DrawRectangle(myBlackPen, rect1);


             // height of the cube (y-axis)
            int skew = 20;
            Point Org = new Point(this.x, this.y);
            
            SolidBrush brush = new SolidBrush(Color.LightBlue);
            Rectangle R = new Rectangle(Org.X, Org.Y, this.width, this.height);
            Rectangle R2 = new Rectangle(Org.X + skew, Org.Y - skew, this.width, this.height);
           
           
            // draw cube 100,100 on 100,100

            PointF p = new Point(Org.X, Org.Y);
            PointF p1 = new Point(Org.X + skew, Org.Y - skew);

            PointF p2 = new Point(Org.X + width, Org.Y + width);
            PointF p3 = new Point(Org.X + skew + width, Org.Y - skew + width);

            PointF p4 = new Point(Org.X , Org.Y + width);
            PointF p5 = new Point(Org.X + skew, Org.Y + width -skew);

           

            PointF p6= new Point(Org.X + height, Org.Y);
            PointF p7 = new Point(Org.X + height+skew, Org.Y-skew);
            // PointF p7 = new Point(Org.X+height, Org.Y + width);

            g.DrawRectangle(myBlackPen, R);
            g.DrawRectangle(myBlackPen, R2);
            g.DrawLine(myBlackPen, p, p1);
            g.DrawLine(myBlackPen, p2, p3);
            g.DrawLine(myBlackPen, p4, p5);
            g.DrawLine(myBlackPen, p6, p7);
        }

        public void SetParam(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void setPoints(PointF p)
        {
            throw new NotImplementedException();
        }
    }
}
