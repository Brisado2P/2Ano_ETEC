using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMedias
{
    public partial class frmCalculeMedia : Form
    {
        Validacao val = new Validacao();
        MediaTresValores media = new MediaTresValores();

        public frmCalculeMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se esta vazio
            if (txtValor1.Text == "")
            {
                txtValor1.Text = "0";
            }
            if (txtValor2.Text == "")
            {
                txtValor2.Text = "0";
            }
            if (txtValor3.Text == "")
            {
                txtValor3.Text = "0";
            }

            double Valor1 = Convert.ToDouble(txtValor1.Text);
            double Valor2 = Convert.ToDouble(txtValor2.Text);
            double Valor3 = Convert.ToDouble(txtValor3.Text);

            // Verifica se esta entre 0 e 10
            if (Valor1 < 0 || Valor1 > 10)
            {
                MessageBox.Show("Insira somente números entre 0 e 10");
            }
            else if (Valor2 < 0 || Valor2 > 10)
            {
                MessageBox.Show("Insira somente números entre 0 e 10");
            }
            else if (Valor3 < 0 || Valor3 > 10)
            {
                MessageBox.Show("Insira somente números entre 0 e 10");
            }
            else
            {
                // Efetua a conta
                double Verifica = media.DescartarNotaMenor(Valor1, Valor2, Valor3);

                if (Verifica == 1)
                {
                    txtNota.Text = Convert.ToString(media.CalcularMediaDoisValores(Valor2, Valor3));
                }
                else if (Verifica == 2)
                {
                    txtNota.Text = Convert.ToString(media.CalcularMediaDoisValores(Valor1, Valor3));
                }
                else
                {
                    txtNota.Text = Convert.ToString(media.CalcularMediaDoisValores(Valor1, Valor2));
                }

            }
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtValor3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            txtNota.Text = "";
        }

        private void frmCalculeMedia_Load(object sender, EventArgs e)
        {

        }
    }
}
