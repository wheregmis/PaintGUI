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
        void Draw(Graphics g);
        void SetParam(int x, int y, int width, int height);
        void setPoints(PointF p);
    }
}
