using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_ASE
{
    public partial class picturebox : Form
    {
        String Shape;
        public picturebox(String Shape)
        {
           
            this.Shape = Shape;
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // get a reference to Graphics object

           // get an object of Rectangle and call its draw method.
                 IShape shape2 = ShapeFactory.getShape("RECTANGLE");
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object
            g.DrawRectangle(myBlackPen, shape2);

           // e.Graphics.DrawRectangle(Pens.Red, GetRectangle(sp, ep));




        }



    }
}
