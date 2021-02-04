using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideapro_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox_user.Text == "222")
            {
                guna2CirclePictureBox_prof.Image = Properties.Resources.R4dl8Rb;
                guna2Transition1.Show(guna2CirclePictureBox_prof);

            }
            if (guna2TextBox_user.Text == "111")
            {
                guna2CirclePictureBox_prof.Image = Properties.Resources.pexels_photo_415829;
                guna2Transition1.Show(guna2CirclePictureBox_prof);


            }
            if (guna2TextBox_user.Text == "333")
            {
                guna2CirclePictureBox_prof.Image = Properties.Resources._475605E3_69C5_4D2B_8727_61B7BB8C4699_500w;
                guna2Transition1.Show(guna2CirclePictureBox_prof);

            }
            else guna2CirclePictureBox_prof.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2Panel_signup.FillColor.A==200)
            {
                timer1.Stop();
                guna2Panel3.Visible = true;

            }
            guna2Panel_signup.FillColor = Color.FromArgb(guna2Panel_signup.FillColor.A + 5, 255, 0, 0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
            guna2Panel_signup.FillColor = Color.FromArgb(0, 255, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
