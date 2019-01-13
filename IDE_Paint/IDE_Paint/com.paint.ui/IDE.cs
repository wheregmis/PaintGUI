using IDE_Paint.com.paint.exception;
using IDE_Paint.com.paint.ui;
using MaterialSkin;
using MaterialSkin.Controls;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_Paint
{
    public partial class formIDE : MaterialForm
    {
        public int x, y;
        public string Syntaxcommand;
        
        public formIDE()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey800, Accent.Green400,
                TextShade.WHITE
            );

        }

        /// <summary>
        /// action after run button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
           
            

           
           // Boolean syntaxChecked = SyntaxValidation(txtCommand);
            Boolean syntaxChecked = SyntaxValidating(txtCommand.Text);
            if (syntaxChecked)
            {
                new PaintCanvas(txtCommand.Text).Show();
            }
            
           

        }

        public bool SyntaxValidating(String command) {
            Boolean test = false;
            var result = command.Split(new[] { '\r', '\n' });
            for (int j = 0; j < result.Length; j++)
            {
                string paramPattern = @"((\d+),(\d+))";
                string parampattern1 = @"(^\d+$)";
                string[] syntax = new string[] { "draw", "if","declare width", "counter", "+", "-", "=", "repeat", "substract", "triangle", "rectangle", "on", "cube", "polygon", "texture", "ellipse", "loop", "add", "declare", "width", "height", "x", "y", "end", "startif", "endif", "" };



                var words = result[j].ToLower().Split(' ');


                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i] + " " + i);
                    bool isparameterValid = Regex.IsMatch(words[i], paramPattern);
                    bool isparameterValid1 = Regex.IsMatch(words[i], parampattern1);
                    if (!isparameterValid)
                    {
                        var target = words[i];
                        var results = Array.Exists(syntax, s => s.Equals(target));
                        if (results)
                        {
                            test = true;

                        }
                        else
                        {
                            string curFile = words[i];
                            string paramPatterntest1 = @"((\d+\w),(\w\d+))";
                            string paramPatterntest2 = @"(([a-zA-Z]\d+[a-zA-Z]),([a-zA-Z]\d+[a-zA-Z]))";
                            bool isparameterValidcheck1 = Regex.IsMatch(words[i], paramPatterntest1);
                            bool isparameterValidcheck2 = Regex.IsMatch(words[i], paramPatterntest2);

                            if (isparameterValid1)
                            {
                                test = true;

                            }
                            else if (File.Exists(curFile))
                            {
                                test = true;
                            }
                            else if (isparameterValidcheck1 || isparameterValidcheck2)
                            {
                                test = false;
                                txtOutput.Text = "Invalid Parameter " + words[i];
                                return test;

                            }
                            else
                            {
                                test = false;
                                txtOutput.Text = "Invalid Command " + words[i];
                                return test;

                            }


                        }
                    }
                   
                }

            }return test;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SaveFileDialog save = new SaveFileDialog();

            save.FileName = "DefaultOutputName.txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());

              writer.Write(txtCommand.Text);
                
                writer.Dispose();

                writer.Close();
                MessageBox.Show("Code Sucessfully Exported");


            }
        }

        

        private void importToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCommand.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

     
        

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = "";
          
            
        }

        /// <summary>
        /// action to run the code after run command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTerminal_KeyDown(object sender, KeyEventArgs e)
        {
            txtOutput.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtTerminal.Text.Equals(""))
                {
                    string[] terminal = txtTerminal.Text.Split(' ');
                    if (terminal.Length.Equals(1) && txtTerminal.Text.Equals("run"))
                    {
                        if (SyntaxValidating(txtCommand.Text)) {
                            new PaintCanvas(txtCommand.Text).Show();
                        }
                        

                    } else if (terminal[0].Equals("run")) {
                        if (File.Exists(terminal[1]))
                        {
                            try {
                                String command = File.ReadAllText(terminal[1], Encoding.UTF8);
                                if (SyntaxValidating(command))
                                {
                                    new PaintCanvas(command).Show();
                                }
                            }
                            catch (Exception ep) {
                                MessageBox.Show("File is not a text file or corrupted, Can't Read the file");
                            }
                            
                        }
                        else {
                            try {
                                throw new PathException("Invalid Path");
                            } catch (PathException ex) {
                               
                            }
                            
                        }
                        
                    }
                    else
                    {
                        txtOutput.Text = "Invalid Command for terminal";
                        txtOutput.ReadOnly = true;
                    }
                    
                }
                else {
                    MessageBox.Show("Please enter a command");
                }
                


            }
        }
        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private const int NUMBER_MARGIN = 1;

        private void commandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CommandList().Show();
        }

        private void InitColors()
        {

            txtCommand.SetSelectionBackColor(true, IntToColor(0x114D9C));

        }

        private void InitSyntaxColoring()
        {

            // Configure the default style
            txtCommand.StyleResetDefault();
            txtCommand.Styles[Style.Default].Font = "Consolas";
            txtCommand.Styles[Style.Default].Size = 10;
            txtCommand.Styles[Style.Default].BackColor = IntToColor(0x212121);
            txtCommand.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            txtCommand.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            txtCommand.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            txtCommand.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            txtCommand.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            txtCommand.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            txtCommand.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            txtCommand.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            txtCommand.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            txtCommand.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            txtCommand.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            txtCommand.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            txtCommand.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            txtCommand.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            txtCommand.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            txtCommand.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            txtCommand.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            txtCommand.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            txtCommand.Lexer = Lexer.Cpp;

            txtCommand.SetKeywords(0, "draw repeat loop");
            txtCommand.SetKeywords(1, "rectangle ellipse triangle polygon texture cube");

        }
        private const int BACK_COLOR = 0x2A211C;
        private const int FORE_COLOR = 0xB7B7B7;
        private void InitNumberMargin()
        {

            txtCommand.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            txtCommand.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            txtCommand.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            txtCommand.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = txtCommand.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {



            // Boolean syntaxChecked = SyntaxValidation(txtCommand);
            Boolean syntaxChecked = SyntaxValidating(txtCommand.Text);
            if (syntaxChecked)
            {
                new PaintCanvas(txtCommand.Text).Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "DefaultOutputName.txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());

                writer.Write(txtCommand.Text);

                writer.Dispose();

                writer.Close();
                MessageBox.Show("Code Sucessfully Exported");


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCommand.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new CommandList().Show();
        }

        private void formIDE_Load(object sender, EventArgs e)
        {
           
            txtCommand.TextChanged += (this.txtCommand_TextChanged);

            // INITIAL VIEW CONFIG
            txtCommand.WrapMode = WrapMode.None;
            txtCommand.IndentationGuides = IndentView.LookBoth;

            // STYLING
            InitColors();
            InitSyntaxColoring();

            // NUMBER MARGIN
            InitNumberMargin();


        }

       
       
    }
}
