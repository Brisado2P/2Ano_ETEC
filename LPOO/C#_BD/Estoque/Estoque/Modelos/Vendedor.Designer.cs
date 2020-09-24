namespace Estoque
{
    partial class frmCadAltVendedor
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
            this.dgvVend = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDataRegistro = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtxtDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gpbVerVendedores = new System.Windows.Forms.GroupBox();
            this.lblTituloVendedores = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pctConsultar = new System.Windows.Forms.PictureBox();
            this.txtBuscarVendedor = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpbCadatrarVendedor = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.cmbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarVendedor = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pcbCadAltVend = new System.Windows.Forms.PictureBox();
            this.lblCadAltVend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVend)).BeginInit();
            this.gpbVerVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
            this.gpbCadatrarVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadAltVend)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVend
            // 
            this.dgvVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVend.Location = new System.Drawing.Point(31, 106);
            this.dgvVend.Name = "dgvVend";
            this.dgvVend.Size = new System.Drawing.Size(792, 104);
            this.dgvVend.TabIndex = 11;
            this.dgvVend.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVend_CellContentDoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Purple;
            this.txtNome.Location = new System.Drawing.Point(145, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 25);
            this.txtNome.TabIndex = 15;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Purple;
            this.txtEndereco.Location = new System.Drawing.Point(145, 125);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(197, 25);
            this.txtEndereco.TabIndex = 16;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ForeColor = System.Drawing.Color.Purple;
            this.txtSalario.Location = new System.Drawing.Point(569, 125);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(124, 25);
            this.txtSalario.TabIndex = 17;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(203, 104);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(86, 18);
            this.lblEndereco.TabIndex = 20;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(218, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(599, 104);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(64, 18);
            this.lblSalario.TabIndex = 22;
            this.lblSalario.Text = "Salario";
            // 
            // lblDataRegistro
            // 
            this.lblDataRegistro.AutoSize = true;
            this.lblDataRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRegistro.Location = new System.Drawing.Point(385, 37);
            this.lblDataRegistro.Name = "lblDataRegistro";
            this.lblDataRegistro.Size = new System.Drawing.Size(142, 18);
            this.lblDataRegistro.TabIndex = 24;
            this.lblDataRegistro.Text = "Data de Registro";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(595, 37);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 18);
            this.lblTelefone.TabIndex = 25;
            this.lblTelefone.Text = "Telefone";
            // 
            // mtxtDataRegistro
            // 
            this.mtxtDataRegistro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataRegistro.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataRegistro.Location = new System.Drawing.Point(392, 62);
            this.mtxtDataRegistro.Mask = "00/00/0000";
            this.mtxtDataRegistro.Name = "mtxtDataRegistro";
            this.mtxtDataRegistro.Size = new System.Drawing.Size(124, 25);
            this.mtxtDataRegistro.TabIndex = 26;
            this.mtxtDataRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataRegistro.ValidatingType = typeof(System.DateTime);
            this.mtxtDataRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDataRegistro_KeyPress);
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone.ForeColor = System.Drawing.Color.Purple;
            this.mtxtTelefone.Location = new System.Drawing.Point(569, 61);
            this.mtxtTelefone.Mask = "000009999";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(124, 25);
            this.mtxtTelefone.TabIndex = 27;
            this.mtxtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelefone_KeyPress);
            // 
            // gpbVerVendedores
            // 
            this.gpbVerVendedores.Controls.Add(this.lblTituloVendedores);
            this.gpbVerVendedores.Controls.Add(this.btnMostrar);
            this.gpbVerVendedores.Controls.Add(this.pctConsultar);
            this.gpbVerVendedores.Controls.Add(this.txtBuscarVendedor);
            this.gpbVerVendedores.Controls.Add(this.lblBuscar);
            this.gpbVerVendedores.Controls.Add(this.dgvVend);
            this.gpbVerVendedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVerVendedores.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gpbVerVendedores.Location = new System.Drawing.Point(12, 73);
            this.gpbVerVendedores.Name = "gpbVerVendedores";
            this.gpbVerVendedores.Size = new System.Drawing.Size(851, 226);
            this.gpbVerVendedores.TabIndex = 28;
            this.gpbVerVendedores.TabStop = false;
            this.gpbVerVendedores.Text = "Ver Vendedores";
            // 
            // lblTituloVendedores
            // 
            this.lblTituloVendedores.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblTituloVendedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVendedores.ForeColor = System.Drawing.Color.White;
            this.lblTituloVendedores.Location = new System.Drawing.Point(31, 68);
            this.lblTituloVendedores.Name = "lblTituloVendedores";
            this.lblTituloVendedores.Size = new System.Drawing.Size(792, 35);
            this.lblTituloVendedores.TabIndex = 54;
            this.lblTituloVendedores.Text = "                                       Vendedores Cadastrados";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(683, 27);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 31);
            this.btnMostrar.TabIndex = 52;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // pctConsultar
            // 
            this.pctConsultar.BackColor = System.Drawing.Color.DarkMagenta;
            this.pctConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctConsultar.Enabled = false;
            this.pctConsultar.Image = global::Estoque.Properties.Resources.loupe_79257;
            this.pctConsultar.Location = new System.Drawing.Point(522, 19);
            this.pctConsultar.Name = "pctConsultar";
            this.pctConsultar.Size = new System.Drawing.Size(33, 33);
            this.pctConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConsultar.TabIndex = 50;
            this.pctConsultar.TabStop = false;
            this.pctConsultar.Click += new System.EventHandler(this.pctConsultar_Click);
            // 
            // txtBuscarVendedor
            // 
            this.txtBuscarVendedor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVendedor.ForeColor = System.Drawing.Color.Purple;
            this.txtBuscarVendedor.Location = new System.Drawing.Point(283, 22);
            this.txtBuscarVendedor.Name = "txtBuscarVendedor";
            this.txtBuscarVendedor.Size = new System.Drawing.Size(233, 25);
            this.txtBuscarVendedor.TabIndex = 42;
            this.txtBuscarVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarVendedor.TextChanged += new System.EventHandler(this.txtBuscarVendedor_TextChanged);
            this.txtBuscarVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarVendedor_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(211, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 18);
            this.lblBuscar.TabIndex = 41;
            this.lblBuscar.Text = "Buscar";
            // 
            // gpbCadatrarVendedor
            // 
            this.gpbCadatrarVendedor.Controls.Add(this.lblid);
            this.gpbCadatrarVendedor.Controls.Add(this.cmbNivelAcesso);
            this.gpbCadatrarVendedor.Controls.Add(this.lblNivelAcesso);
            this.gpbCadatrarVendedor.Controls.Add(this.txtSenha);
            this.gpbCadatrarVendedor.Controls.Add(this.lblSenha);
            this.gpbCadatrarVendedor.Controls.Add(this.btnCancelar);
            this.gpbCadatrarVendedor.Controls.Add(this.btnAlterar);
            this.gpbCadatrarVendedor.Controls.Add(this.btnLimpar);
            this.gpbCadatrarVendedor.Controls.Add(this.btnCadastrarVendedor);
            this.gpbCadatrarVendedor.Controls.Add(this.mtxtTelefone);
            this.gpbCadatrarVendedor.Controls.Add(this.txtNome);
            this.gpbCadatrarVendedor.Controls.Add(this.mtxtDataRegistro);
            this.gpbCadatrarVendedor.Controls.Add(this.txtEndereco);
            this.gpbCadatrarVendedor.Controls.Add(this.lblTelefone);
            this.gpbCadatrarVendedor.Controls.Add(this.txtSalario);
            this.gpbCadatrarVendedor.Controls.Add(this.lblDataRegistro);
            this.gpbCadatrarVendedor.Controls.Add(this.lblEndereco);
            this.gpbCadatrarVendedor.Controls.Add(this.lblSalario);
            this.gpbCadatrarVendedor.Controls.Add(this.lblNome);
            this.gpbCadatrarVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadatrarVendedor.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gpbCadatrarVendedor.Location = new System.Drawing.Point(12, 305);
            this.gpbCadatrarVendedor.Name = "gpbCadatrarVendedor";
            this.gpbCadatrarVendedor.Size = new System.Drawing.Size(851, 226);
            this.gpbCadatrarVendedor.TabIndex = 29;
            this.gpbCadatrarVendedor.TabStop = false;
            this.gpbCadatrarVendedor.Text = "Cadastrar Vendedor";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Enabled = false;
            this.lblid.Location = new System.Drawing.Point(3, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 15);
            this.lblid.TabIndex = 50;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // cmbNivelAcesso
            // 
            this.cmbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAcesso.Enabled = false;
            this.cmbNivelAcesso.FormattingEnabled = true;
            this.cmbNivelAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Comun"});
            this.cmbNivelAcesso.Location = new System.Drawing.Point(392, 185);
            this.cmbNivelAcesso.Name = "cmbNivelAcesso";
            this.cmbNivelAcesso.Size = new System.Drawing.Size(124, 23);
            this.cmbNivelAcesso.TabIndex = 49;
            this.cmbNivelAcesso.Visible = false;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Enabled = false;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcesso.Location = new System.Drawing.Point(391, 162);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(135, 18);
            this.lblNivelAcesso.TabIndex = 48;
            this.lblNivelAcesso.Text = "Nivel de Acesso";
            this.lblNivelAcesso.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Purple;
            this.txtSenha.Location = new System.Drawing.Point(392, 125);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(124, 25);
            this.txtSenha.TabIndex = 45;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(426, 104);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 18);
            this.lblSenha.TabIndex = 46;
            this.lblSenha.Text = "Senha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(18, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 37);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(18, 37);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 39);
            this.btnAlterar.TabIndex = 43;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(720, 165);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 37);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarVendedor
            // 
            this.btnCadastrarVendedor.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCadastrarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVendedor.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVendedor.Location = new System.Drawing.Point(720, 37);
            this.btnCadastrarVendedor.Name = "btnCadastrarVendedor";
            this.btnCadastrarVendedor.Size = new System.Drawing.Size(108, 39);
            this.btnCadastrarVendedor.TabIndex = 28;
            this.btnCadastrarVendedor.Text = "Cadastrar";
            this.btnCadastrarVendedor.UseVisualStyleBackColor = false;
            this.btnCadastrarVendedor.Click += new System.EventHandler(this.btnCadastrarVendedor_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(827, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 30);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(732, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 30);
            this.btnMenu.TabIndex = 30;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pcbCadAltVend
            // 
            this.pcbCadAltVend.Image = global::Estoque.Properties.Resources.add_user;
            this.pcbCadAltVend.Location = new System.Drawing.Point(12, 12);
            this.pcbCadAltVend.Name = "pcbCadAltVend";
            this.pcbCadAltVend.Size = new System.Drawing.Size(48, 48);
            this.pcbCadAltVend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCadAltVend.TabIndex = 34;
            this.pcbCadAltVend.TabStop = false;
            // 
            // lblCadAltVend
            // 
            this.lblCadAltVend.AutoSize = true;
            this.lblCadAltVend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadAltVend.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblCadAltVend.Location = new System.Drawing.Point(64, 24);
            this.lblCadAltVend.Name = "lblCadAltVend";
            this.lblCadAltVend.Size = new System.Drawing.Size(399, 28);
            this.lblCadAltVend.TabIndex = 33;
            this.lblCadAltVend.Text = "Cadastrar ou Alterar Vendedores";
            // 
            // frmCadAltVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(877, 525);
            this.Controls.Add(this.pcbCadAltVend);
            this.Controls.Add(this.lblCadAltVend);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.gpbCadatrarVendedor);
            this.Controls.Add(this.gpbVerVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAltVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVend)).EndInit();
            this.gpbVerVendedores.ResumeLayout(false);
            this.gpbVerVendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
            this.gpbCadatrarVendedor.ResumeLayout(false);
            this.gpbCadatrarVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadAltVend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVend;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDataRegistro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtDataRegistro;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.GroupBox gpbVerVendedores;
        private System.Windows.Forms.GroupBox gpbCadatrarVendedor;
        private System.Windows.Forms.TextBox txtBuscarVendedor;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pctConsultar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCadastrarVendedor;
        private System.Windows.Forms.Label lblTituloVendedores;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cmbNivelAcesso;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.PictureBox pcbCadAltVend;
        private System.Windows.Forms.Label lblCadAltVend;
        private System.Windows.Forms.Label lblid;
    }
}