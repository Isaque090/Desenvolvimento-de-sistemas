using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstoque
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();                                                                                                                                                                           
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
         
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.RemoveCurrent();
            tb_usuarioTableAdapter.Update(bancoDataSet1.tb_usuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(bancoDataSet1.tb_usuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        tb_usuarioBindingSource.CancelEdit();
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet1);

        }

        private void cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
