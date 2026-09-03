using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FrmCadastroCliente : Form
    {
      
        
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

       
        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            picFoto.Image = Properties.Resources.code_583795_1280 ;
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            if (picFoto.Image != null)
            {
                picFoto.Image.Dispose();
                picFoto.Image = null;
            }
        }

       

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = chkEmail.Checked;
            if (!chkEmail.Checked) txtEmail.Clear();
        }

        private void chkFacebook_CheckedChanged(object sender, EventArgs e)
        {
            txtFacebook.Enabled = chkFacebook.Checked;
            if (!chkFacebook.Checked) txtFacebook.Clear();
        }

        private void chkTwitter_CheckedChanged(object sender, EventArgs e)
        {
            txtTwitter.Enabled = chkTwitter.Checked;
            if (!chkTwitter.Checked) txtTwitter.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
          
            txtNome.Text = "Isaque Severo Ferreira";
            txtRG.Text = "34.567.890-1";
            txtCPF.Text = "123.456.789-00";
            txtTelRes.Text = "(11) 3456-7890";
            txtTelCel.Text = "(11) 98765-4321";
            rdbFeminino.Checked = true;

            txtCEP.Text = "01310-100";
            txtLogradouro.Text = "Avenida Paulista";
            txtNumero.Text = "1578";
            txtBairro.Text = "Bela Vista";
            txtCidade.Text = "São Paulo";
            txtEstado.Text = "SP";

            chkEmail.Checked = true;
            txtEmail.Text = "isaque@gmail.com";
            chkFacebook.Checked = true;
            txtFacebook.Text = "facebook.com/isaque";
            chkTwitter.Checked = true;
            txtTwitter.Text = "@isaque";

            picFoto.Image =Properties.Resources.code_583795_1280;

          
            MessageBox.Show("Cliente incluído com sucesso!", "Incluir",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente para alterar.", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
        }

     
        private void btnConsultar_Click(object sender, EventArgs e)
        {
     
        }

      
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente excluído com sucesso!", "Excluir",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            foreach (TextBox t in new[] { txtCodigo, txtNome, txtRG, txtCPF, txtTelRes, txtTelCel,
                                          txtCEP, txtLogradouro, txtNumero, txtBairro, txtCidade,
                                          txtEstado, txtEmail, txtFacebook, txtTwitter })
                t.Clear();

            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;

            chkEmail.Checked = false;
            chkFacebook.Checked = false;
            chkTwitter.Checked = false;

            if (picFoto.Image != null)
            {
                picFoto.Image.Dispose();
                picFoto.Image = null;
            }

            txtCodigo.Focus();
        }

       
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
