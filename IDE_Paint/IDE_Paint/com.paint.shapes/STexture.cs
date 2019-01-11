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
    class STexture : IShape
    {
        public void Draw(Graphics g)
        {
            Image image = Image.FromFile("C:/Users/xawbe/Pictures/1.jpg");
            TextureBrush tBrush = new TextureBrush(image);
            
            tBrush.Transform = new Matrix(
               75.0f / 640.0f,
               0.0f,
               0.0f,
               75.0f / 480.0f,
               0.0f,
               0.0f);
            g.FillEllipse(tBrush, new Rectangle(100, 150, 150, 250));
        }

        public void SetParam(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void setPoints(PointF p)
        {
            throw new NotImplementedException();
        }
    }
}
