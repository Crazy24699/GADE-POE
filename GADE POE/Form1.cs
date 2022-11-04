using GADEpart1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public partial class Form1 : Form
    {
        public bool UpInput, DownInput, LeftInput, RightInput;
        public bool CanMove;        //If the player is able to move, if there arent any obstacles in the way. 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.W == Keys.KeyCode)
            {
                UpInput = true;
            }
            if (Keys.S == Keys.KeyCode)
            {
                DownInput = true;
            }
            if (Keys.A == Keys.KeyCode)
            {
                LeftInput = true;
            }
            if (Keys.D == Keys.KeyCode)
            {
                RightInput = true;
            }



        }

        public void HandlePlayerMovement()
        {


            if (CanMove)
            {
                if (RightInput)
                {
                    var movements = Characters.Movements.Right;
                }
                if (LeftInput)
                {
                    var movements = Characters.Movements.Left;
                }
                if (UpInput)
                {
                    var movements = Characters.Movements.Up;
                }
                if (DownInput)
                {
                    var movements = Characters.Movements.Down;
                }
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {

        }

        private void Up_Click(object sender, EventArgs e)
        {

        }

        private void b2_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

        }




        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
