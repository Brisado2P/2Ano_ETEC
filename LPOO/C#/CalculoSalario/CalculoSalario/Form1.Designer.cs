namespace CalculoSalario
{
    partial class frmCalculoSalFinal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoSalFinal));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSalFixo = new System.Windows.Forms.Label();
            this.lblVendido = new System.Windows.Forms.Label();
            this.txtSalFixo = new System.Windows.Forms.TextBox();
            this.txtVendido = new System.Windows.Forms.TextBox();
            this.lblSalFinal = new System.Windows.Forms.Label();
            this.txtSalFinal = new System.Windows.Forms.TextBox();
            this.pctSalario = new System.Windows.Forms.PictureBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lblImpostos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(24, 412);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(403, 412);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSalFixo
            // 
            this.lblSalFixo.AutoSize = true;
            this.lblSalFixo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFixo.Location = new System.Drawing.Point(73, 162);
            this.lblSalFixo.Name = "lblSalFixo";
            this.lblSalFixo.Size = new System.Drawing.Size(109, 21);
            this.lblSalFixo.TabIndex = 2;
            this.lblSalFixo.Text = "Salário fixo";
            // 
            // lblVendido
            // 
            this.lblVendido.AutoSize = true;
            this.lblVendido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendido.Location = new System.Drawing.Point(87, 210);
            this.lblVendido.Name = "lblVendido";
            this.lblVendido.Size = new System.Drawing.Size(86, 21);
            this.lblVendido.TabIndex = 3;
            this.lblVendido.Text = "Vendido";
            // 
            // txtSalFixo
            // 
            this.txtSalFixo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFixo.Location = new System.Drawing.Point(287, 157);
            this.txtSalFixo.Name = "txtSalFixo";
            this.txtSalFixo.Size = new System.Drawing.Size(134, 26);
            this.txtSalFixo.TabIndex = 4;
            this.txtSalFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalFixo_KeyPress);
            // 
            // txtVendido
            // 
            this.txtVendido.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendido.Location = new System.Drawing.Point(287, 205);
            this.txtVendido.Name = "txtVendido";
            this.txtVendido.Size = new System.Drawing.Size(134, 26);
            this.txtVendido.TabIndex = 5;
            this.txtVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendido_KeyPress);
            // 
            // lblSalFinal
            // 
            this.lblSalFinal.AutoSize = true;
            this.lblSalFinal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFinal.Location = new System.Drawing.Point(109, 293);
            this.lblSalFinal.Name = "lblSalFinal";
            this.lblSalFinal.Size = new System.Drawing.Size(115, 21);
            this.lblSalFinal.TabIndex = 6;
            this.lblSalFinal.Text = "Salário final";
            // 
            // txtSalFinal
            // 
            this.txtSalFinal.Enabled = false;
            this.txtSalFinal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFinal.Location = new System.Drawing.Point(101, 335);
            this.txtSalFinal.Name = "txtSalFinal";
            this.txtSalFinal.Size = new System.Drawing.Size(134, 26);
            this.txtSalFinal.TabIndex = 5;
            this.txtSalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalFinal_KeyPress);
            // 
            // pctSalario
            // 
            this.pctSalario.Image = ((System.Drawing.Image)(resources.GetObject("pctSalario.Image")));
            this.pctSalario.Location = new System.Drawing.Point(12, 13);
            this.pctSalario.Name = "pctSalario";
            this.pctSalario.Size = new System.Drawing.Size(170, 125);
            this.pctSalario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalario.TabIndex = 7;
            this.pctSalario.TabStop = false;
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.Location = new System.Drawing.Point(306, 293);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(96, 21);
            this.lblComissao.TabIndex = 8;
            this.lblComissao.Text = "Comissão";
            // 
            // txtComissao
            // 
            this.txtComissao.Enabled = false;
            this.txtComissao.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(287, 335);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(134, 26);
            this.txtComissao.TabIndex = 9;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(211, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 29);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Calcule o seu salário!";
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImposto.Location = new System.Drawing.Point(196, 426);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(134, 26);
            this.txtImposto.TabIndex = 11;
            this.txtImposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblImpostos
            // 
            this.lblImpostos.AutoSize = true;
            this.lblImpostos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostos.Location = new System.Drawing.Point(220, 390);
            this.lblImpostos.Name = "lblImpostos";
            this.lblImpostos.Size = new System.Drawing.Size(90, 21);
            this.lblImpostos.TabIndex = 12;
            this.lblImpostos.Text = "Impostos";
            this.lblImpostos.Click += new System.EventHandler(this.lblImpostos_Click);
            // 
            // frmCalculoSalFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 485);
            this.Controls.Add(this.lblSalFinal);
            this.Controls.Add(this.lblImpostos);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.pctSalario);
            this.Controls.Add(this.txtSalFinal);
            this.Controls.Add(this.txtVendido);
            this.Controls.Add(this.txtSalFixo);
            this.Controls.Add(this.lblVendido);
            this.Controls.Add(this.lblSalFixo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCalculoSalFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo do Salário Final ";
            this.Load += new System.EventHandler(this.frmCalculoSalFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSalFixo;
        private System.Windows.Forms.Label lblVendido;
        private System.Windows.Forms.TextBox txtSalFixo;
        private System.Windows.Forms.TextBox txtVendido;
        private System.Windows.Forms.Label lblSalFinal;
        private System.Windows.Forms.TextBox txtSalFinal;
        private System.Windows.Forms.PictureBox pctSalario;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label lblImpostos;
    }
}

