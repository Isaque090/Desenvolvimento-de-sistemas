namespace CadastroCliente
{
    partial class FrmCadastroCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblTelRes;
        private System.Windows.Forms.TextBox txtTelRes;
        private System.Windows.Forms.Label lblTelCel;
        private System.Windows.Forms.TextBox txtTelCel;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.CheckBox chkFacebook;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.CheckBox chkTwitter;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblTelRes = new System.Windows.Forms.Label();
            this.txtTelRes = new System.Windows.Forms.TextBox();
            this.lblTelCel = new System.Windows.Forms.Label();
            this.txtTelCel = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.chkFacebook = new System.Windows.Forms.CheckBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.chkTwitter = new System.Windows.Forms.CheckBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.grpDadosPessoais.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(16, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1013, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Cliente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.lblCodigo);
            this.grpDadosPessoais.Controls.Add(this.txtCodigo);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.lblRG);
            this.grpDadosPessoais.Controls.Add(this.txtRG);
            this.grpDadosPessoais.Controls.Add(this.lblCPF);
            this.grpDadosPessoais.Controls.Add(this.txtCPF);
            this.grpDadosPessoais.Controls.Add(this.lblTelRes);
            this.grpDadosPessoais.Controls.Add(this.txtTelRes);
            this.grpDadosPessoais.Controls.Add(this.lblTelCel);
            this.grpDadosPessoais.Controls.Add(this.txtTelCel);
            this.grpDadosPessoais.Controls.Add(this.grpSexo);
            this.grpDadosPessoais.Controls.Add(this.picFoto);
            this.grpDadosPessoais.Controls.Add(this.btnCarregarImagem);
            this.grpDadosPessoais.Controls.Add(this.btnLimparImagem);
            this.grpDadosPessoais.Location = new System.Drawing.Point(16, 80);
            this.grpDadosPessoais.Margin = new System.Windows.Forms.Padding(4);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Padding = new System.Windows.Forms.Padding(4);
            this.grpDadosPessoais.Size = new System.Drawing.Size(1013, 209);
            this.grpDadosPessoais.TabIndex = 1;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(20, 34);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(20, 69);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 22);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 65);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(505, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblRG
            // 
            this.lblRG.Location = new System.Drawing.Point(20, 103);
            this.lblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(93, 22);
            this.lblRG.TabIndex = 4;
            this.lblRG.Text = "R.G.:";
            this.lblRG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(120, 100);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(199, 22);
            this.txtRG.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.Location = new System.Drawing.Point(333, 103);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(67, 22);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "C.P.F.:";
            this.lblCPF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(407, 100);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(219, 22);
            this.txtCPF.TabIndex = 7;
            // 
            // lblTelRes
            // 
            this.lblTelRes.Location = new System.Drawing.Point(0, 138);
            this.lblTelRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelRes.Name = "lblTelRes";
            this.lblTelRes.Size = new System.Drawing.Size(113, 22);
            this.lblTelRes.TabIndex = 8;
            this.lblTelRes.Text = "Tel. Residencial:";
            this.lblTelRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelRes
            // 
            this.txtTelRes.Location = new System.Drawing.Point(120, 134);
            this.txtTelRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelRes.Name = "txtTelRes";
            this.txtTelRes.Size = new System.Drawing.Size(199, 22);
            this.txtTelRes.TabIndex = 9;
            // 
            // lblTelCel
            // 
            this.lblTelCel.Location = new System.Drawing.Point(327, 138);
            this.lblTelCel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelCel.Name = "lblTelCel";
            this.lblTelCel.Size = new System.Drawing.Size(93, 22);
            this.lblTelCel.TabIndex = 10;
            this.lblTelCel.Text = "Tel. Celular:";
            this.lblTelCel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelCel
            // 
            this.txtTelCel.Location = new System.Drawing.Point(427, 134);
            this.txtTelCel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.Size = new System.Drawing.Size(199, 22);
            this.txtTelCel.TabIndex = 11;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Controls.Add(this.rdbFeminino);
            this.grpSexo.Location = new System.Drawing.Point(120, 162);
            this.grpSexo.Margin = new System.Windows.Forms.Padding(4);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Padding = new System.Windows.Forms.Padding(4);
            this.grpSexo.Size = new System.Drawing.Size(320, 37);
            this.grpSexo.TabIndex = 12;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.Location = new System.Drawing.Point(13, 12);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(113, 22);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.Text = "Masculino";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.Location = new System.Drawing.Point(147, 12);
            this.rdbFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(113, 22);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.Text = "Feminino";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(860, 31);
            this.btnCarregarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(140, 49);
            this.btnCarregarImagem.TabIndex = 14;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.Location = new System.Drawing.Point(860, 111);
            this.btnLimparImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(140, 49);
            this.btnLimparImagem.TabIndex = 15;
            this.btnLimparImagem.Text = "Limpar Imagem";
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.lblLogradouro);
            this.grpEndereco.Controls.Add(this.txtLogradouro);
            this.grpEndereco.Controls.Add(this.lblNumero);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.lblEstado);
            this.grpEndereco.Controls.Add(this.txtEstado);
            this.grpEndereco.Location = new System.Drawing.Point(16, 302);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(4);
            this.grpEndereco.Size = new System.Drawing.Size(1013, 111);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // lblCEP
            // 
            this.lblCEP.Location = new System.Drawing.Point(20, 34);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(80, 22);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            this.lblCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(107, 31);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(145, 22);
            this.txtCEP.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Location = new System.Drawing.Point(267, 34);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(93, 22);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(367, 31);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(619, 22);
            this.txtLogradouro.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(20, 71);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(80, 22);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número:";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(107, 68);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(105, 22);
            this.txtNumero.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.Location = new System.Drawing.Point(227, 71);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(67, 22);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(300, 68);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(239, 22);
            this.txtBairro.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.Location = new System.Drawing.Point(553, 71);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 22);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(627, 68);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(225, 22);
            this.txtCidade.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(860, 71);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 22);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(933, 68);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(52, 22);
            this.txtEstado.TabIndex = 11;
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.lblEmail);
            this.grpExtras.Controls.Add(this.txtEmail);
            this.grpExtras.Controls.Add(this.chkEmail);
            this.grpExtras.Controls.Add(this.lblFacebook);
            this.grpExtras.Controls.Add(this.txtFacebook);
            this.grpExtras.Controls.Add(this.chkFacebook);
            this.grpExtras.Controls.Add(this.lblTwitter);
            this.grpExtras.Controls.Add(this.txtTwitter);
            this.grpExtras.Controls.Add(this.chkTwitter);
            this.grpExtras.Location = new System.Drawing.Point(16, 425);
            this.grpExtras.Margin = new System.Windows.Forms.Padding(4);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Padding = new System.Windows.Forms.Padding(4);
            this.grpExtras.Size = new System.Drawing.Size(1013, 135);
            this.grpExtras.TabIndex = 3;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Dados Extras";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 34);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(113, 31);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(719, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // chkEmail
            // 
            this.chkEmail.Location = new System.Drawing.Point(860, 32);
            this.chkEmail.Margin = new System.Windows.Forms.Padding(4);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(133, 22);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "E-Mail";
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // lblFacebook
            // 
            this.lblFacebook.Location = new System.Drawing.Point(20, 69);
            this.lblFacebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(87, 22);
            this.lblFacebook.TabIndex = 3;
            this.lblFacebook.Text = "Facebook:";
            this.lblFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Enabled = false;
            this.txtFacebook.Location = new System.Drawing.Point(113, 65);
            this.txtFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(719, 22);
            this.txtFacebook.TabIndex = 4;
            // 
            // chkFacebook
            // 
            this.chkFacebook.Location = new System.Drawing.Point(860, 66);
            this.chkFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.chkFacebook.Name = "chkFacebook";
            this.chkFacebook.Size = new System.Drawing.Size(133, 22);
            this.chkFacebook.TabIndex = 5;
            this.chkFacebook.Text = "Facebook";
            this.chkFacebook.CheckedChanged += new System.EventHandler(this.chkFacebook_CheckedChanged);
            // 
            // lblTwitter
            // 
            this.lblTwitter.Location = new System.Drawing.Point(20, 103);
            this.lblTwitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(87, 22);
            this.lblTwitter.TabIndex = 6;
            this.lblTwitter.Text = "Twitter:";
            this.lblTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Enabled = false;
            this.txtTwitter.Location = new System.Drawing.Point(113, 100);
            this.txtTwitter.Margin = new System.Windows.Forms.Padding(4);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(719, 22);
            this.txtTwitter.TabIndex = 7;
            // 
            // chkTwitter
            // 
            this.chkTwitter.Location = new System.Drawing.Point(860, 101);
            this.chkTwitter.Margin = new System.Windows.Forms.Padding(4);
            this.chkTwitter.Name = "chkTwitter";
            this.chkTwitter.Size = new System.Drawing.Size(133, 22);
            this.chkTwitter.TabIndex = 8;
            this.chkTwitter.Text = "Twitter";
            this.chkTwitter.CheckedChanged += new System.EventHandler(this.chkTwitter_CheckedChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(27, 578);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(147, 39);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(193, 578);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(147, 39);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(360, 578);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(147, 39);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(527, 578);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 39);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(693, 578);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 39);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(860, 578);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(147, 39);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::CadastroCliente.Properties.Resources.code_583795_1280;
            this.picFoto.Location = new System.Drawing.Point(666, 23);
            this.picFoto.Margin = new System.Windows.Forms.Padding(4);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(186, 166);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 13;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 641);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
