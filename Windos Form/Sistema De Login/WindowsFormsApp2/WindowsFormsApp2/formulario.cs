using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }
        string email, senha;
        private void button1_Click(object sender, EventArgs e)
        {

            home ob = new home();

            email = textBox1.Text;
            senha= textBox2.Text;
            if (email == "" && senha == "")
            {

                MessageBox.Show("Campos estao vazios");
                
            }
          else  if (email == "isaque@gmail.com" && senha=="teste")
            {
              

                ob.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha Invalidos");
              
            }

        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            esqueceu_senha senha= new esqueceu_senha();

            senha.Show();
        }

        private void formulario_Load(object sender, EventArgs e)
        {
          
        }
    }
}
