namespace Estoque
{
    partial class frmRelatorio
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
            this.gpbFatDatas = new System.Windows.Forms.GroupBox();
            this.dgvResultadoFaturamento = new System.Windows.Forms.DataGridView();
            this.btnLimparFatDatas = new System.Windows.Forms.Button();
            this.btnCalcularFaturamento = new System.Windows.Forms.Button();
            this.mtxtDataFinalFaturamento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataInicialFaturamento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicialFat = new System.Windows.Forms.Label();
            this.lblDataFinalFat = new System.Windows.Forms.Label();
            this.gpbQuantProdVend = new System.Windows.Forms.GroupBox();
            this.dgvQuantProdVend = new System.Windows.Forms.DataGridView();
            this.btnLimparQuantProdVend = new System.Windows.Forms.Button();
            this.btnCalcularQuantProd = new System.Windows.Forms.Button();
            this.mtxtDataFinalQuantProd = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataInicialQuantProd = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicialQuantProd = new System.Windows.Forms.Label();
            this.lblDataFinalQuantProd = new System.Windows.Forms.Label();
            this.gpbQuantVendaVendedor = new System.Windows.Forms.GroupBox();
            this.dgvQuantVend = new System.Windows.Forms.DataGridView();
            this.btnLimparQuantVendedorVend = new System.Windows.Forms.Button();
            this.btnCalcularVendaVendedor = new System.Windows.Forms.Button();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pcbRelatorios = new System.Windows.Forms.PictureBox();
            this.gpbFatDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoFaturamento)).BeginInit();
            this.gpbQuantProdVend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantProdVend)).BeginInit();
            this.gpbQuantVendaVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantVend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFatDatas
            // 
            this.gpbFatDatas.Controls.Add(this.dgvResultadoFaturamento);
            this.gpbFatDatas.Controls.Add(this.btnLimparFatDatas);
            this.gpbFatDatas.Controls.Add(this.btnCalcularFaturamento);
            this.gpbFatDatas.Controls.Add(this.mtxtDataFinalFaturamento);
            this.gpbFatDatas.Controls.Add(this.mtxtDataInicialFaturamento);
            this.gpbFatDatas.Controls.Add(this.lblDataInicialFat);
            this.gpbFatDatas.Controls.Add(this.lblDataFinalFat);
            this.gpbFatDatas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFatDatas.ForeColor = System.Drawing.Color.BlueViolet;
            this.gpbFatDatas.Location = new System.Drawing.Point(12, 69);
            this.gpbFatDatas.Name = "gpbFatDatas";
            this.gpbFatDatas.Size = new System.Drawing.Size(552, 144);
            this.gpbFatDatas.TabIndex = 30;
            this.gpbFatDatas.TabStop = false;
            this.gpbFatDatas.Text = "Faturamento Entre Datas";
            // 
            // dgvResultadoFaturamento
            // 
            this.dgvResultadoFaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoFaturamento.Location = new System.Drawing.Point(151, 36);
            this.dgvResultadoFaturamento.Name = "dgvResultadoFaturamento";
            this.dgvResultadoFaturamento.Size = new System.Drawing.Size(258, 95);
            this.dgvResultadoFaturamento.TabIndex = 43;
            // 
            // btnLimparFatDatas
            // 
            this.btnLimparFatDatas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimparFatDatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFatDatas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFatDatas.ForeColor = System.Drawing.Color.White;
            this.btnLimparFatDatas.Location = new System.Drawing.Point(433, 86);
            this.btnLimparFatDatas.Name = "btnLimparFatDatas";
            this.btnLimparFatDatas.Size = new System.Drawing.Size(90, 34);
            this.btnLimparFatDatas.TabIndex = 42;
            this.btnLimparFatDatas.Text = "Limpar";
            this.btnLimparFatDatas.UseVisualStyleBackColor = false;
            this.btnLimparFatDatas.Click += new System.EventHandler(this.btnLimparFatDatas_Click);
            // 
            // btnCalcularFaturamento
            // 
            this.btnCalcularFaturamento.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCalcularFaturamento.Enabled = false;
            this.btnCalcularFaturamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFaturamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFaturamento.ForeColor = System.Drawing.Color.White;
            this.btnCalcularFaturamento.Location = new System.Drawing.Point(433, 36);
            this.btnCalcularFaturamento.Name = "btnCalcularFaturamento";
            this.btnCalcularFaturamento.Size = new System.Drawing.Size(90, 44);
            this.btnCalcularFaturamento.TabIndex = 7;
            this.btnCalcularFaturamento.Text = "Calcular";
            this.btnCalcularFaturamento.UseVisualStyleBackColor = false;
            this.btnCalcularFaturamento.Click += new System.EventHandler(this.btnCalcularFaturamento_Click);
            // 
            // mtxtDataFinalFaturamento
            // 
            this.mtxtDataFinalFaturamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataFinalFaturamento.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataFinalFaturamento.Location = new System.Drawing.Point(9, 97);
            this.mtxtDataFinalFaturamento.Mask = "00/00/0000";
            this.mtxtDataFinalFaturamento.Name = "mtxtDataFinalFaturamento";
            this.mtxtDataFinalFaturamento.Size = new System.Drawing.Size(112, 25);
            this.mtxtDataFinalFaturamento.TabIndex = 3;
            this.mtxtDataFinalFaturamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataFinalFaturamento.ValidatingType = typeof(System.DateTime);
            this.mtxtDataFinalFaturamento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDataFinalFaturamento_MaskInputRejected);
            // 
            // mtxtDataInicialFaturamento
            // 
            this.mtxtDataInicialFaturamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataInicialFaturamento.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataInicialFaturamento.Location = new System.Drawing.Point(9, 44);
            this.mtxtDataInicialFaturamento.Mask = "00/00/0000";
            this.mtxtDataInicialFaturamento.Name = "mtxtDataInicialFaturamento";
            this.mtxtDataInicialFaturamento.Size = new System.Drawing.Size(112, 25);
            this.mtxtDataInicialFaturamento.TabIndex = 2;
            this.mtxtDataInicialFaturamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataInicialFaturamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataInicialFat
            // 
            this.lblDataInicialFat.AutoSize = true;
            this.lblDataInicialFat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicialFat.Location = new System.Drawing.Point(17, 23);
            this.lblDataInicialFat.Name = "lblDataInicialFat";
            this.lblDataInicialFat.Size = new System.Drawing.Size(97, 18);
            this.lblDataInicialFat.TabIndex = 0;
            this.lblDataInicialFat.Text = "Data Inicial";
            // 
            // lblDataFinalFat
            // 
            this.lblDataFinalFat.AutoSize = true;
            this.lblDataFinalFat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinalFat.Location = new System.Drawing.Point(20, 76);
            this.lblDataFinalFat.Name = "lblDataFinalFat";
            this.lblDataFinalFat.Size = new System.Drawing.Size(88, 18);
            this.lblDataFinalFat.TabIndex = 1;
            this.lblDataFinalFat.Text = "Data Final";
            // 
            // gpbQuantProdVend
            // 
            this.gpbQuantProdVend.Controls.Add(this.dgvQuantProdVend);
            this.gpbQuantProdVend.Controls.Add(this.btnLimparQuantProdVend);
            this.gpbQuantProdVend.Controls.Add(this.btnCalcularQuantProd);
            this.gpbQuantProdVend.Controls.Add(this.mtxtDataFinalQuantProd);
            this.gpbQuantProdVend.Controls.Add(this.mtxtDataInicialQuantProd);
            this.gpbQuantProdVend.Controls.Add(this.lblDataInicialQuantProd);
            this.gpbQuantProdVend.Controls.Add(this.lblDataFinalQuantProd);
            this.gpbQuantProdVend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbQuantProdVend.ForeColor = System.Drawing.Color.BlueViolet;
            this.gpbQuantProdVend.Location = new System.Drawing.Point(12, 375);
            this.gpbQuantProdVend.Name = "gpbQuantProdVend";
            this.gpbQuantProdVend.Size = new System.Drawing.Size(552, 144);
            this.gpbQuantProdVend.TabIndex = 31;
            this.gpbQuantProdVend.TabStop = false;
            this.gpbQuantProdVend.Text = "Quantidade de Produtos Vendidos";
            // 
            // dgvQuantProdVend
            // 
            this.dgvQuantProdVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantProdVend.Location = new System.Drawing.Point(131, 39);
            this.dgvQuantProdVend.Name = "dgvQuantProdVend";
            this.dgvQuantProdVend.Size = new System.Drawing.Size(278, 79);
            this.dgvQuantProdVend.TabIndex = 44;
            // 
            // btnLimparQuantProdVend
            // 
            this.btnLimparQuantProdVend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimparQuantProdVend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparQuantProdVend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparQuantProdVend.ForeColor = System.Drawing.Color.White;
            this.btnLimparQuantProdVend.Location = new System.Drawing.Point(433, 84);
            this.btnLimparQuantProdVend.Name = "btnLimparQuantProdVend";
            this.btnLimparQuantProdVend.Size = new System.Drawing.Size(90, 34);
            this.btnLimparQuantProdVend.TabIndex = 43;
            this.btnLimparQuantProdVend.Text = "Limpar";
            this.btnLimparQuantProdVend.UseVisualStyleBackColor = false;
            this.btnLimparQuantProdVend.Click += new System.EventHandler(this.btnLimparQuantProdVend_Click);
            // 
            // btnCalcularQuantProd
            // 
            this.btnCalcularQuantProd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCalcularQuantProd.Enabled = false;
            this.btnCalcularQuantProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularQuantProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularQuantProd.ForeColor = System.Drawing.Color.White;
            this.btnCalcularQuantProd.Location = new System.Drawing.Point(433, 31);
            this.btnCalcularQuantProd.Name = "btnCalcularQuantProd";
            this.btnCalcularQuantProd.Size = new System.Drawing.Size(90, 44);
            this.btnCalcularQuantProd.TabIndex = 8;
            this.btnCalcularQuantProd.Text = "Calcular";
            this.btnCalcularQuantProd.UseVisualStyleBackColor = false;
            this.btnCalcularQuantProd.Click += new System.EventHandler(this.btnCalcularQuantProd_Click);
            // 
            // mtxtDataFinalQuantProd
            // 
            this.mtxtDataFinalQuantProd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataFinalQuantProd.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataFinalQuantProd.Location = new System.Drawing.Point(9, 113);
            this.mtxtDataFinalQuantProd.Mask = "00/00/0000";
            this.mtxtDataFinalQuantProd.Name = "mtxtDataFinalQuantProd";
            this.mtxtDataFinalQuantProd.Size = new System.Drawing.Size(112, 25);
            this.mtxtDataFinalQuantProd.TabIndex = 7;
            this.mtxtDataFinalQuantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataFinalQuantProd.ValidatingType = typeof(System.DateTime);
            this.mtxtDataFinalQuantProd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDataFinalQuantProd_MaskInputRejected);
            // 
            // mtxtDataInicialQuantProd
            // 
            this.mtxtDataInicialQuantProd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataInicialQuantProd.ForeColor = System.Drawing.Color.Purple;
            this.mtxtDataInicialQuantProd.Location = new System.Drawing.Point(9, 50);
            this.mtxtDataInicialQuantProd.Mask = "00/00/0000";
            this.mtxtDataInicialQuantProd.Name = "mtxtDataInicialQuantProd";
            this.mtxtDataInicialQuantProd.Size = new System.Drawing.Size(112, 25);
            this.mtxtDataInicialQuantProd.TabIndex = 6;
            this.mtxtDataInicialQuantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataInicialQuantProd.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataInicialQuantProd
            // 
            this.lblDataInicialQuantProd.AutoSize = true;
            this.lblDataInicialQuantProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicialQuantProd.Location = new System.Drawing.Point(17, 29);
            this.lblDataInicialQuantProd.Name = "lblDataInicialQuantProd";
            this.lblDataInicialQuantProd.Size = new System.Drawing.Size(97, 18);
            this.lblDataInicialQuantProd.TabIndex = 4;
            this.lblDataInicialQuantProd.Text = "Data Inicial";
            // 
            // lblDataFinalQuantProd
            // 
            this.lblDataFinalQuantProd.AutoSize = true;
            this.lblDataFinalQuantProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinalQuantProd.Location = new System.Drawing.Point(20, 92);
            this.lblDataFinalQuantProd.Name = "lblDataFinalQuantProd";
            this.lblDataFinalQuantProd.Size = new System.Drawing.Size(88, 18);
            this.lblDataFinalQuantProd.TabIndex = 5;
            this.lblDataFinalQuantProd.Text = "Data Final";
            // 
            // gpbQuantVendaVendedor
            // 
            this.gpbQuantVendaVendedor.Controls.Add(this.dgvQuantVend);
            this.gpbQuantVendaVendedor.Controls.Add(this.btnLimparQuantVendedorVend);
            this.gpbQuantVendaVendedor.Controls.Add(this.btnCalcularVendaVendedor);
            this.gpbQuantVendaVendedor.Controls.Add(this.cmbMeses);
            this.gpbQuantVendaVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbQuantVendaVendedor.ForeColor = System.Drawing.Color.BlueViolet;
            this.gpbQuantVendaVendedor.Location = new System.Drawing.Point(12, 219);
            this.gpbQuantVendaVendedor.Name = "gpbQuantVendaVendedor";
            this.gpbQuantVendaVendedor.Size = new System.Drawing.Size(552, 140);
            this.gpbQuantVendaVendedor.TabIndex = 32;
            this.gpbQuantVendaVendedor.TabStop = false;
            this.gpbQuantVendaVendedor.Text = "Quanto Cada Vendedor Vendeu";
            // 
            // dgvQuantVend
            // 
            this.dgvQuantVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantVend.Location = new System.Drawing.Point(84, 64);
            this.dgvQuantVend.Name = "dgvQuantVend";
            this.dgvQuantVend.Size = new System.Drawing.Size(325, 61);
            this.dgvQuantVend.TabIndex = 45;
            // 
            // btnLimparQuantVendedorVend
            // 
            this.btnLimparQuantVendedorVend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimparQuantVendedorVend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparQuantVendedorVend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparQuantVendedorVend.ForeColor = System.Drawing.Color.White;
            this.btnLimparQuantVendedorVend.Location = new System.Drawing.Point(433, 79);
            this.btnLimparQuantVendedorVend.Name = "btnLimparQuantVendedorVend";
            this.btnLimparQuantVendedorVend.Size = new System.Drawing.Size(90, 34);
            this.btnLimparQuantVendedorVend.TabIndex = 44;
            this.btnLimparQuantVendedorVend.Text = "Limpar";
            this.btnLimparQuantVendedorVend.UseVisualStyleBackColor = false;
            this.btnLimparQuantVendedorVend.Click += new System.EventHandler(this.btnLimparQuantVendedorVend_Click);
            // 
            // btnCalcularVendaVendedor
            // 
            this.btnCalcularVendaVendedor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCalcularVendaVendedor.Enabled = false;
            this.btnCalcularVendaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularVendaVendedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularVendaVendedor.ForeColor = System.Drawing.Color.White;
            this.btnCalcularVendaVendedor.Location = new System.Drawing.Point(433, 29);
            this.btnCalcularVendaVendedor.Name = "btnCalcularVendaVendedor";
            this.btnCalcularVendaVendedor.Size = new System.Drawing.Size(90, 44);
            this.btnCalcularVendaVendedor.TabIndex = 5;
            this.btnCalcularVendaVendedor.Text = "Calcular";
            this.btnCalcularVendaVendedor.UseVisualStyleBackColor = false;
            this.btnCalcularVendaVendedor.Click += new System.EventHandler(this.btnCalcularVendaVendedor_Click);
            // 
            // cmbMeses
            // 
            this.cmbMeses.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeses.ForeColor = System.Drawing.Color.Purple;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbMeses.Location = new System.Drawing.Point(181, 22);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(133, 25);
            this.cmbMeses.TabIndex = 0;
            this.cmbMeses.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorios.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblRelatorios.Location = new System.Drawing.Point(67, 23);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(131, 28);
            this.lblRelatorios.TabIndex = 33;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(526, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 30);
            this.btnSair.TabIndex = 35;
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
            this.btnMenu.Location = new System.Drawing.Point(431, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 30);
            this.btnMenu.TabIndex = 34;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pcbRelatorios
            // 
            this.pcbRelatorios.Image = global::Estoque.Properties.Resources.download2;
            this.pcbRelatorios.Location = new System.Drawing.Point(12, 12);
            this.pcbRelatorios.Name = "pcbRelatorios";
            this.pcbRelatorios.Size = new System.Drawing.Size(48, 48);
            this.pcbRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRelatorios.TabIndex = 36;
            this.pcbRelatorios.TabStop = false;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(576, 531);
            this.Controls.Add(this.pcbRelatorios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblRelatorios);
            this.Controls.Add(this.gpbQuantVendaVendedor);
            this.Controls.Add(this.gpbQuantProdVend);
            this.Controls.Add(this.gpbFatDatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.gpbFatDatas.ResumeLayout(false);
            this.gpbFatDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoFaturamento)).EndInit();
            this.gpbQuantProdVend.ResumeLayout(false);
            this.gpbQuantProdVend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantProdVend)).EndInit();
            this.gpbQuantVendaVendedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantVend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRelatorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFatDatas;
        private System.Windows.Forms.MaskedTextBox mtxtDataFinalFaturamento;
        private System.Windows.Forms.MaskedTextBox mtxtDataInicialFaturamento;
        private System.Windows.Forms.Label lblDataInicialFat;
        private System.Windows.Forms.Label lblDataFinalFat;
        private System.Windows.Forms.GroupBox gpbQuantProdVend;
        private System.Windows.Forms.MaskedTextBox mtxtDataFinalQuantProd;
        private System.Windows.Forms.MaskedTextBox mtxtDataInicialQuantProd;
        private System.Windows.Forms.Label lblDataInicialQuantProd;
        private System.Windows.Forms.Label lblDataFinalQuantProd;
        private System.Windows.Forms.GroupBox gpbQuantVendaVendedor;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Button btnCalcularFaturamento;
        private System.Windows.Forms.Button btnCalcularQuantProd;
        private System.Windows.Forms.Button btnCalcularVendaVendedor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLimparFatDatas;
        private System.Windows.Forms.Button btnLimparQuantProdVend;
        private System.Windows.Forms.Button btnLimparQuantVendedorVend;
        private System.Windows.Forms.PictureBox pcbRelatorios;
        private System.Windows.Forms.DataGridView dgvResultadoFaturamento;
        private System.Windows.Forms.DataGridView dgvQuantProdVend;
        private System.Windows.Forms.DataGridView dgvQuantVend;
    }
}