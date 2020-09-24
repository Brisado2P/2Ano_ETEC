namespace Estoque
{
    partial class frmBemVindo1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSorveteria = new System.Windows.Forms.Label();
            this.pcbSorveteria = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSorveteria)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // lblSorveteria
            // 
            this.lblSorveteria.AutoSize = true;
            this.lblSorveteria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorveteria.ForeColor = System.Drawing.Color.Indigo;
            this.lblSorveteria.Location = new System.Drawing.Point(7, 25);
            this.lblSorveteria.Name = "lblSorveteria";
            this.lblSorveteria.Size = new System.Drawing.Size(468, 93);
            this.lblSorveteria.TabIndex = 0;
            this.lblSorveteria.Text = "Sorveteria ";
            this.lblSorveteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbSorveteria
            // 
            this.pcbSorveteria.BackColor = System.Drawing.Color.LavenderBlush;
            this.pcbSorveteria.Image = global::Estoque.Properties.Resources.sorveteria_a_fachada_do_icone_da_loja_em_um_design_de_estilo_plano_2963_238;
            this.pcbSorveteria.Location = new System.Drawing.Point(79, 118);
            this.pcbSorveteria.Name = "pcbSorveteria";
            this.pcbSorveteria.Size = new System.Drawing.Size(284, 278);
            this.pcbSorveteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSorveteria.TabIndex = 1;
            this.pcbSorveteria.TabStop = false;
            // 
            // frmBemVindo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(463, 408);
            this.Controls.Add(this.pcbSorveteria);
            this.Controls.Add(this.lblSorveteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBemVindo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBemVindo1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSorveteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSorveteria;
        private System.Windows.Forms.PictureBox pcbSorveteria;

    }
}