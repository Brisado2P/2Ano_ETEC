namespace Estoque
{
    partial class frmProdutos
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
            this.btnCadastrarNovoProd = new System.Windows.Forms.Button();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNomeProdBusca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDt_Fabri = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDt_Fabri = new System.Windows.Forms.MaskedTextBox();
            this.gpbCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.lblTituloVendedores = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pctConsultar = new System.Windows.Forms.PictureBox();
            this.lblNomeProdBusca = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pcbProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.gpbCadastrarProduto.SuspendLayout();
            this.gpbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarNovoProd
            // 
            this.btnCadastrarNovoProd.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCadastrarNovoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovoProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovoProd.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarNovoProd.Location = new System.Drawing.Point(655, 22);
            this.btnCadastrarNovoProd.Name = "btnCadastrarNovoProd";
            this.btnCadastrarNovoProd.Size = new System.Drawing.Size(105, 61);
            this.btnCadastrarNovoProd.TabIndex = 7;
            this.btnCadastrarNovoProd.Text = "Cadastrar";
            this.btnCadastrarNovoProd.UseVisualStyleBackColor = false;
            this.btnCadastrarNovoProd.Click += new System.EventHandler(this.btnCadastrarNovoProd_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblProdutos.Location = new System.Drawing.Point(69, 24);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(117, 28);
            this.lblProdutos.TabIndex = 5;
            this.lblProdutos.Text = "Produtos";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(25, 106);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(735, 109);
            this.dgvProd.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Purple;
            this.txtNome.Location = new System.Drawing.Point(82, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 25);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeProdBusca
            // 
            this.txtNomeProdBusca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProdBusca.ForeColor = System.Drawing.Color.Purple;
            this.txtNomeProdBusca.Location = new System.Drawing.Point(278, 22);
            this.txtNomeProdBusca.Name = "txtNomeProdBusca";
            this.txtNomeProdBusca.Size = new System.Drawing.Size(233, 25);
            this.txtNomeProdBusca.TabIndex = 13;
            this.txtNomeProdBusca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeProdBusca.TextChanged += new System.EventHandler(this.txtNomeProdBusca_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Purple;
            this.txtMarca.Location = new System.Drawing.Point(325, 31);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(115, 25);
            this.txtMarca.TabIndex = 15;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.Purple;
            this.txtPreco.Location = new System.Drawing.Point(517, 31);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(114, 25);
            this.txtPreco.TabIndex = 16;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblNome.Location = new System.Drawing.Point(22, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblMarca.Location = new System.Drawing.Point(261, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 18);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca";
            // 
            // lblDt_Fabri
            // 
            this.lblDt_Fabri.AutoSize = true;
            this.lblDt_Fabri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt_Fabri.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblDt_Fabri.Location = new System.Drawing.Point(261, 98);
            this.lblDt_Fabri.Name = "lblDt_Fabri";
            this.lblDt_Fabri.Size = new System.Drawing.Size(165, 18);
            this.lblDt_Fabri.TabIndex = 20;
            this.lblDt_Fabri.Text = "Data de Fabricação";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblValidade.Location = new System.Drawing.Point(22, 98);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(77, 18);
            this.lblValidade.TabIndex = 21;
            this.lblValidade.Text = "Validade";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblPreco.Location = new System.Drawing.Point(455, 38);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(56, 18);
            this.lblPreco.TabIndex = 22;
            this.lblPreco.Text = "Preço";
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValidade.ForeColor = System.Drawing.Color.Purple;
            this.mtxtValidade.Location = new System.Drawing.Point(118, 91);
            this.mtxtValidade.Mask = "00/00/0000";
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(123, 25);
            this.mtxtValidade.TabIndex = 23;
            this.mtxtValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtValidade.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDt_Fabri
            // 
            this.mtxtDt_Fabri.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDt_Fabri.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDt_Fabri.Location = new System.Drawing.Point(436, 96);
            this.mtxtDt_Fabri.Mask = "00/00/0000";
            this.mtxtDt_Fabri.Name = "mtxtDt_Fabri";
            this.mtxtDt_Fabri.Size = new System.Drawing.Size(114, 25);
            this.mtxtDt_Fabri.TabIndex = 24;
            this.mtxtDt_Fabri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDt_Fabri.ValidatingType = typeof(System.DateTime);
            // 
            // gpbCadastrarProduto
            // 
            this.gpbCadastrarProduto.Controls.Add(this.btnLimpar);
            this.gpbCadastrarProduto.Controls.Add(this.lblPreco);
            this.gpbCadastrarProduto.Controls.Add(this.btnCadastrarNovoProd);
            this.gpbCadastrarProduto.Controls.Add(this.mtxtDt_Fabri);
            this.gpbCadastrarProduto.Controls.Add(this.txtPreco);
            this.gpbCadastrarProduto.Controls.Add(this.txtNome);
            this.gpbCadastrarProduto.Controls.Add(this.mtxtValidade);
            this.gpbCadastrarProduto.Controls.Add(this.lblDt_Fabri);
            this.gpbCadastrarProduto.Controls.Add(this.lblValidade);
            this.gpbCadastrarProduto.Controls.Add(this.lblMarca);
            this.gpbCadastrarProduto.Controls.Add(this.lblNome);
            this.gpbCadastrarProduto.Controls.Add(this.txtMarca);
            this.gpbCadastrarProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastrarProduto.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gpbCadastrarProduto.Location = new System.Drawing.Point(12, 309);
            this.gpbCadastrarProduto.Name = "gpbCadastrarProduto";
            this.gpbCadastrarProduto.Size = new System.Drawing.Size(786, 151);
            this.gpbCadastrarProduto.TabIndex = 25;
            this.gpbCadastrarProduto.TabStop = false;
            this.gpbCadastrarProduto.Text = "Cadastrar Novo Produto";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(655, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 37);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.lblTituloVendedores);
            this.gpbProduto.Controls.Add(this.btnMostrar);
            this.gpbProduto.Controls.Add(this.pctConsultar);
            this.gpbProduto.Controls.Add(this.dgvProd);
            this.gpbProduto.Controls.Add(this.lblNomeProdBusca);
            this.gpbProduto.Controls.Add(this.txtNomeProdBusca);
            this.gpbProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduto.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gpbProduto.Location = new System.Drawing.Point(12, 68);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(786, 235);
            this.gpbProduto.TabIndex = 26;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Buscar Produto";
            // 
            // lblTituloVendedores
            // 
            this.lblTituloVendedores.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblTituloVendedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVendedores.ForeColor = System.Drawing.Color.White;
            this.lblTituloVendedores.Location = new System.Drawing.Point(25, 68);
            this.lblTituloVendedores.Name = "lblTituloVendedores";
            this.lblTituloVendedores.Size = new System.Drawing.Size(735, 35);
            this.lblTituloVendedores.TabIndex = 55;
            this.lblTituloVendedores.Text = "                                       Produtos Cadastrados";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(620, 25);
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
            this.pctConsultar.Location = new System.Drawing.Point(517, 18);
            this.pctConsultar.Name = "pctConsultar";
            this.pctConsultar.Size = new System.Drawing.Size(33, 33);
            this.pctConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConsultar.TabIndex = 50;
            this.pctConsultar.TabStop = false;
            this.pctConsultar.Click += new System.EventHandler(this.pctConsultar_Click);
            this.pctConsultar.MouseLeave += new System.EventHandler(this.pctConsultar_MouseLeave_1);
            this.pctConsultar.MouseHover += new System.EventHandler(this.pctConsultar_MouseHover_1);
            // 
            // lblNomeProdBusca
            // 
            this.lblNomeProdBusca.AutoSize = true;
            this.lblNomeProdBusca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdBusca.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblNomeProdBusca.Location = new System.Drawing.Point(127, 25);
            this.lblNomeProdBusca.Name = "lblNomeProdBusca";
            this.lblNomeProdBusca.Size = new System.Drawing.Size(146, 18);
            this.lblNomeProdBusca.TabIndex = 19;
            this.lblNomeProdBusca.Text = "Nome do Produto";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(760, 12);
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
            this.btnMenu.Location = new System.Drawing.Point(665, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 30);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pcbProdutos
            // 
            this.pcbProdutos.Image = global::Estoque.Properties.Resources.estoque;
            this.pcbProdutos.Location = new System.Drawing.Point(12, 12);
            this.pcbProdutos.Name = "pcbProdutos";
            this.pcbProdutos.Size = new System.Drawing.Size(48, 48);
            this.pcbProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProdutos.TabIndex = 31;
            this.pcbProdutos.TabStop = false;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(810, 472);
            this.Controls.Add(this.pcbProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.gpbCadastrarProduto);
            this.Controls.Add(this.gpbProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.gpbCadastrarProduto.ResumeLayout(false);
            this.gpbCadastrarProduto.PerformLayout();
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarNovoProd;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNomeProdBusca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDt_Fabri;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
        private System.Windows.Forms.MaskedTextBox mtxtDt_Fabri;
        private System.Windows.Forms.GroupBox gpbCadastrarProduto;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Label lblNomeProdBusca;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pctConsultar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTituloVendedores;
        private System.Windows.Forms.PictureBox pcbProdutos;
    }
}