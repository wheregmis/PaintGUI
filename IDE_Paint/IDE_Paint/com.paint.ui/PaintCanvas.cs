using IDE_Paint.com.paint.factory;
using IDE_Paint.com.paint.shapes;
using MaterialSkin;
using MaterialSkin.Controls;
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
        //ellipse
        public Graphics g;
        String Shape;
        String txtCommand;
        int x, y, width, height, wid, hei, counter, x1, y1, checkcounter, incrementCircle, incrementRectangle, incrementvalue;

        /// <summary>
        /// place where the graphics are drawn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics; // get a reference to Graphics object

            /*
              int Length = txtCommand.Lines.Length;

            string[] text = new string[Length];

             for (int x = 1; x < Length; x++) {
                    text[x] = txtCommand.Lines[x].ToString();
                    String command = text[x].ToLower();
                   
                    string[] words = command.Split(' ');
                    
            }
             * 
             * */

            var result = txtCommand.Split(new[] { '\r', '\n' });

            int Length = result.Length;

            string[] text = new string[Length];
            string[] singleMultiple = new string[1];
            var wordstest = result[0].ToLower().Split(' ');
            singleMultiple[0] = wordstest[0].ToString();

            if (singleMultiple[0].ToLower().Equals("declare")){
                

                for (int x = 1; x < Length; x++) {
                    text[x] = result[x].ToString();
                    String command = text[x].ToLower();
                    //  String command = "Draw Rectangle 20,20 on x,y";
                    string[] words = command.Split(' ');

                    if (words[0].Equals("width"))
                    {
                        this.wid = Convert.ToInt32(words[2]);
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

                        if (words[1].Equals("ellipse"))
                        {
                            this.incrementCircle = Convert.ToInt32(words[2]);
                        }
                        if (words[1].Equals("rectangle"))
                        {
                            this.incrementRectangle = Convert.ToInt32(words[2]);
                        }


                    }

                    else if (words[0].Equals("ellipse"))
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
                            try
                            {
                                if (i.Equals(this.checkcounter))
                                {
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
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[1].ToUpper());
                                this.Close();
                            }


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
                            try
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
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[0].ToUpper());
                                this.Close();
                            }


                        }
                    }
                   
                }
                Console.WriteLine(this.wid + this.hei);
            }

            else {
                for (int x = 0; x < Length; x++)
                {
                    text[x] = result[x].ToString();
                    // MessageBox.Show(txtCommand.Lines[0].ToString());
                    String command = text[x].ToLower();
                    //  String command = "Draw Rectangle 20,20 on x,y";
                    string[] words = command.Split(' ');
                    if (words[0].Equals("draw"))
                    {
                        if (words[1].Equals("rectangle"))
                        {
                            //  new PaintCanvas(words[1].ToUpper(), words[2], words[4]).Show();
                            try {
                                DrawShape(words[1].ToUpper(), words[2], words[4]);
                                IShape shape2 = ShapeFactory.getShape(this.Shape);
                                shape2.SetParam(this.x, this.y, this.width, this.height);
                                shape2.Draw(g);
                            } catch(Exception ex) {
                                MessageBox.Show("Enter the full command for "+words[1].ToUpper());
                                this.Close();
                            }
                            

                        }
                        else if (words[1].Equals("ellipse"))
                        {

                            try
                            {
                                DrawShape(words[1].ToUpper(), words[2], words[4]);
                                IShape shape2 = ShapeFactory.getShape(this.Shape);
                                shape2.SetParam(this.x, this.y, this.width, this.height);
                                shape2.Draw(g);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[1].ToUpper());
                                this.Close();
                            }
                        }

                        else if (words[1].Equals("triangle"))
                        {
                            try
                            {
                                DrawShape(words[1].ToUpper(), words[2], words[4]);
                                IShape shape2 = ShapeFactory.getShape("TRIANGLE");
                                shape2.SetParam(this.x, this.y, this.width, this.height);
                                shape2.Draw(g);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[1].ToUpper());
                                this.Close();
                            }
                        }
                        else if (words[1].Equals("cube"))
                        {
                            try
                            {
                                DrawShape(words[1].ToUpper(), words[2] + "," + words[2], words[4]);
                                int param = Convert.ToInt32(words[2]);

                                IShape shape2 = ShapeFactory.getShape("CUBE");
                                shape2.SetParam(this.x, this.y, param, param);
                                shape2.Draw(g);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[1].ToUpper());
                                this.Close();
                            }
                        }
                        else if (words[1].Equals("polygon"))
                        {

                            //draw polygon 100,100 120,350 220,350 240,320
                           
                            List<Point> pointList = new List<Point>();
                          //  MessageBox.Show(words.Length.ToString());
                            for (int j = 2; j < words.Length; j++)
                            {
                                string[] points = words[j].Split(',');
                                pointList.Add(new Point(Convert.ToInt32( points[0]), Convert.ToInt32(points[1])));
                            }
                            
                            try
                            {
                                Point[] pointArray = pointList.ToArray();
                                IShape shape2 = ShapeFactory.getShape(words[1].ToUpper());
                                shape2.setPoints(pointArray);
                                // shape2.SetParam(this.x, this.y, this.width, this.height);
                                shape2.Draw(g);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[1].ToUpper());
                                this.Close();
                            }
                        }
                        else if (words[1].Equals("texture"))
                        {
                            try
                            {
                                DrawShape(words[1].ToUpper(), words[2], null);
                                IShape shape2 = ShapeFactory.getShape(words[1].ToUpper());
                                shape2.SetParam(0, 0, this.width, this.height);
                                shape2.setPath(words[3]);
                                shape2.Draw(g);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Enter the full command for " + words[1].ToUpper());
                                this.Close();
                            }
                        }

                    }
                    else if (words[0].Equals("repeat") || words[0].Equals("loop")) {
                        if (words[2].Equals("rectangle"))
                        {
                            //  new PaintCanvas(words[1].ToUpper(), words[2], words[4]).Show();

                            //repeat 4 rectangle width,height on x,y add 10
                            //repeat 4 rectangle 50,50 on 20,20 add 10
                            //repeat 4 rectangle 50,50 on 50,50 substract 10
                            DrawShape(words[2].ToUpper(), words[3], words[5]);
                            int wi = this.width;
                            int hi = this.height;

                            for (int i = 0; i < Convert.ToInt32(words[1]); i++)
                            {

                                try
                                {
                                    IShape shape3 = ShapeFactory.getShape(this.Shape);
                                    shape3.SetParam(this.x, this.y, wi, hi);
                                    if (words[6].Equals("add"))
                                    {
                                        Console.WriteLine(i);
                                        wi = wi + Convert.ToInt32(words[7]);
                                        hi = hi + Convert.ToInt32(words[7]);
                                        shape3.Draw(g);
                                    }
                                    else if (words[6].Equals("substract"))
                                    {
                                        Console.WriteLine(i);
                                        wi = wi - Convert.ToInt32(words[7]);
                                        hi = hi - Convert.ToInt32(words[7]);
                                        shape3.Draw(g);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Enter the full command for " + words[2].ToUpper());
                                    this.Close();
                                }

                            }

                        }
                        else if (words[2].Equals("ellipse"))
                        {
                            DrawShape(words[2].ToUpper(), words[3], words[5]);
                            int wi = this.width;
                            int hi = this.height;

                            for (int i = 0; i < Convert.ToInt32(words[1]); i++)
                            {

                                try
                                {
                                    IShape shape3 = ShapeFactory.getShape(this.Shape);
                                    shape3.SetParam(this.x, this.y, wi, hi);
                                    if (words[6].Equals("add"))
                                    {
                                        Console.WriteLine(i);
                                        wi = wi + Convert.ToInt32(words[7]);
                                        hi = hi + Convert.ToInt32(words[7]);
                                        shape3.Draw(g);
                                    }
                                    else if (words[6].Equals("substract"))
                                    {
                                        Console.WriteLine(i);
                                        wi = wi - Convert.ToInt32(words[7]);
                                        hi = hi - Convert.ToInt32(words[7]);
                                        shape3.Draw(g);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Enter the full command for " + words[2].ToUpper());
                                    this.Close();
                                }
                            }
                        }
                        else if (words[2].Equals("triangle"))
                        {
                            DrawShape(words[2].ToUpper(), words[3], words[5]);
                            int wi = this.width;
                            int hi = this.height;

                            for (int i = 0; i < Convert.ToInt32(words[1]); i++)
                            {
                                try
                                {

                                    IShape shape3 = ShapeFactory.getShape(this.Shape);
                                    shape3.SetParam(this.x, this.y, wi, hi);
                                    if (words[6].Equals("add"))
                                    {
                                        Console.WriteLine(i);
                                        wi = wi + Convert.ToInt32(words[7]);
                                        hi = hi + Convert.ToInt32(words[7]);
                                        shape3.Draw(g);
                                    }
                                    else if (words[6].Equals("substract"))
                                    {
                                        Console.WriteLine(i);
                                        wi = wi - Convert.ToInt32(words[7]);
                                        hi = hi - Convert.ToInt32(words[7]);
                                        shape3.Draw(g);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Enter the full command for " + words[2].ToUpper());
                                    this.Close();
                                }
                            }
                        }
                        
                    }
                    

                }
            }
        }
       
        /// <summary>
        /// initializing constructor
        /// </summary>
        /// <param name="command"></param>
        public PaintCanvas(String command) {
            InitializeComponent();
            this.txtCommand = command;
            

            //  validateCommand();
        }

        /// <summary>
        /// storing values in class variables
        /// </summary>
        /// <param name="Shape"></param>
        /// <param name="parameter"></param>
        /// <param name="axis"></param>
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
                    this.Close();
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

            if (axis == null)
            {

            }
            else {
                string[] point = axis.Split(',');
                try
                {
                    this.x = Convert.ToInt32(point[0]);
                    this.y = Convert.ToInt32(point[1]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Axis Invalid");
                }
            }
            
            

           
        }

        
    }
}
