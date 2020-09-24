namespace Estoque
{
    partial class frmPedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblCPFCli = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtIDVendedor = new System.Windows.Forms.TextBox();
            this.mtxtCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.gpbPedidosSalvos = new System.Windows.Forms.GroupBox();
            this.lblTituloPedidos = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pctConsultar = new System.Windows.Forms.PictureBox();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpbCadastrarPedido = new System.Windows.Forms.GroupBox();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pcbPedidos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbPedidosSalvos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
            this.gpbCadastrarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(25, 109);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(733, 147);
            this.dgvPedidos.TabIndex = 16;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPedidos.Location = new System.Drawing.Point(66, 24);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(106, 28);
            this.lblPedidos.TabIndex = 15;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblCPFCli
            // 
            this.lblCPFCli.AutoSize = true;
            this.lblCPFCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCli.Location = new System.Drawing.Point(25, 47);
            this.lblCPFCli.Name = "lblCPFCli";
            this.lblCPFCli.Size = new System.Drawing.Size(125, 18);
            this.lblCPFCli.TabIndex = 31;
            this.lblCPFCli.Text = "CPF do Cliente";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmissao.Location = new System.Drawing.Point(195, 47);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(141, 18);
            this.lblDataEmissao.TabIndex = 32;
            this.lblDataEmissao.Text = "Data de Emissão";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(382, 47);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(94, 18);
            this.lblValorTotal.TabIndex = 33;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(539, 47);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(86, 18);
            this.lblVendedor.TabIndex = 34;
            this.lblVendedor.Text = "Vendedor";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.Purple;
            this.txtValorTotal.Location = new System.Drawing.Point(379, 74);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 25);
            this.txtValorTotal.TabIndex = 37;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // txtIDVendedor
            // 
            this.txtIDVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVendedor.ForeColor = System.Drawing.Color.Purple;
            this.txtIDVendedor.Location = new System.Drawing.Point(526, 74);
            this.txtIDVendedor.Name = "txtIDVendedor";
            this.txtIDVendedor.Size = new System.Drawing.Size(113, 25);
            this.txtIDVendedor.TabIndex = 38;
            this.txtIDVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDVendedor_KeyPress);
            // 
            // mtxtCPFCli
            // 
            this.mtxtCPFCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPFCli.ForeColor = System.Drawing.Color.Purple;
            this.mtxtCPFCli.Location = new System.Drawing.Point(28, 74);
            this.mtxtCPFCli.Mask = "00000000000";
            this.mtxtCPFCli.Name = "mtxtCPFCli";
            this.mtxtCPFCli.Size = new System.Drawing.Size(122, 25);
            this.mtxtCPFCli.TabIndex = 39;
            this.mtxtCPFCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtDataEmissao
            // 
            this.mtxtDataEmissao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataEmissao.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataEmissao.Location = new System.Drawing.Point(201, 74);
            this.mtxtDataEmissao.Mask = "00/00/0000";
            this.mtxtDataEmissao.Name = "mtxtDataEmissao";
            this.mtxtDataEmissao.Size = new System.Drawing.Size(127, 25);
            this.mtxtDataEmissao.TabIndex = 40;
            this.mtxtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataEmissao.ValidatingType = typeof(System.DateTime);
            // 
            // gpbPedidosSalvos
            // 
            this.gpbPedidosSalvos.Controls.Add(this.lblTituloPedidos);
            this.gpbPedidosSalvos.Controls.Add(this.btnMostrar);
            this.gpbPedidosSalvos.Controls.Add(this.pctConsultar);
            this.gpbPedidosSalvos.Controls.Add(this.txtBuscarPedido);
            this.gpbPedidosSalvos.Controls.Add(this.lblBuscar);
            this.gpbPedidosSalvos.Controls.Add(this.dgvPedidos);
            this.gpbPedidosSalvos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPedidosSalvos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gpbPedidosSalvos.Location = new System.Drawing.Point(12, 68);
            this.gpbPedidosSalvos.Name = "gpbPedidosSalvos";
            this.gpbPedidosSalvos.Size = new System.Drawing.Size(786, 272);
            this.gpbPedidosSalvos.TabIndex = 41;
            this.gpbPedidosSalvos.TabStop = false;
            this.gpbPedidosSalvos.Text = "Pedidos Salvos";
            // 
            // lblTituloPedidos
            // 
            this.lblTituloPedidos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTituloPedidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPedidos.ForeColor = System.Drawing.Color.White;
            this.lblTituloPedidos.Location = new System.Drawing.Point(25, 71);
            this.lblTituloPedidos.Name = "lblTituloPedidos";
            this.lblTituloPedidos.Size = new System.Drawing.Size(733, 35);
            this.lblTituloPedidos.TabIndex = 52;
            this.lblTituloPedidos.Text = "                                        Pedidos Registrados";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(618, 29);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 31);
            this.btnMostrar.TabIndex = 51;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // pctConsultar
            // 
            this.pctConsultar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pctConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctConsultar.Enabled = false;
            this.pctConsultar.Image = global::Estoque.Properties.Resources.loupe_79257;
            this.pctConsultar.Location = new System.Drawing.Point(490, 19);
            this.pctConsultar.Name = "pctConsultar";
            this.pctConsultar.Size = new System.Drawing.Size(33, 33);
            this.pctConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConsultar.TabIndex = 50;
            this.pctConsultar.TabStop = false;
            this.pctConsultar.Click += new System.EventHandler(this.pctConsultar_Click);
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPedido.ForeColor = System.Drawing.Color.Purple;
            this.txtBuscarPedido.Location = new System.Drawing.Point(243, 22);
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(233, 25);
            this.txtBuscarPedido.TabIndex = 39;
            this.txtBuscarPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarPedido.TextChanged += new System.EventHandler(this.txtBuscarPedido_TextChanged);
            this.txtBuscarPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPedido_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(102, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(126, 18);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Buscar Código";
            // 
            // gpbCadastrarPedido
            // 
            this.gpbCadastrarPedido.Controls.Add(this.btnSalvarPedido);
            this.gpbCadastrarPedido.Controls.Add(this.btnLimpar);
            this.gpbCadastrarPedido.Controls.Add(this.lblCPFCli);
            this.gpbCadastrarPedido.Controls.Add(this.mtxtCPFCli);
            this.gpbCadastrarPedido.Controls.Add(this.mtxtDataEmissao);
            this.gpbCadastrarPedido.Controls.Add(this.txtIDVendedor);
            this.gpbCadastrarPedido.Controls.Add(this.lblVendedor);
            this.gpbCadastrarPedido.Controls.Add(this.txtValorTotal);
            this.gpbCadastrarPedido.Controls.Add(this.lblDataEmissao);
            this.gpbCadastrarPedido.Controls.Add(this.lblValorTotal);
            this.gpbCadastrarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastrarPedido.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gpbCadastrarPedido.Location = new System.Drawing.Point(12, 346);
            this.gpbCadastrarPedido.Name = "gpbCadastrarPedido";
            this.gpbCadastrarPedido.Size = new System.Drawing.Size(784, 129);
            this.gpbCadastrarPedido.TabIndex = 42;
            this.gpbCadastrarPedido.TabStop = false;
            this.gpbCadastrarPedido.Text = "Cadastrar um Novo Pedido";
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSalvarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPedido.ForeColor = System.Drawing.Color.White;
            this.btnSalvarPedido.Location = new System.Drawing.Point(670, 28);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(88, 52);
            this.btnSalvarPedido.TabIndex = 43;
            this.btnSalvarPedido.Text = "Salvar";
            this.btnSalvarPedido.UseVisualStyleBackColor = false;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(669, 87);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 26);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.btnSair.TabIndex = 44;
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
            this.btnMenu.TabIndex = 43;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pcbPedidos
            // 
            this.pcbPedidos.Image = global::Estoque.Properties.Resources.pedido2;
            this.pcbPedidos.Location = new System.Drawing.Point(12, 12);
            this.pcbPedidos.Name = "pcbPedidos";
            this.pcbPedidos.Size = new System.Drawing.Size(48, 48);
            this.pcbPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPedidos.TabIndex = 44;
            this.pcbPedidos.TabStop = false;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(810, 487);
            this.Controls.Add(this.pcbPedidos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.gpbCadastrarPedido);
            this.Controls.Add(this.gpbPedidosSalvos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpbPedidosSalvos.ResumeLayout(false);
            this.gpbPedidosSalvos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
            this.gpbCadastrarPedido.ResumeLayout(false);
            this.gpbCadastrarPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblCPFCli;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtIDVendedor;
        private System.Windows.Forms.MaskedTextBox mtxtCPFCli;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmissao;
        private System.Windows.Forms.GroupBox gpbPedidosSalvos;
        private System.Windows.Forms.GroupBox gpbCadastrarPedido;
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pctConsultar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTituloPedidos;
        private System.Windows.Forms.PictureBox pcbPedidos;
    }
}