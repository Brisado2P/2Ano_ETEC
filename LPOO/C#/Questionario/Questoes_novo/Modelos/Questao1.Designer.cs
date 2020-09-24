namespace Questoes_novo
{
    partial class frmQuestao1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestao1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuestao1 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnCancelarProva = new System.Windows.Forms.Button();
            this.rdbGalaxiaBode = new System.Windows.Forms.RadioButton();
            this.rdbGalaxiaTriangulo = new System.Windows.Forms.RadioButton();
            this.rdbGalaxiaOlhoNegro = new System.Windows.Forms.RadioButton();
            this.rdbAndromeda = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuestao1
            // 
            this.lblQuestao1.AutoSize = true;
            this.lblQuestao1.BackColor = System.Drawing.Color.DarkBlue;
            this.lblQuestao1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestao1.Location = new System.Drawing.Point(12, 199);
            this.lblQuestao1.Name = "lblQuestao1";
            this.lblQuestao1.Size = new System.Drawing.Size(349, 26);
            this.lblQuestao1.TabIndex = 1;
            this.lblQuestao1.Text = "Qual a Galáxia mais próxima da nossa?";
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProximo.BackgroundImage")));
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(557, 458);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(68, 37);
            this.btnProximo.TabIndex = 20;
            this.btnProximo.Text = ">>";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click_1);
            // 
            // btnCancelarProva
            // 
            this.btnCancelarProva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarProva.BackgroundImage")));
            this.btnCancelarProva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProva.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProva.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProva.Location = new System.Drawing.Point(231, 461);
            this.btnCancelarProva.Name = "btnCancelarProva";
            this.btnCancelarProva.Size = new System.Drawing.Size(169, 31);
            this.btnCancelarProva.TabIndex = 19;
            this.btnCancelarProva.Text = "Cancelar prova";
            this.btnCancelarProva.UseVisualStyleBackColor = true;
            this.btnCancelarProva.Click += new System.EventHandler(this.btnCancelarProva_Click);
            // 
            // rdbGalaxiaBode
            // 
            this.rdbGalaxiaBode.AutoSize = true;
            this.rdbGalaxiaBode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbGalaxiaBode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGalaxiaBode.Location = new System.Drawing.Point(374, 357);
            this.rdbGalaxiaBode.Name = "rdbGalaxiaBode";
            this.rdbGalaxiaBode.Size = new System.Drawing.Size(169, 30);
            this.rdbGalaxiaBode.TabIndex = 25;
            this.rdbGalaxiaBode.TabStop = true;
            this.rdbGalaxiaBode.Text = "Galáxia de Bode";
            this.rdbGalaxiaBode.UseVisualStyleBackColor = true;
            // 
            // rdbGalaxiaTriangulo
            // 
            this.rdbGalaxiaTriangulo.AutoSize = true;
            this.rdbGalaxiaTriangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbGalaxiaTriangulo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGalaxiaTriangulo.Location = new System.Drawing.Point(64, 357);
            this.rdbGalaxiaTriangulo.Name = "rdbGalaxiaTriangulo";
            this.rdbGalaxiaTriangulo.Size = new System.Drawing.Size(202, 30);
            this.rdbGalaxiaTriangulo.TabIndex = 24;
            this.rdbGalaxiaTriangulo.TabStop = true;
            this.rdbGalaxiaTriangulo.Text = "Galáxia do triângulo";
            this.rdbGalaxiaTriangulo.UseVisualStyleBackColor = true;
            // 
            // rdbGalaxiaOlhoNegro
            // 
            this.rdbGalaxiaOlhoNegro.AutoSize = true;
            this.rdbGalaxiaOlhoNegro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbGalaxiaOlhoNegro.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGalaxiaOlhoNegro.Location = new System.Drawing.Point(374, 268);
            this.rdbGalaxiaOlhoNegro.Name = "rdbGalaxiaOlhoNegro";
            this.rdbGalaxiaOlhoNegro.Size = new System.Drawing.Size(125, 30);
            this.rdbGalaxiaOlhoNegro.TabIndex = 23;
            this.rdbGalaxiaOlhoNegro.TabStop = true;
            this.rdbGalaxiaOlhoNegro.Text = "Olho negro";
            this.rdbGalaxiaOlhoNegro.UseVisualStyleBackColor = true;
            // 
            // rdbAndromeda
            // 
            this.rdbAndromeda.AutoSize = true;
            this.rdbAndromeda.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rdbAndromeda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAndromeda.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAndromeda.Location = new System.Drawing.Point(98, 268);
            this.rdbAndromeda.Name = "rdbAndromeda";
            this.rdbAndromeda.Size = new System.Drawing.Size(129, 30);
            this.rdbAndromeda.TabIndex = 22;
            this.rdbAndromeda.TabStop = true;
            this.rdbAndromeda.Text = "Andrômeda";
            this.rdbAndromeda.UseVisualStyleBackColor = false;
            // 
            // frmQuestao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(637, 507);
            this.Controls.Add(this.rdbGalaxiaBode);
            this.Controls.Add(this.rdbGalaxiaTriangulo);
            this.Controls.Add(this.rdbGalaxiaOlhoNegro);
            this.Controls.Add(this.rdbAndromeda);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnCancelarProva);
            this.Controls.Add(this.lblQuestao1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuestao1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questao1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuestao1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnCancelarProva;
        private System.Windows.Forms.RadioButton rdbGalaxiaBode;
        private System.Windows.Forms.RadioButton rdbGalaxiaTriangulo;
        private System.Windows.Forms.RadioButton rdbGalaxiaOlhoNegro;
        private System.Windows.Forms.RadioButton rdbAndromeda;
    }
}