namespace Estoque
{
    partial class frmEstoque
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
            this.lblEstoque = new System.Windows.Forms.Label();
            this.gpbBuscaEstoque = new System.Windows.Forms.GroupBox();
            this.txtIDEST = new System.Windows.Forms.TextBox();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.pctConsultar = new System.Windows.Forms.PictureBox();
            this.dgvEst = new System.Windows.Forms.DataGridView();
            this.lblNomeProdBusca = new System.Windows.Forms.Label();
            this.txtNomeBuscaEst = new System.Windows.Forms.TextBox();
            this.btnAlterarEstoque = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gpbAlteracoesEstoque = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIdEstoqueProd = new System.Windows.Forms.TextBox();
            this.lblIdEstoqProd = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtLocalArmazenamento = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblLocalArmazenamento = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.pcbEstoque = new System.Windows.Forms.PictureBox();
            this.gpbBuscaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).BeginInit();
            this.gpbAlteracoesEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblEstoque.Location = new System.Drawing.Point(71, 22);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(106, 28);
            this.lblEstoque.TabIndex = 15;
            this.lblEstoque.Text = "Estoque";
            // 
            // gpbBuscaEstoque
            // 
            this.gpbBuscaEstoque.Controls.Add(this.txtIDEST);
            this.gpbBuscaEstoque.Controls.Add(this.txtIDProd);
            this.gpbBuscaEstoque.Controls.Add(this.btnMostrarTodos);
            this.gpbBuscaEstoque.Controls.Add(this.lblTituloClientes);
            this.gpbBuscaEstoque.Controls.Add(this.pctConsultar);
            this.gpbBuscaEstoque.Controls.Add(this.dgvEst);
            this.gpbBuscaEstoque.Controls.Add(this.lblNomeProdBusca);
            this.gpbBuscaEstoque.Controls.Add(this.txtNomeBuscaEst);
            this.gpbBuscaEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscaEstoque.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gpbBuscaEstoque.Location = new System.Drawing.Point(12, 68);
            this.gpbBuscaEstoque.Name = "gpbBuscaEstoque";
            this.gpbBuscaEstoque.Size = new System.Drawing.Size(844, 262);
            this.gpbBuscaEstoque.TabIndex = 27;
            this.gpbBuscaEstoque.TabStop = false;
            this.gpbBuscaEstoque.Text = "Busca no Estoque";
            // 
            // txtIDEST
            // 
            this.txtIDEST.Enabled = false;
            this.txtIDEST.Location = new System.Drawing.Point(15, 32);
            this.txtIDEST.Name = "txtIDEST";
            this.txtIDEST.Size = new System.Drawing.Size(150, 23);
            this.txtIDEST.TabIndex = 63;
            this.txtIDEST.Visible = false;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Location = new System.Drawing.Point(551, 49);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(150, 23);
            this.txtIDProd.TabIndex = 62;
            this.txtIDProd.Visible = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Location = new System.Drawing.Point(660, 29);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(140, 31);
            this.btnMostrarTodos.TabIndex = 55;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTituloClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.ForeColor = System.Drawing.Color.White;
            this.lblTituloClientes.Location = new System.Drawing.Point(59, 75);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(742, 35);
            this.lblTituloClientes.TabIndex = 54;
            this.lblTituloClientes.Text = "                                        Produtos no Estoque";
            // 
            // pctConsultar
            // 
            this.pctConsultar.BackColor = System.Drawing.Color.DarkOrchid;
            this.pctConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctConsultar.Enabled = false;
            this.pctConsultar.Image = global::Estoque.Properties.Resources.loupe_79257;
            this.pctConsultar.Location = new System.Drawing.Point(567, 27);
            this.pctConsultar.Name = "pctConsultar";
            this.pctConsultar.Size = new System.Drawing.Size(33, 33);
            this.pctConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConsultar.TabIndex = 50;
            this.pctConsultar.TabStop = false;
            this.pctConsultar.Click += new System.EventHandler(this.pctConsultar_Click);
            // 
            // dgvEst
            // 
            this.dgvEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst.Location = new System.Drawing.Point(59, 113);
            this.dgvEst.Name = "dgvEst";
            this.dgvEst.Size = new System.Drawing.Size(742, 131);
            this.dgvEst.TabIndex = 9;
            this.dgvEst.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEst_CellContentDoubleClick);
            // 
            // lblNomeProdBusca
            // 
            this.lblNomeProdBusca.AutoSize = true;
            this.lblNomeProdBusca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdBusca.Location = new System.Drawing.Point(176, 32);
            this.lblNomeProdBusca.Name = "lblNomeProdBusca";
            this.lblNomeProdBusca.Size = new System.Drawing.Size(146, 18);
            this.lblNomeProdBusca.TabIndex = 19;
            this.lblNomeProdBusca.Text = "Nome do Produto";
            // 
            // txtNomeBuscaEst
            // 
            this.txtNomeBuscaEst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBuscaEst.ForeColor = System.Drawing.Color.Purple;
            this.txtNomeBuscaEst.Location = new System.Drawing.Point(328, 29);
            this.txtNomeBuscaEst.Name = "txtNomeBuscaEst";
            this.txtNomeBuscaEst.Size = new System.Drawing.Size(233, 26);
            this.txtNomeBuscaEst.TabIndex = 13;
            this.txtNomeBuscaEst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeBuscaEst.TextChanged += new System.EventHandler(this.txtNomeBuscaEst_TextChanged);
            // 
            // btnAlterarEstoque
            // 
            this.btnAlterarEstoque.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAlterarEstoque.Enabled = false;
            this.btnAlterarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnAlterarEstoque.Location = new System.Drawing.Point(6, 44);
            this.btnAlterarEstoque.Name = "btnAlterarEstoque";
            this.btnAlterarEstoque.Size = new System.Drawing.Size(108, 39);
            this.btnAlterarEstoque.TabIndex = 51;
            this.btnAlterarEstoque.Text = "Alterar";
            this.btnAlterarEstoque.UseVisualStyleBackColor = false;
            this.btnAlterarEstoque.Click += new System.EventHandler(this.btnAlterarEstoque_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(818, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 30);
            this.btnSair.TabIndex = 30;
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
            this.btnMenu.Location = new System.Drawing.Point(723, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 30);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // gpbAlteracoesEstoque
            // 
            this.gpbAlteracoesEstoque.Controls.Add(this.btnCancelar);
            this.gpbAlteracoesEstoque.Controls.Add(this.txtIdEstoqueProd);
            this.gpbAlteracoesEstoque.Controls.Add(this.lblIdEstoqProd);
            this.gpbAlteracoesEstoque.Controls.Add(this.txtNomeProduto);
            this.gpbAlteracoesEstoque.Controls.Add(this.lblNomeProduto);
            this.gpbAlteracoesEstoque.Controls.Add(this.txtLocalArmazenamento);
            this.gpbAlteracoesEstoque.Controls.Add(this.txtQuantidade);
            this.gpbAlteracoesEstoque.Controls.Add(this.btnLimpar);
            this.gpbAlteracoesEstoque.Controls.Add(this.txtEndereco);
            this.gpbAlteracoesEstoque.Controls.Add(this.txtSituacao);
            this.gpbAlteracoesEstoque.Controls.Add(this.lblQuantidade);
            this.gpbAlteracoesEstoque.Controls.Add(this.btnAlterarEstoque);
            this.gpbAlteracoesEstoque.Controls.Add(this.lblEndereco);
            this.gpbAlteracoesEstoque.Controls.Add(this.lblLocalArmazenamento);
            this.gpbAlteracoesEstoque.Controls.Add(this.lblSituacao);
            this.gpbAlteracoesEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAlteracoesEstoque.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gpbAlteracoesEstoque.Location = new System.Drawing.Point(12, 336);
            this.gpbAlteracoesEstoque.Name = "gpbAlteracoesEstoque";
            this.gpbAlteracoesEstoque.Size = new System.Drawing.Size(844, 182);
            this.gpbAlteracoesEstoque.TabIndex = 52;
            this.gpbAlteracoesEstoque.TabStop = false;
            this.gpbAlteracoesEstoque.Text = "Alterações";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(6, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIdEstoqueProd
            // 
            this.txtIdEstoqueProd.Enabled = false;
            this.txtIdEstoqueProd.Location = new System.Drawing.Point(583, 137);
            this.txtIdEstoqueProd.Name = "txtIdEstoqueProd";
            this.txtIdEstoqueProd.Size = new System.Drawing.Size(150, 23);
            this.txtIdEstoqueProd.TabIndex = 61;
            this.txtIdEstoqueProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEstoqueProd_KeyPress);
            // 
            // lblIdEstoqProd
            // 
            this.lblIdEstoqProd.AutoSize = true;
            this.lblIdEstoqProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEstoqProd.Location = new System.Drawing.Point(570, 108);
            this.lblIdEstoqProd.Name = "lblIdEstoqProd";
            this.lblIdEstoqProd.Size = new System.Drawing.Size(163, 18);
            this.lblIdEstoqProd.TabIndex = 60;
            this.lblIdEstoqProd.Text = "ID Produto Estoque";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(148, 76);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(150, 23);
            this.txtNomeProduto.TabIndex = 59;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(152, 44);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(146, 18);
            this.lblNomeProduto.TabIndex = 58;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtLocalArmazenamento
            // 
            this.txtLocalArmazenamento.Enabled = false;
            this.txtLocalArmazenamento.Location = new System.Drawing.Point(153, 137);
            this.txtLocalArmazenamento.Name = "txtLocalArmazenamento";
            this.txtLocalArmazenamento.Size = new System.Drawing.Size(150, 23);
            this.txtLocalArmazenamento.TabIndex = 57;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(385, 76);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(124, 23);
            this.txtQuantidade.TabIndex = 55;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(748, 88);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 38);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(368, 137);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(168, 23);
            this.txtEndereco.TabIndex = 54;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Location = new System.Drawing.Point(567, 76);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(168, 23);
            this.txtSituacao.TabIndex = 53;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(397, 44);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(101, 18);
            this.lblQuantidade.TabIndex = 52;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(414, 108);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(86, 18);
            this.lblEndereco.TabIndex = 33;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblLocalArmazenamento
            // 
            this.lblLocalArmazenamento.AutoSize = true;
            this.lblLocalArmazenamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalArmazenamento.Location = new System.Drawing.Point(123, 108);
            this.lblLocalArmazenamento.Name = "lblLocalArmazenamento";
            this.lblLocalArmazenamento.Size = new System.Drawing.Size(206, 18);
            this.lblLocalArmazenamento.TabIndex = 34;
            this.lblLocalArmazenamento.Text = "Área de Armazenamento";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(564, 44);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(173, 18);
            this.lblSituacao.TabIndex = 32;
            this.lblSituacao.Text = "Situação do Estoque";
            // 
            // pcbEstoque
            // 
            this.pcbEstoque.Enabled = false;
            this.pcbEstoque.Image = global::Estoque.Properties.Resources.estoque1;
            this.pcbEstoque.Location = new System.Drawing.Point(17, 11);
            this.pcbEstoque.Name = "pcbEstoque";
            this.pcbEstoque.Size = new System.Drawing.Size(48, 48);
            this.pcbEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEstoque.TabIndex = 53;
            this.pcbEstoque.TabStop = false;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(868, 530);
            this.Controls.Add(this.pcbEstoque);
            this.Controls.Add(this.gpbAlteracoesEstoque);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.gpbBuscaEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9";
            this.gpbBuscaEstoque.ResumeLayout(false);
            this.gpbBuscaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).EndInit();
            this.gpbAlteracoesEstoque.ResumeLayout(false);
            this.gpbAlteracoesEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.GroupBox gpbBuscaEstoque;
        private System.Windows.Forms.DataGridView dgvEst;
        private System.Windows.Forms.Label lblNomeProdBusca;
        private System.Windows.Forms.TextBox txtNomeBuscaEst;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pctConsultar;
        private System.Windows.Forms.Button btnAlterarEstoque;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.GroupBox gpbAlteracoesEstoque;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLocalArmazenamento;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtLocalArmazenamento;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.PictureBox pcbEstoque;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtIdEstoqueProd;
        private System.Windows.Forms.Label lblIdEstoqProd;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIDEST;
    }
}