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
Command For Terminal
//to run the code
run

// run the file by giving path
run C:/Users/xawbe/Documents/rectangle.txt

Command For Graphics
//drawing command
draw Rectangle 20,20 on 10,10
draw Ellipse 20,20 on 10,10
draw texture 100,100 C:/Users/xawbe/Pictures/1.jpg
draw polygon 100,100 120,350 220,350 240,320

//drawing equalatoral triangle
draw triangle 20 on 10,10

//drawing cube
draw cube 20 on 10,10

//repeat command you can either add/substract
repeat 4 rectangle 50,50 on 20,20 add 10
repeat 4 ellipse 50,50 on 20,20 add 10
repeat 4 triangle 50 on 20,20 add 10


//Single line looping command
loop 4 rectangle 50,50 on 20,20 add 10
loop 4 ellipse 50,50 on 20,20 add 10
loop 4 triangle 50 on 20,20 add 10

//multi line looping command using single if command
declare
width = 20
height = 20
x = 10
y = 10
loop 4
if counter = 2 add 20
ellipse + 10
rectangle + 20
end loop

//multiline looping command using if block command
declare
width = 20
height = 20
x = 10
y = 10
loop 4
startif counter = 2 
add ellipse 20
add rectangle 20
endif
ellipse + 10
rectangle + 20
end loop

";
            richTextBox1.Text = command;
            richTextBox1.ReadOnly = true;
        }
    }
}
