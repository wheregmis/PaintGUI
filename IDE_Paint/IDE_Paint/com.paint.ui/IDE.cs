using IDE_Paint.com.paint.ui;
using MaterialSkin.Controls;
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
       
        public formIDE()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Boolean syntaxChecked = SyntaxChecker();
            if (syntaxChecked)
            {
                new PaintCanvas(txtCommand).Show();
            }
            
            

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

        private void txtTerminal_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Enter)
            {
                
                
            }
            /*
            txtOutput.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                
                    if (txtTerminal.Text.Equals("run"))
                    {
                    new PaintCanvas(txtCommand).Show();
                    }
                    else
                    {
                        txtOutput.Text = "Invalid Command for terminal";
                        txtOutput.ReadOnly = true;
                    }

                
            }
            */


        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            
        }

        public bool SyntaxChecker() {
            Boolean test = false;
            string paramPattern = @"((\d+),(\d+))";
            string[] syntax = new string[2];
            syntax[0] = "draw";
            syntax[1] = "test";
            String command = txtCommand.Text.ToLower();
            //  String command = "Draw Rectangle 20,20 on x,y";
            string[] words = command.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("This is "+i);
                bool isparameterValid = Regex.IsMatch(words[i], paramPattern);

                if (!isparameterValid) {
                    
                        var target = words[i];
                        var results = Array.Exists(syntax, s => s.Equals(target));
                        if (results)
                        {
                        test = true;
                            
                        }
                        else {
                        
                            test = false;
                            txtOutput.Text = "Invalid Command " + words[i];
                            return test;
                        
                        }
                }
                else
                {
                    test = true;
                }
    
             }
            
            return test;

        }
    }
}
