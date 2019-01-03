using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
    class SCircle : IShape
    {
        private int y;
        private int x;
        private int width;
        private int height;

        public void Draw(Graphics g)
        {
           
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            g.DrawEllipse(myBlackPen, this.x, this.y, this.width, this.height);

           
        }

        public void SetParam(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
