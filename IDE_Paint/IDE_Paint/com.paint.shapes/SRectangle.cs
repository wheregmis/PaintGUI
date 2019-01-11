using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
    class SRectangle : IShape
    {

        private int y;
        private int x;
        private int width;
        private int height;
        
        public void SetParam(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }

        public void Draw(Graphics g)
        {

            Console.WriteLine(this.width.ToString());
            Rectangle rect1 = new Rectangle(this.x, this.y, this.width, this.height); // rect1 object

            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            g.DrawRectangle(myBlackPen, rect1);
            

        }

        public void setPoints(PointF p)
        {
            throw new NotImplementedException();
        }
    }
}

