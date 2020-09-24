using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questoes_novo
{

    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
            Variaveis.SubTotal = Variaveis.questao1 + Variaveis.questao2 + Variaveis.questao3 + Variaveis.questao4 + Variaveis.questao5;
            Variaveis.ValorTotal = Variaveis.SubTotal;
        }

     

        private void frmResultado_Load(object sender, EventArgs e)
        {
            lblNotaRes.Text = Convert.ToString(Variaveis.ValorTotal) + "  de 10";

            if (Variaveis.ValorTotal <= 4)
            {
                lblMensao.Text = "I";
            }
                else if(Variaveis.ValorTotal == 6 || Variaveis.ValorTotal == 5)
                {
                    lblMensao.Text = "R";
                }
                    else if(Variaveis.ValorTotal == 8 || Variaveis.ValorTotal == 7)
                    {
                        lblMensao.Text = "B";
                    }
                        else
                        {
                            lblMensao.Text = "MB";
                        }

            if (Variaveis.Checked1 == 1)
            {
                lblMostrar1.Text = "1 - Andromeda";
                lblMostrar1.ForeColor = Color.Black;
                lblMostrar1.BackColor = Color.LawnGreen;
            }
                else if(Variaveis.Checked1 == 2)
                {
                    lblMostrar1.Text = "1 - Olho negro";
                    lblMostrar1.ForeColor = Color.White;
                    lblMostrar1.BackColor = Color.Red;
                }
                    else if (Variaveis.Checked1 == 3)
                    {
                        lblMostrar1.Text = "1 - Galáxia triângulo";
                        lblMostrar1.ForeColor = Color.White;
                        lblMostrar1.BackColor = Color.Red;
                    }
                        else if (Variaveis.Checked1 == 4)
                        {
                            lblMostrar1.Text = "1 - Galáxia de Bode";
                            lblMostrar1.ForeColor = Color.White;
                            lblMostrar1.BackColor = Color.Red;
                        }

            if (Variaveis.Checked2 == 2)
            {
                lblMostrar2.Text = "2 - Sol";
                lblMostrar2.ForeColor = Color.Black;
                lblMostrar2.BackColor = Color.LawnGreen;
            }
                else if (Variaveis.Checked2 == 1)
                {
                    lblMostrar2.Text = "2 - Sirius";
                    lblMostrar2.ForeColor = Color.White;
                    lblMostrar2.BackColor = Color.Red;
                }
                    else if (Variaveis.Checked2 == 3)
                    {
                        lblMostrar2.Text = "2 - Alpha Centrauri";
                        lblMostrar2.ForeColor = Color.White;
                        lblMostrar2.BackColor = Color.Red;
                    }
                        else if (Variaveis.Checked2 == 4)
                        {
                            lblMostrar2.Text = "2 - Acturo";
                            lblMostrar2.ForeColor = Color.White;
                            lblMostrar2.BackColor = Color.Red;
                        }

            if (Variaveis.Checked3 == 3)
            {
                lblMostrar3.Text = "3 - Eclipse";
                lblMostrar3.ForeColor = Color.Black;
                lblMostrar3.BackColor = Color.LawnGreen;
            }
                else if (Variaveis.Checked3 == 1)
                {
                    lblMostrar3.Text = "3 - Chuva de meteoros";
                    lblMostrar3.ForeColor = Color.White;
                    lblMostrar3.BackColor = Color.Red;
                }
                    else if (Variaveis.Checked3 == 2)
                    {
                        lblMostrar3.Text = "3 - Erupção de raio gama";
                        lblMostrar3.ForeColor = Color.White;
                        lblMostrar3.BackColor = Color.Red;
                    }
                        else if (Variaveis.Checked3 == 4)
                        {
                            lblMostrar3.Text = "3 - Super lua";
                            lblMostrar3.ForeColor = Color.White;
                            lblMostrar3.BackColor = Color.Red;
                        }

            if (Variaveis.Checked4 == 3)
            {
                lblMostrar4.Text = "4 - 13,8 Bilhões";
                lblMostrar4.ForeColor = Color.Black;
                lblMostrar4.BackColor = Color.LawnGreen;
            }
                else if (Variaveis.Checked4 == 1)
                {
                    lblMostrar4.Text = "4 - 5,4 Milhões";
                    lblMostrar4.ForeColor = Color.White;
                    lblMostrar4.BackColor = Color.Red;
                }
                    else if (Variaveis.Checked4 == 2)
                    {
                        lblMostrar4.Text = "4 - 3,9 Bilhões";
                        lblMostrar4.ForeColor = Color.White;
                        lblMostrar4.BackColor = Color.Red;
                    }
                        else if (Variaveis.Checked4 == 4)
                        {
                            lblMostrar4.Text = "4 - 10,6 Bilhões";
                            lblMostrar4.ForeColor = Color.White;
                            lblMostrar4.BackColor = Color.Red;
                        }

            if (Variaveis.Checked5 == 3)
            {
                lblMostrar5.Text = "5 - 8";
                lblMostrar5.ForeColor = Color.Black;
                lblMostrar5.BackColor = Color.LawnGreen;
            }
                else if (Variaveis.Checked5 == 1)
                {
                    lblMostrar5.Text = "5 - 5";
                    lblMostrar5.ForeColor = Color.White;
                    lblMostrar5.BackColor = Color.Red;
                }
                    else if (Variaveis.Checked5 == 2)
                    {
                        lblMostrar5.Text = "5 - 7";
                        lblMostrar5.ForeColor = Color.White;
                        lblMostrar5.BackColor = Color.Red;
                    }
                        else if (Variaveis.Checked5 == 4)
                        {
                            lblMostrar5.Text = "5 - 13";
                            lblMostrar5.ForeColor = Color.White;
                            lblMostrar5.BackColor = Color.Red;
                        }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTentarNovamente_Click(object sender, EventArgs e)
        {
            Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            Variaveis.SubTotal = 0;
            Variaveis.ValorTotal = 0;
            Variaveis.questao1 = 0;
            Variaveis.questao2 = 0;
            Variaveis.questao3 = 0;
            Variaveis.questao4 = 0;
            Variaveis.questao5 = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMostrar1_Click(object sender, EventArgs e)
        {

        }
    }
}
