using IDE_Paint.com.paint.factory;
using IDE_Paint.com.paint.shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_Paint.com.paint.ui
{
    public partial class PaintCanvas : Form
    {
        public Graphics g;
        String Shape;
        RichTextBox txtCommand;
        int x, y, width, height, wid, hei, counter, x1, y1, checkcounter, incrementCircle, incrementRectangle, incrementvalue;

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics; // get a reference to Graphics object

            int Length = txtCommand.Lines.Length;

            string[] text = new string[Length];
            string[] singleMultiple = new string[1];
            singleMultiple[0] = txtCommand.Lines[0].ToString();

            if (singleMultiple[0].ToLower().Equals("declare")){
                MessageBox.Show("Welcome to declare");

                /* 
Declare
Width = 20
Height = 20
X = 10
Y = 10
Loop 4
if counter = 2 add 20
Circle + 10
End Loop
                 */

                for (int x = 1; x < Length; x++) {
                    text[x] = txtCommand.Lines[x].ToString();
                    String command = text[x].ToLower();
                    //  String command = "Draw Rectangle 20,20 on x,y";
                    string[] words = command.Split(' ');
                    
                    if (words[0].Equals("width")){
                        this.wid = Convert.ToInt32( words[2]);
                    }
                    else if (words[0].Equals("height"))
                    {
                        this.hei = Convert.ToInt32(words[2]);
                    }
                    else if (words[0].Equals("x"))
                    {
                        this.x1 = Convert.ToInt32(words[2]);
                    }
                    else if (words[0].Equals("y"))
                    {
                        this.y1 = Convert.ToInt32(words[2]);
                    }
                    else if (words[0].Equals("loop"))
                    {
                        this.counter = Convert.ToInt32(words[1]);
                    }
                    else if (words[0].Equals("if"))
                    {
                        this.checkcounter = Convert.ToInt32(words[3]);
                        this.incrementCircle = this.incrementRectangle = Convert.ToInt32(words[5]);
                    }
                    else if (words[0].Equals("startif"))
                    {
                        this.checkcounter = Convert.ToInt32(words[3]);
                     //   this.incrementCircle = this.incrementRectangle = Convert.ToInt32(words[3]);
                    }

                    else if (words[0].Equals("add"))
                    {
                       
                        if (words[1].Equals("circle")){
                            this.incrementCircle = Convert.ToInt32(words[2]);
                        }
                        if (words[1].Equals("rectangle")){
                            this.incrementRectangle = Convert.ToInt32(words[2]);
                        }
                        
                        
                    }

                    else if (words[0].Equals("circle"))
                    {
                        int wi = this.wid;
                        int hi = this.hei;
                        int xaxis = this.x1;
                        int yaxis = this.y1;
                        string param = wi+","+hi;
                        string axis = xaxis+","+yaxis;
                        string shape = words[0];
                        this.incrementvalue = Convert.ToInt32( words[2]);
                        for (int i = 0; i < this.counter; i++)
                        {
                            if (i.Equals(this.checkcounter)) { 
                                this.incrementvalue = this.incrementCircle;
                            }
                            Console.WriteLine(i);
                            DrawShape(shape.ToUpper(), param, axis);
                            IShape shape3 = ShapeFactory.getShape(this.Shape);
                            shape3.SetParam(this.x, this.y, wi, hi);
                            wi = wi + this.incrementvalue;
                            hi = hi + this.incrementvalue;
                            shape3.Draw(g);

                        }
                    }
                    else if (words[0].Equals("rectangle"))
                    {

                        int wi = this.wid;
                        int hi = this.hei;
                        int xaxis = this.x1;
                        int yaxis = this.y1;
                        string param = wi + "," + hi;
                        string axis = xaxis + "," + yaxis;
                        string shape = words[0];
                        this.incrementvalue = Convert.ToInt32(words[2]);
                        for (int i = 0; i < this.counter; i++)
                        {
                            if (i.Equals(this.checkcounter))
                            {
                                this.incrementvalue = this.incrementRectangle;
                            }
                            Console.WriteLine(i);
                            DrawShape(shape.ToUpper(), param, axis);
                            IShape shape3 = ShapeFactory.getShape(this.Shape);
                            shape3.SetParam(this.x, this.y, wi, hi);
                            wi = wi + this.incrementvalue;
                            hi = hi + this.incrementvalue;
                            shape3.Draw(g);

                        }
                    }


                }
                Console.WriteLine(this.wid + this.hei);
            }

            else {
                for (int x = 0; x < Length; x++)
                {
                    text[x] = txtCommand.Lines[x].ToString();
                    // MessageBox.Show(txtCommand.Lines[0].ToString());
                    String command = text[x].ToLower();
                    //  String command = "Draw Rectangle 20,20 on x,y";
                    string[] words = command.Split(' ');
                    if (words[0].Equals("draw"))
                    {
                        if (words[1].Equals("rectangle"))
                        {
                            //  new PaintCanvas(words[1].ToUpper(), words[2], words[4]).Show();

                            DrawShape(words[1].ToUpper(), words[2], words[4]);
                            IShape shape2 = ShapeFactory.getShape(this.Shape);
                            shape2.SetParam(this.x, this.y, this.width, this.height);
                            shape2.Draw(g);

                        }
                        else if (words[1].Equals("circle"))
                        {
                            //   PaintCanvas pc = new PaintCanvas();
                            //   pc.DrawShape(words[1].ToUpper(), words[2], words[4]);

                            //  new PaintCanvas(words[1].ToUpper(), words[2], words[4]).Show();
                            DrawShape(words[1].ToUpper(), words[2], words[4]);
                            IShape shape2 = ShapeFactory.getShape(this.Shape);
                            shape2.SetParam(this.x, this.y, this.width, this.height);
                            shape2.Draw(g);
                        }

                        else if (words[1].Equals("triangle"))
                        {
                            //   PaintCanvas pc = new PaintCanvas();
                            //   pc.DrawShape(words[1].ToUpper(), words[2], words[4]);

                            //  new PaintCanvas(words[1].ToUpper(), words[2], words[4]).Show();
                            DrawShape(words[1].ToUpper(), words[2], words[4]);

                            IShape shape2 = ShapeFactory.getShape("TRIANGLE");
                            shape2.SetParam(this.x, this.y, this.width, this.height);
                            shape2.Draw(g);
                        }

                    }
                    else if (words[0].Equals("repeat") || words[0].Equals("loop")) {
                        if (words[2].Equals("rectangle"))
                        {
                            //  new PaintCanvas(words[1].ToUpper(), words[2], words[4]).Show();

                            //repeat 4 rectangle width,height on x,y add 10
                            //repeat 4 rectangle 50,50 on 20,20 add 10


                            int wi = this.width;
                            int hi = this.height;
                            for (int i = 0; i < Convert.ToInt32(words[1]); i++)
                            {
                                Console.WriteLine(i);
                                DrawShape(words[2].ToUpper(), words[3], words[5]);
                                IShape shape3 = ShapeFactory.getShape(this.Shape);
                                shape3.SetParam(this.x, this.y, wi, hi);
                                wi = wi + Convert.ToInt32(words[7]);
                                hi = hi + Convert.ToInt32(words[7]);
                                shape3.Draw(g);


                            }

                        }
                        else if (words[2].Equals("circle"))
                        {
                            int wi = this.width;
                            int hi = this.height;
                            for (int i = 0; i < Convert.ToInt32(words[1]); i++)
                            {
                                Console.WriteLine(i);
                                DrawShape(words[2].ToUpper(), words[3], words[5]);
                                IShape shape3 = ShapeFactory.getShape(this.Shape);
                                shape3.SetParam(this.x, this.y, wi, hi);
                                wi = wi + Convert.ToInt32(words[7]);
                                hi = hi + Convert.ToInt32(words[7]);
                                shape3.Draw(g);

                            }
                        }
                    }

                }
            }
        }
       

        public PaintCanvas(RichTextBox command) {
            InitializeComponent();
            this.txtCommand = command;
          //  validateCommand();
        }

        public void DrawShape(String Shape, String parameter, String axis) {
            this.Shape = Shape;
            
            string[] param = parameter.Split(',');
            Console.WriteLine(parameter);
            Console.WriteLine(Shape);
            Console.WriteLine(axis);
            if (param.Length > 1)
            {
                try {
                    this.width = Convert.ToInt32(param[0]);
                    this.height = Convert.ToInt32(param[1]);
                } catch (Exception) {
                    MessageBox.Show("Parameter Invalid");
                }
                
            }
            else {
                try {
                    this.width = Convert.ToInt32(param[0]);
                    this.height = 0;
                } catch (Exception) {
                    MessageBox.Show("Parameter Invalid");
                }
               
            }
            

            string[] point = axis.Split(',');
            try {
                this.x = Convert.ToInt32(point[0]);
                this.y = Convert.ToInt32(point[1]);
            } catch (Exception) {
                MessageBox.Show("Axis Invalid");
            }
            

           
        }

        
    }
}
