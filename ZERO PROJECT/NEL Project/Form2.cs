using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form1 parentForm;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label7.Visible = !label7.Visible;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }
    }
}
