namespace Estoque
{
    partial class frmClientes
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvClie = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gpbVerCli = new System.Windows.Forms.GroupBox();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.pctConsultar = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpbCadastrarNovoCli = new System.Windows.Forms.GroupBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pcbClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClie)).BeginInit();
            this.gpbVerCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
            this.gpbCadastrarNovoCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(17, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Indigo;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(17, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 39);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(673, 32);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 39);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvClie
            // 
            this.dgvClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClie.Location = new System.Drawing.Point(32, 111);
            this.dgvClie.Name = "dgvClie";
            this.dgvClie.Size = new System.Drawing.Size(728, 137);
            this.dgvClie.TabIndex = 11;
            this.dgvClie.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClie_CellContentDoubleClick);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Indigo;
            this.lblClientes.Location = new System.Drawing.Point(71, 21);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(107, 28);
            this.lblClientes.TabIndex = 10;
            this.lblClientes.Text = "Clientes";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(139, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(367, 35);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(169, 18);
            this.lblDataNasc.TabIndex = 16;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(139, 124);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 18);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(367, 82);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(86, 18);
            this.lblEndereco.TabIndex = 18;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Purple;
            this.txtEndereco.Location = new System.Drawing.Point(459, 78);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(197, 25);
            this.txtEndereco.TabIndex = 19;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Purple;
            this.txtNome.Location = new System.Drawing.Point(216, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(129, 25);
            this.txtNome.TabIndex = 22;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // mtxtDataNasc
            // 
            this.mtxtDataNasc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNasc.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataNasc.Location = new System.Drawing.Point(542, 32);
            this.mtxtDataNasc.Mask = "00/00/0000";
            this.mtxtDataNasc.Name = "mtxtDataNasc";
            this.mtxtDataNasc.Size = new System.Drawing.Size(114, 25);
            this.mtxtDataNasc.TabIndex = 23;
            this.mtxtDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone.ForeColor = System.Drawing.Color.Purple;
            this.mtxtTelefone.Location = new System.Drawing.Point(216, 120);
            this.mtxtTelefone.Mask = "#########";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(129, 25);
            this.mtxtTelefone.TabIndex = 24;
            this.mtxtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbVerCli
            // 
            this.gpbVerCli.Controls.Add(this.lblTituloClientes);
            this.gpbVerCli.Controls.Add(this.pctConsultar);
            this.gpbVerCli.Controls.Add(this.btnMostrar);
            this.gpbVerCli.Controls.Add(this.txtBuscarClientes);
            this.gpbVerCli.Controls.Add(this.lblBuscar);
            this.gpbVerCli.Controls.Add(this.dgvClie);
            this.gpbVerCli.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbVerCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVerCli.ForeColor = System.Drawing.Color.Indigo;
            this.gpbVerCli.Location = new System.Drawing.Point(17, 63);
            this.gpbVerCli.Name = "gpbVerCli";
            this.gpbVerCli.Size = new System.Drawing.Size(794, 265);
            this.gpbVerCli.TabIndex = 25;
            this.gpbVerCli.TabStop = false;
            this.gpbVerCli.Text = "Ver Clientes";
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.BackColor = System.Drawing.Color.Indigo;
            this.lblTituloClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.ForeColor = System.Drawing.Color.White;
            this.lblTituloClientes.Location = new System.Drawing.Point(32, 73);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(728, 35);
            this.lblTituloClientes.TabIndex = 53;
            this.lblTituloClientes.Text = "                                        Clientes Cadastrados";
            // 
            // pctConsultar
            // 
            this.pctConsultar.BackColor = System.Drawing.Color.Indigo;
            this.pctConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctConsultar.Enabled = false;
            this.pctConsultar.Image = global::Estoque.Properties.Resources.loupe_79257;
            this.pctConsultar.Location = new System.Drawing.Point(512, 22);
            this.pctConsultar.Name = "pctConsultar";
            this.pctConsultar.Size = new System.Drawing.Size(33, 33);
            this.pctConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConsultar.TabIndex = 49;
            this.pctConsultar.TabStop = false;
            this.pctConsultar.Click += new System.EventHandler(this.pctConsultar_Click);
            this.pctConsultar.MouseLeave += new System.EventHandler(this.pctConsultar_MouseLeave);
            this.pctConsultar.MouseHover += new System.EventHandler(this.pctConsultar_MouseHover);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Indigo;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(620, 33);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 31);
            this.btnMostrar.TabIndex = 48;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClientes.ForeColor = System.Drawing.Color.Purple;
            this.txtBuscarClientes.Location = new System.Drawing.Point(271, 27);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(233, 25);
            this.txtBuscarClientes.TabIndex = 42;
            this.txtBuscarClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarClientes.TextChanged += new System.EventHandler(this.txtBuscarClientes_TextChanged);
            this.txtBuscarClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarClientes_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(162, 29);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(103, 18);
            this.lblBuscar.TabIndex = 41;
            this.lblBuscar.Text = "Buscar CPF";
            // 
            // gpbCadastrarNovoCli
            // 
            this.gpbCadastrarNovoCli.Controls.Add(this.cmbSituacao);
            this.gpbCadastrarNovoCli.Controls.Add(this.lblSituacao);
            this.gpbCadastrarNovoCli.Controls.Add(this.btnLimpar);
            this.gpbCadastrarNovoCli.Controls.Add(this.mtxtCPF);
            this.gpbCadastrarNovoCli.Controls.Add(this.txtNome);
            this.gpbCadastrarNovoCli.Controls.Add(this.lblCPF);
            this.gpbCadastrarNovoCli.Controls.Add(this.lblNome);
            this.gpbCadastrarNovoCli.Controls.Add(this.mtxtTelefone);
            this.gpbCadastrarNovoCli.Controls.Add(this.btnCancelar);
            this.gpbCadastrarNovoCli.Controls.Add(this.btnAlterar);
            this.gpbCadastrarNovoCli.Controls.Add(this.mtxtDataNasc);
            this.gpbCadastrarNovoCli.Controls.Add(this.lblDataNasc);
            this.gpbCadastrarNovoCli.Controls.Add(this.lblTelefone);
            this.gpbCadastrarNovoCli.Controls.Add(this.lblEndereco);
            this.gpbCadastrarNovoCli.Controls.Add(this.txtEndereco);
            this.gpbCadastrarNovoCli.Controls.Add(this.btnCadastrar);
            this.gpbCadastrarNovoCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastrarNovoCli.ForeColor = System.Drawing.Color.Indigo;
            this.gpbCadastrarNovoCli.Location = new System.Drawing.Point(17, 343);
            this.gpbCadastrarNovoCli.Name = "gpbCadastrarNovoCli";
            this.gpbCadastrarNovoCli.Size = new System.Drawing.Size(794, 164);
            this.gpbCadastrarNovoCli.TabIndex = 26;
            this.gpbCadastrarNovoCli.TabStop = false;
            this.gpbCadastrarNovoCli.Text = "Cadastrar Novo Cliente";
            this.gpbCadastrarNovoCli.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituacao.ForeColor = System.Drawing.Color.Purple;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbSituacao.Location = new System.Drawing.Point(459, 122);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 25);
            this.cmbSituacao.TabIndex = 43;
            this.cmbSituacao.TextChanged += new System.EventHandler(this.cmbSituacao_TextChanged);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(368, 125);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(79, 18);
            this.lblSituacao.TabIndex = 42;
            this.lblSituacao.Text = "Situação";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(673, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 39);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.ForeColor = System.Drawing.Color.Purple;
            this.mtxtCPF.Location = new System.Drawing.Point(216, 78);
            this.mtxtCPF.Mask = "###########";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(129, 25);
            this.mtxtCPF.TabIndex = 40;
            this.mtxtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(139, 82);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 18);
            this.lblCPF.TabIndex = 25;
            this.lblCPF.Text = "CPF";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(780, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 30);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(685, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 30);
            this.btnMenu.TabIndex = 27;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pcbClientes
            // 
            this.pcbClientes.Image = global::Estoque.Properties.Resources.cli2;
            this.pcbClientes.Location = new System.Drawing.Point(17, 9);
            this.pcbClientes.Name = "pcbClientes";
            this.pcbClientes.Size = new System.Drawing.Size(48, 48);
            this.pcbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClientes.TabIndex = 29;
            this.pcbClientes.TabStop = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(830, 527);
            this.Controls.Add(this.pcbClientes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.gpbCadastrarNovoCli);
            this.Controls.Add(this.gpbVerCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClie)).EndInit();
            this.gpbVerCli.ResumeLayout(false);
            this.gpbVerCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
            this.gpbCadastrarNovoCli.ResumeLayout(false);
            this.gpbCadastrarNovoCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvClie;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtDataNasc;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.GroupBox gpbVerCli;
        private System.Windows.Forms.GroupBox gpbCadastrarNovoCli;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pctConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.PictureBox pcbClientes;
    }
}