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
    public partial class esqueceu_senha : Form
    {
        public esqueceu_senha()
        {
            InitializeComponent();
        }
        string email_re;
        private void button1_Click(object sender, EventArgs e)
        {
            email_re= textBox1.Text;
            if(email_re == "")
            {
                MessageBox.Show("Preencha o campo Corretamente");

            }
            else
            {
                MessageBox.Show("EMAIL-RECUPERAÇAO DE SENHA " +
                    "SENHA:TESTE");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
