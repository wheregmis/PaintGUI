using IDE_Paint.com.paint.ui;
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
            //   validateCommand();   
            new PaintCanvas(txtCommand).Show();

        }

       
            private void txtTerminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("enter presseed");
            }
        }
    }
}
