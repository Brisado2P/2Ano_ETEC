using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sal_double, hr_double, result1 = 0, result2 = 0, hrExtra = 0, totalHr = 0, SalFinal = 0;
            bool sucesso1 = Double.TryParse(txtSalario.Text, out sal_double);
            result1 = sal_double / 22;
            result2 = result1 / 8;
            hrExtra = result2 * 2;

            bool sucesso2 = Double.TryParse(txtQuantidadeDeHorasExtras.Text, out hr_double);
            if (hr_double > 40)
            {
                MessageBox.Show("Número máximo de horas deve ser 40.");
                
            }
            else
            {
                totalHr = hrExtra * hr_double;
                SalFinal = sal_double + totalHr;

                txtValorHora.Text = "R$ " + Convert.ToString(result2);
                txtValorHoraExtra.Text = "R$ " + Convert.ToString(hrExtra);
                txtGanhoPelasHorasExtras.Text = "R$ " + Convert.ToString(totalHr);
                txtSalarioFInal.Text = "R$ " + Convert.ToString(SalFinal);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGanhoPelasHorasExtras.Text = "";
            txtQuantidadeDeHorasExtras.Text = "";
            txtSalario.Text = "";
            txtSalarioFInal.Text = "";
            txtValorHora.Text = "";
            txtValorHoraExtra.Text = "";
            txtSalario.Focus();
        }
    }
}
