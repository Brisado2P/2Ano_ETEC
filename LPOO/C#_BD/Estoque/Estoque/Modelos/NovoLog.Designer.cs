namespace Estoque
{
    partial class frmNovoLog
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
            this.lblSenhaAdm = new System.Windows.Forms.Label();
            this.lblLogAdm = new System.Windows.Forms.Label();
            this.txtLogAdm = new System.Windows.Forms.TextBox();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCriarNovoUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenhaAdm
            // 
            this.lblSenhaAdm.AutoSize = true;
            this.lblSenhaAdm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAdm.ForeColor = System.Drawing.Color.Purple;
            this.lblSenhaAdm.Location = new System.Drawing.Point(95, 141);
            this.lblSenhaAdm.Name = "lblSenhaAdm";
            this.lblSenhaAdm.Size = new System.Drawing.Size(172, 18);
            this.lblSenhaAdm.TabIndex = 2;
            this.lblSenhaAdm.Text = "Senha Admnistrador";
            // 
            // lblLogAdm
            // 
            this.lblLogAdm.AutoSize = true;
            this.lblLogAdm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogAdm.ForeColor = System.Drawing.Color.Purple;
            this.lblLogAdm.Location = new System.Drawing.Point(98, 76);
            this.lblLogAdm.Name = "lblLogAdm";
            this.lblLogAdm.Size = new System.Drawing.Size(165, 18);
            this.lblLogAdm.TabIndex = 3;
            this.lblLogAdm.Text = "Login Admnistrador";
            // 
            // txtLogAdm
            // 
            this.txtLogAdm.BackColor = System.Drawing.Color.White;
            this.txtLogAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogAdm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtLogAdm.Location = new System.Drawing.Point(98, 102);
            this.txtLogAdm.Name = "txtLogAdm";
            this.txtLogAdm.Size = new System.Drawing.Size(168, 26);
            this.txtLogAdm.TabIndex = 4;
            this.txtLogAdm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.BackColor = System.Drawing.Color.White;
            this.txtSenhaAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAdm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtSenhaAdm.Location = new System.Drawing.Point(98, 162);
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.PasswordChar = '*';
            this.txtSenhaAdm.Size = new System.Drawing.Size(168, 26);
            this.txtSenhaAdm.TabIndex = 5;
            this.txtSenhaAdm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaAdm.TextChanged += new System.EventHandler(this.txtSenhaAdm_TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnVerificar.Enabled = false;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(95, 208);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(165, 33);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = global::Estoque.Properties.Resources.circled_left_22;
            this.btnVoltar.Location = new System.Drawing.Point(287, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 39);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // lblCriarNovoUsuario
            // 
            this.lblCriarNovoUsuario.AutoSize = true;
            this.lblCriarNovoUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarNovoUsuario.ForeColor = System.Drawing.Color.Purple;
            this.lblCriarNovoUsuario.Location = new System.Drawing.Point(66, 27);
            this.lblCriarNovoUsuario.Name = "lblCriarNovoUsuario";
            this.lblCriarNovoUsuario.Size = new System.Drawing.Size(201, 22);
            this.lblCriarNovoUsuario.TabIndex = 25;
            this.lblCriarNovoUsuario.Text = "Criar Novo Vendedor";
            this.lblCriarNovoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estoque.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmNovoLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCriarNovoUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtSenhaAdm);
            this.Controls.Add(this.txtLogAdm);
            this.Controls.Add(this.lblLogAdm);
            this.Controls.Add(this.lblSenhaAdm);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovoLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoLog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaAdm;
        private System.Windows.Forms.Label lblLogAdm;
        private System.Windows.Forms.TextBox txtLogAdm;
        private System.Windows.Forms.TextBox txtSenhaAdm;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCriarNovoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}