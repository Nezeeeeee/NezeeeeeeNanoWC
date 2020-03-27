using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoWC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            btn1.Visible = false;
            label1.Text = "Добро пожаловать!";
            pictureBox1.BackgroundImage = Properties.Resources.cen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            ControlBox = false;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(cb1.Checked == false)
            {
                label1.Text = "Сначало смойте потом выходиите!";

            }
            else
            {
                label1.Text = "Счастливого пути!";
                pictureBox1.BackgroundImage = Properties.Resources.nano;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                ControlBox = true;
                panel3.Visible = false;
                cb1.Checked = false;
                btn1.Visible = true;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Версия NanoWC: 0.01");
        }

        
    }
}
