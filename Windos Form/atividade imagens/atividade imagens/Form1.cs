using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle=BorderStyle.None;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
                pictureBox1.Image = Properties.Resources.php;
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        
                pictureBox1.Image = Properties.Resources.images;
         
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                pictureBox1.Image = null;
       
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle =BorderStyle.FixedSingle;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Visible = true;
            }
            else { pictureBox1.Visible = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você Deseja Sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
