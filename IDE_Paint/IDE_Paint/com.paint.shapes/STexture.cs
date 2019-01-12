using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_Paint.com.paint.shapes
{
    public class STexture : IShape
    {
        public int width, height;
        public string path;

        /// <summary>
        /// method to draw texture
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            Image image = Image.FromFile(this.path);
            TextureBrush tBrush = new TextureBrush(image);
            
            tBrush.Transform = new Matrix(
               75.0f / 640.0f,
               0.0f,
               0.0f,
               75.0f / 480.0f,
               0.0f,
               0.0f);
            g.FillEllipse(tBrush, new Rectangle(100, 150, this.width, this.height));
        }

        /// <summary>
        /// method to set values for texture
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void SetParam(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// method to set points for texture
        /// </summary>
        /// <param name="p"></param>
        public void setPoints(Point[] p)
        {
            throw new NotImplementedException();
        }
    }
}
