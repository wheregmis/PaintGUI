using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_ASE
{
    public class DrawRectangle : IShape
    {
       

        public void Draw()
        {
           
            Console.WriteLine("You are in Rectangle");
            Rectangle rect1 = new Rectangle(50, 80, 100, 130); // rect1 object

            
        }
    }
}
