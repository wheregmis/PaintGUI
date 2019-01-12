using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
   public class SEllipse : IShape
    {
        private int y;
        private int x;
        private int width;
        private int height;

        /// <summary>
        /// method to graw ellipse on the picturebox
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
           
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            g.DrawEllipse(myBlackPen, this.x, this.y, this.width, this.height);

           
        }

        /// <summary>
        /// method to set values for ellipse
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
            this.height = height;
        }

        public void setPath(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// method to set points for ellipse
        /// </summary>
        /// <param name="p"></param>
        public void setPoints(Point[] p)
        {
            throw new NotImplementedException();
        }
    }
}
