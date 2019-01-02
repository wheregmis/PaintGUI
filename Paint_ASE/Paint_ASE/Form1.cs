using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_ASE
{
    public partial class Form1 : Form
    {
        public int x, y;
        public Form1()
        {
            InitializeComponent();

            Vertex vertex;
            Vertex.Parse("323, 44, 55", out vertex);

            this.Text = vertex.ToString();

        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", x, y);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
           

        }

        public void DrawRect(Graphics g) {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String command = txtCommand.Text;
            String command = "Rectangle 20,20";
            string[] words = command.Split(' ');
            String test = words[1];
            Console.WriteLine(test);

            string[] param = test.Split(',');
            Console.WriteLine(param[1]);

            if (words[0].Equals("Rectangle")){
                ShapeFactory shapeFactory = new ShapeFactory();

                //get an object of Circle and call its draw method.
                   IShape shape1 = ShapeFactory.getShape("RECTANGLE");
                this.Hide();
                new picturebox("RECTANGLE").Show();
            }

            /*
            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }  */

            /*
            Boolean SyntaxValidation = new ParseSyntax().TestSyntax(command);
            if (SyntaxValidation) {
                ShapeFactory shapeFactory = new ShapeFactory();


                //get an object of Rectangle and call its draw method.
                IShape shape2 = shapeFactory.getShape("RECTANGLE");

                //call draw method of Rectangle
                shape2.Draw();
            }

    */
        }
    }
}
