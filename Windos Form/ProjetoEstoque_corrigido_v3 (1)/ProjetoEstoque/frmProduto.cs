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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void tb_produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet1);
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_produtosBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_produtosBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_produtosBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_produtosBindingSource.RemoveCurrent();
            tb_produtosTableAdapter.Update(bancoDataSet1.tb_produtos);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_produtosBindingSource.EndEdit();
            tb_produtosTableAdapter.Update(bancoDataSet1.tb_produtos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_produtosBindingSource.CancelEdit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vl_custoLabel_Click(object sender, EventArgs e)
        {

        }

        private void vl_custoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_unidade_venda_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_unidade_venda_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void qt_estoqueLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}