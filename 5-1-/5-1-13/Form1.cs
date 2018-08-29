using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _5_1_13
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay =200;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(180-(180-2*72));
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
            {
                Turtle.Forward(i*10+20);
                Turtle.Rotate(60);

            }
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 37; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(170);
            }
        }

        private void buttonTriangle3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; j++)
            {


                for (int i = 0; i < 23; i++)
                {
                    Turtle.Forward(i * 10 + 20);
                    Turtle.Rotate(120);
                }
            }
        }
    }
}
