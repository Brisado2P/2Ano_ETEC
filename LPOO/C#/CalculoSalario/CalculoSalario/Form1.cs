using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class frmCalculoSalFinal : Form
    {
        Validacao val = new Validacao();

        Calculos cal = new Calculos();

        public frmCalculoSalFinal()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalFinal.Text = "";
            txtSalFixo.Text = "";
            txtVendido.Text = "";
            txtComissao.Text = "";
            txtImposto.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            double SalFixo = Convert.ToDouble(txtSalFixo.Text);
            

            if (txtVendido.Text == "")//verifica se a quantidade de vendas esta vazia
            {
                double Vendas = 0;
                txtVendido.Text = "0";
                double comissao = cal.CalculoComissao(Vendas);
                cal.Salario = comissao + SalFixo; // salario sem os impostos

                txtImposto.Text = "R$ " + Convert.ToString(cal.CalculoImposto());

                txtSalFinal.Text = "R$ " + Convert.ToString(cal.CalculoSalario(SalFixo, Vendas)); //salario com os impostos descontados



                if (cal.CalculoComissao(Vendas) == 0)
                {
                    txtComissao.Text = "Sem comissão";
                }
                else
                {
                    txtComissao.Text = "R$ " + Convert.ToString(comissao);
                }
            }
            else
            {
                double Vendas = Convert.ToDouble(txtVendido.Text);
                double comissao = cal.CalculoComissao(Vendas);
                cal.Salario = comissao + SalFixo;

                txtImposto.Text = "R$ " + Convert.ToString(cal.CalculoImposto());

                txtSalFinal.Text = "R$ " + Convert.ToString(cal.CalculoSalario(SalFixo, Vendas));



                if (cal.CalculoComissao(Vendas) == 0)
                {
                    txtComissao.Text = "Sem comissão";
                }
                else
                {
                    txtComissao.Text = "R$ " + Convert.ToString(comissao);
                }
            }

        }

        private void txtSalFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtVendido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtSalFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void lblImpostos_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculoSalFinal_Load(object sender, EventArgs e)
        {

        }
    }
}
