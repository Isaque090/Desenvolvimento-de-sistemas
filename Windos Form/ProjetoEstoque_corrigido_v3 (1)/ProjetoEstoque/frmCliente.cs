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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet1);

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MovePrevious();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.CancelEdit();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.AddNew();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Mantido vazio intencionalmente — edição feita diretamente na UI
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.RemoveCurrent();
            tb_clienteTableAdapter.Update(bancoDataSet1.tb_cliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_clienteBindingSource.EndEdit();
            tb_clienteTableAdapter.Update(bancoDataSet1.tb_cliente);
        }
    }
}
