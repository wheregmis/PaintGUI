using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_ASE
{
    public class Circle : IShape
    {
        public void Draw()
        {
           Console.WriteLine("You are in Circle");
        }
    }
}
