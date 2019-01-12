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
    public partial class CommandList : Form
    {
        public CommandList()
        {
            InitializeComponent();
            string command = @"

//drawing command
Draw Rectangle 20,20 on 10,10
Draw Ellipse 20,20 on 10,10
draw texture 100,100
draw polygon 100,100 120,350 220,350 240,320

//drawing equalatoral triangle
Draw triangle 20 on 10,10

//drawing cube
Draw cube 20 on 10,10

//repeat command you can either add/substract
repeat 4 rectangle 50,50 on 20,20 add 10
repeat 4 ellipse 50,50 on 20,20 add 10
repeat 4 triangle 50 on 20,20 add 10


//Single line looping command
Loop 4 rectangle 50,50 on 20,20 add 10
Loop 4 ellipse 50,50 on 20,20 add 10
repeat 4 triangle 50 on 20,20 add 10

//multi line looping command using single if command
Declare
Width = 20
Height = 20
X = 10
Y = 10
Loop 4
if counter = 2 add 20
Ellipse + 10
Rectangle + 20
End Loop

//multiline looping command using if block command
Declare
Width = 20
Height = 20
X = 10
Y = 10
Loop 4
startif counter = 2 
add Ellipse 20
add rectangle 20
endif
Ellipse + 10
Rectangle + 20
End Loop

";
            richTextBox1.Text = command;
            richTextBox1.ReadOnly = true;
        }
    }
}
