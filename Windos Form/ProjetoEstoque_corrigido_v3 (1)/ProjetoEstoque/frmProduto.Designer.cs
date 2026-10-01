namespace ProjetoEstoque
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.Windows.Forms.Label sg_unidade_venda_produtoLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            this.bancoDataSet1 = new ProjetoEstoque.bancoDataSet1();
            this.tb_produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_produtosTableAdapter = new ProjetoEstoque.bancoDataSet1TableAdapters.tb_produtosTableAdapter();
            this.tableAdapterManager = new ProjetoEstoque.bancoDataSet1TableAdapters.TableAdapterManager();
            this.tb_produtosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_produtosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.sg_unidade_venda_produtoTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            sg_unidade_venda_produtoLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtosBindingNavigator)).BeginInit();
            this.tb_produtosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bancoDataSet1
            // 
            this.bancoDataSet1.DataSetName = "bancoDataSet1";
            this.bancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_produtosBindingSource
            // 
            this.tb_produtosBindingSource.DataMember = "tb_produtos";
            this.tb_produtosBindingSource.DataSource = this.bancoDataSet1;
            // 
            // tb_produtosTableAdapter
            // 
            this.tb_produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_produtosTableAdapter = this.tb_produtosTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoEstoque.bancoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_produtosBindingNavigator
            // 
            this.tb_produtosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_produtosBindingNavigator.BindingSource = this.tb_produtosBindingSource;
            this.tb_produtosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_produtosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_produtosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_produtosBindingNavigatorSaveItem});
            this.tb_produtosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_produtosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_produtosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_produtosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_produtosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_produtosBindingNavigator.Name = "tb_produtosBindingNavigator";
            this.tb_produtosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_produtosBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tb_produtosBindingNavigator.TabIndex = 0;
            this.tb_produtosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tb_produtosBindingNavigatorSaveItem
            // 
            this.tb_produtosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_produtosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_produtosBindingNavigatorSaveItem.Image")));
            this.tb_produtosBindingNavigatorSaveItem.Name = "tb_produtosBindingNavigatorSaveItem";
            this.tb_produtosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_produtosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_produtosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_produtosBindingNavigatorSaveItem_Click);
            // 
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_produtoLabel.Location = new System.Drawing.Point(244, 70);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(94, 26);
            cd_produtoLabel.TabIndex = 1;
            cd_produtoLabel.Text = "Produto:";
            cd_produtoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtosBindingSource, "cd_produto", true));
            this.cd_produtoTextBox.Location = new System.Drawing.Point(348, 76);
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_produtoTextBox.TabIndex = 2;
            this.cd_produtoTextBox.TextChanged += new System.EventHandler(this.cd_produtoTextBox_TextChanged);
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_produtoLabel.Location = new System.Drawing.Point(261, 96);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(77, 26);
            nm_produtoLabel.TabIndex = 3;
            nm_produtoLabel.Text = "Nome:";
            nm_produtoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            nm_produtoLabel.Click += new System.EventHandler(this.nm_produtoLabel_Click);
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtosBindingSource, "nm_produto", true));
            this.nm_produtoTextBox.Location = new System.Drawing.Point(348, 103);
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nm_produtoTextBox.TabIndex = 4;
            // 
            // sg_unidade_venda_produtoLabel
            // 
            sg_unidade_venda_produtoLabel.AutoSize = true;
            sg_unidade_venda_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_unidade_venda_produtoLabel.Location = new System.Drawing.Point(203, 123);
            sg_unidade_venda_produtoLabel.Name = "sg_unidade_venda_produtoLabel";
            sg_unidade_venda_produtoLabel.Size = new System.Drawing.Size(139, 26);
            sg_unidade_venda_produtoLabel.TabIndex = 5;
            sg_unidade_venda_produtoLabel.Text = "Uni. Produto:";
            sg_unidade_venda_produtoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            sg_unidade_venda_produtoLabel.Click += new System.EventHandler(this.sg_unidade_venda_produtoLabel_Click);
            // 
            // sg_unidade_venda_produtoTextBox
            // 
            this.sg_unidade_venda_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtosBindingSource, "sg_unidade_venda_produto", true));
            this.sg_unidade_venda_produtoTextBox.Location = new System.Drawing.Point(348, 129);
            this.sg_unidade_venda_produtoTextBox.Name = "sg_unidade_venda_produtoTextBox";
            this.sg_unidade_venda_produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sg_unidade_venda_produtoTextBox.TabIndex = 6;
            this.sg_unidade_venda_produtoTextBox.TextChanged += new System.EventHandler(this.sg_unidade_venda_produtoTextBox_TextChanged);
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_custoLabel.Location = new System.Drawing.Point(267, 148);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(75, 26);
            vl_custoLabel.TabIndex = 7;
            vl_custoLabel.Text = "Custo:";
            vl_custoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            vl_custoLabel.Click += new System.EventHandler(this.vl_custoLabel_Click);
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtosBindingSource, "vl_custo", true));
            this.vl_custoTextBox.Location = new System.Drawing.Point(348, 154);
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vl_custoTextBox.TabIndex = 8;
            this.vl_custoTextBox.TextChanged += new System.EventHandler(this.vl_custoTextBox_TextChanged);
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_vendaLabel.Location = new System.Drawing.Point(261, 174);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(81, 26);
            vl_vendaLabel.TabIndex = 9;
            vl_vendaLabel.Text = "Venda:";
            vl_vendaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtosBindingSource, "vl_venda", true));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(350, 180);
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vl_vendaTextBox.TabIndex = 10;
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.Location = new System.Drawing.Point(246, 200);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(98, 26);
            qt_estoqueLabel.TabIndex = 11;
            qt_estoqueLabel.Text = "Estoque:";
            qt_estoqueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            qt_estoqueLabel.Click += new System.EventHandler(this.qt_estoqueLabel_Click);
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtosBindingSource, "qt_estoque", true));
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(350, 206);
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.qt_estoqueTextBox.TabIndex = 12;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(606, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 34);
            this.button9.TabIndex = 29;
            this.button9.Text = "Sair";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(223, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 34);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(92, 310);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(121, 34);
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(223, 310);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(121, 34);
            this.btnProximo.TabIndex = 26;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(348, 310);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 34);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(348, 358);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 34);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(479, 358);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 34);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(479, 310);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 34);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(606, 310);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 34);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(92, 358);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 34);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(sg_unidade_venda_produtoLabel);
            this.Controls.Add(this.sg_unidade_venda_produtoTextBox);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.vl_vendaTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Controls.Add(this.tb_produtosBindingNavigator);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtosBindingNavigator)).EndInit();
            this.tb_produtosBindingNavigator.ResumeLayout(false);
            this.tb_produtosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bancoDataSet1 bancoDataSet1;
        private System.Windows.Forms.BindingSource tb_produtosBindingSource;
        private bancoDataSet1TableAdapters.tb_produtosTableAdapter tb_produtosTableAdapter;
        private bancoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_produtosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_produtosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox sg_unidade_venda_produtoTextBox;
        private System.Windows.Forms.TextBox vl_custoTextBox;
        private System.Windows.Forms.TextBox vl_vendaTextBox;
        private System.Windows.Forms.TextBox qt_estoqueTextBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}