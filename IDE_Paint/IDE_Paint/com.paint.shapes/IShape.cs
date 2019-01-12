using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.com.paint.shapes
{
   public interface IShape
    {
        /// <summary>
        /// method that needs to be implemented on the shapes
        /// </summary>
        /// <param name="g"></param>
        void Draw(Graphics g);

        /// <summary>
        /// method that needs to be implemented on the shapes
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void SetParam(int x, int y, int width, int height);

        /// <summary>
        ///  method that needs to be implemented on the shapes
        /// </summary>
        /// <param name="p"></param>
        void setPoints(Point[] p);

        /// <summary>
        /// method that needs to be implemented on the shapes
        /// </summary>
        /// <param name="path"></param>
        void setPath(String path);
    }
}
