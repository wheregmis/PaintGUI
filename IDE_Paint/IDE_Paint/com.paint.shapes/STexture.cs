﻿using System;
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
        public int width, height;
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
            g.FillEllipse(tBrush, new Rectangle(100, 150, this.width, this.height));
        }

        public void SetParam(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void setPoints(Point[] p)
        {
            throw new NotImplementedException();
        }
    }
}
