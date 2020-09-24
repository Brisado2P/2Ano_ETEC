namespace Estoque
{
    partial class frmVendedor_com
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gpbVerVendedores = new System.Windows.Forms.GroupBox();
            this.lblTituloVendedores = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pctConsultar = new System.Windows.Forms.PictureBox();
            this.txtBuscarVendedor = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvVend = new System.Windows.Forms.DataGridView();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.pcbVendedor = new System.Windows.Forms.PictureBox();
            this.llblCadAltVendedor = new System.Windows.Forms.LinkLabel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbVerVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(811, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 30);
            this.btnSair.TabIndex = 43;
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
            this.btnMenu.Location = new System.Drawing.Point(716, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 30);
            this.btnMenu.TabIndex = 42;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.gpbVerVendedores.ForeColor = System.Drawing.Color.MediumOrchid;
            this.gpbVerVendedores.Location = new System.Drawing.Point(12, 66);
            this.gpbVerVendedores.Name = "gpbVerVendedores";
            this.gpbVerVendedores.Size = new System.Drawing.Size(851, 259);
            this.gpbVerVendedores.TabIndex = 41;
            this.gpbVerVendedores.TabStop = false;
            this.gpbVerVendedores.Text = "Ver Vendedores";
            // 
            // lblTituloVendedores
            // 
            this.lblTituloVendedores.BackColor = System.Drawing.Color.MediumOrchid;
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
            this.btnMostrar.BackColor = System.Drawing.Color.MediumOrchid;
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
            this.pctConsultar.BackColor = System.Drawing.Color.MediumOrchid;
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
            // dgvVend
            // 
            this.dgvVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVend.Location = new System.Drawing.Point(31, 106);
            this.dgvVend.Name = "dgvVend";
            this.dgvVend.Size = new System.Drawing.Size(792, 147);
            this.dgvVend.TabIndex = 11;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblVendedor.Location = new System.Drawing.Point(66, 23);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(153, 28);
            this.lblVendedor.TabIndex = 39;
            this.lblVendedor.Text = "Vendedores";
            // 
            // pcbVendedor
            // 
            this.pcbVendedor.Image = global::Estoque.Properties.Resources.vend2;
            this.pcbVendedor.Location = new System.Drawing.Point(12, 12);
            this.pcbVendedor.Name = "pcbVendedor";
            this.pcbVendedor.Size = new System.Drawing.Size(48, 48);
            this.pcbVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVendedor.TabIndex = 40;
            this.pcbVendedor.TabStop = false;
            // 
            // llblCadAltVendedor
            // 
            this.llblCadAltVendedor.AutoSize = true;
            this.llblCadAltVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCadAltVendedor.LinkColor = System.Drawing.Color.MediumOrchid;
            this.llblCadAltVendedor.Location = new System.Drawing.Point(196, 357);
            this.llblCadAltVendedor.Name = "llblCadAltVendedor";
            this.llblCadAltVendedor.Size = new System.Drawing.Size(478, 24);
            this.llblCadAltVendedor.TabIndex = 45;
            this.llblCadAltVendedor.TabStop = true;
            this.llblCadAltVendedor.Text = "Deseja Cadastrar ou Alterar Algum Vendedor?";
            this.llblCadAltVendedor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCadAltVendedor_LinkClicked);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(743, 354);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(92, 27);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmVendedor_com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(877, 409);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.llblCadAltVendedor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.gpbVerVendedores);
            this.Controls.Add(this.pcbVendedor);
            this.Controls.Add(this.lblVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendedor_com";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor_com";
            this.gpbVerVendedores.ResumeLayout(false);
            this.gpbVerVendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox gpbVerVendedores;
        private System.Windows.Forms.Label lblTituloVendedores;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox pctConsultar;
        private System.Windows.Forms.TextBox txtBuscarVendedor;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvVend;
        private System.Windows.Forms.PictureBox pcbVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.LinkLabel llblCadAltVendedor;
        private System.Windows.Forms.Button btnLimpar;
    }
}