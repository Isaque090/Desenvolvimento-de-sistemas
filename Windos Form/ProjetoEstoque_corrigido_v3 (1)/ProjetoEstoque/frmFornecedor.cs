using ProjetoEstoque.bancoDataSet1TableAdapters;
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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet1);

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            tb_fornecedorBindingSource.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(bancoDataSet1.tb_fornecedor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_fornecedorBindingSource.EndEdit();
            tb_fornecedorTableAdapter.Update(bancoDataSet1.tb_fornecedor);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            tb_fornecedorBindingSource.CancelEdit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
