namespace Estoque
{
    partial class frmBemVindo
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblSemLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrarAdm = new System.Windows.Forms.Button();
            this.lblEntreComeçar = new System.Windows.Forms.Label();
            this.pcbSenha = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(35, 239);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(347, 33);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Purple;
            this.lblBemVindo.Location = new System.Drawing.Point(56, 26);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(316, 22);
            this.lblBemVindo.TabIndex = 2;
            this.lblBemVindo.Text = "Bem Vindo ao Estoque Sorveteria\r\n";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSemLogin
            // 
            this.lblSemLogin.AutoSize = true;
            this.lblSemLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemLogin.ForeColor = System.Drawing.Color.Purple;
            this.lblSemLogin.Location = new System.Drawing.Point(44, 298);
            this.lblSemLogin.Name = "lblSemLogin";
            this.lblSemLogin.Size = new System.Drawing.Size(317, 28);
            this.lblSemLogin.TabIndex = 3;
            this.lblSemLogin.Text = "Entre como Administrador";
            this.lblSemLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Purple;
            this.txtLogin.HideSelection = false;
            this.txtLogin.Location = new System.Drawing.Point(88, 127);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(289, 19);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TabStop = false;
            this.txtLogin.Text = "Nome";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(376, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 30);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Black;
            this.pnlUsuario.Location = new System.Drawing.Point(32, 152);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(345, 1);
            this.pnlUsuario.TabIndex = 12;
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.Color.Black;
            this.pnlSenha.Location = new System.Drawing.Point(33, 207);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(347, 1);
            this.pnlSenha.TabIndex = 16;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Purple;
            this.txtSenha.HideSelection = false;
            this.txtSenha.Location = new System.Drawing.Point(88, 182);
            this.txtSenha.MaxLength = 26;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(289, 19);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.TabStop = false;
            this.txtSenha.Text = "senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnEntrarAdm
            // 
            this.btnEntrarAdm.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnEntrarAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarAdm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarAdm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEntrarAdm.Location = new System.Drawing.Point(34, 349);
            this.btnEntrarAdm.Name = "btnEntrarAdm";
            this.btnEntrarAdm.Size = new System.Drawing.Size(347, 33);
            this.btnEntrarAdm.TabIndex = 19;
            this.btnEntrarAdm.Text = "Entrar";
            this.btnEntrarAdm.UseVisualStyleBackColor = false;
            this.btnEntrarAdm.Click += new System.EventHandler(this.btnSoliciteAgora_Click);
            // 
            // lblEntreComeçar
            // 
            this.lblEntreComeçar.AutoSize = true;
            this.lblEntreComeçar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreComeçar.ForeColor = System.Drawing.Color.Purple;
            this.lblEntreComeçar.Location = new System.Drawing.Point(12, 68);
            this.lblEntreComeçar.Name = "lblEntreComeçar";
            this.lblEntreComeçar.Size = new System.Drawing.Size(402, 28);
            this.lblEntreComeçar.TabIndex = 20;
            this.lblEntreComeçar.Text = "Entre na sua Conta para Começar";
            this.lblEntreComeçar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbSenha
            // 
            this.pcbSenha.Image = global::Estoque.Properties.Resources.img_131108;
            this.pcbSenha.Location = new System.Drawing.Point(35, 170);
            this.pcbSenha.Name = "pcbSenha";
            this.pcbSenha.Size = new System.Drawing.Size(32, 34);
            this.pcbSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSenha.TabIndex = 17;
            this.pcbSenha.TabStop = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Image = global::Estoque.Properties.Resources.User_icon_BLACK_01;
            this.pcbUsuario.Location = new System.Drawing.Point(33, 111);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(34, 38);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUsuario.TabIndex = 14;
            this.pcbUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estoque.Properties.Resources.sorveteria_a_fachada_do_icone_da_loja_em_um_design_de_estilo_plano_2963_238;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(426, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEntreComeçar);
            this.Controls.Add(this.btnEntrarAdm);
            this.Controls.Add(this.pcbSenha);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSemLogin);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo ao Estoque";
            this.Load += new System.EventHandler(this.frmBemVindo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblSemLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.PictureBox pcbSenha;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrarAdm;
        private System.Windows.Forms.Label lblEntreComeçar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

