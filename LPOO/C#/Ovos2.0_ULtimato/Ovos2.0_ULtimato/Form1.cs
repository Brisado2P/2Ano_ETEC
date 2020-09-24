using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovos2._0_ULtimato
{
    public partial class frm1 : Form
    {
        Validação v = new Validação();

        public frm1()
        {
            InitializeComponent();
        }

        public static class variaveis
        {
            public static double TotalParcialAoLeite200;
            public static double TotalParcialAoLeite500;
            public static double TotalParcialBranco200;
            public static double TotalParcialBranco500;
            public static double QtdeAoLeite200;
            public static double QtdeAoLeite500;
            public static double QtdeBranco200;
            public static double QtdeBranco500;
            public static double subTotal;
            public static double Total;
        }

        private void txtQtdeAoLeite200_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            Console.WriteLine(variaveis.TotalParcialAoLeite200);
            Console.WriteLine(variaveis.TotalParcialAoLeite500);
            Console.WriteLine(variaveis.TotalParcialBranco200);
            Console.WriteLine(variaveis.TotalParcialBranco500);
            Console.WriteLine(variaveis.subTotal);
           


            if (variaveis.TotalParcialAoLeite200 == 0)
                {
                    variaveis.subTotal = (variaveis.TotalParcialAoLeite500 + variaveis.TotalParcialBranco200 + variaveis.TotalParcialBranco500) - variaveis.TotalParcialAoLeite200;
                }
                else if (variaveis.TotalParcialAoLeite500 == 0)
                {
                    variaveis.subTotal = (variaveis.TotalParcialAoLeite200 + variaveis.TotalParcialBranco200 + variaveis.TotalParcialBranco500) - variaveis.TotalParcialAoLeite500;
                }
                else if (variaveis.TotalParcialBranco200 == 0)
                {
                    variaveis.subTotal = (variaveis.TotalParcialAoLeite200 +variaveis.TotalParcialAoLeite500 + variaveis.TotalParcialBranco500) - variaveis.TotalParcialBranco200;
                }
                else if (variaveis.TotalParcialBranco500 == 0)
                {
                    variaveis.subTotal = (variaveis.TotalParcialAoLeite200 + variaveis.TotalParcialAoLeite500 + variaveis.TotalParcialBranco200) - variaveis.TotalParcialBranco500;
                }         
            txtSubTotal.Text = Convert.ToString(variaveis.subTotal);

                if (rdbDébito.Checked==true)
                {
                        double desconto = 0;
                        Console.WriteLine(variaveis.Total);
                        Console.WriteLine(variaveis.subTotal);
                        desconto = variaveis.subTotal * 0.03;

                        variaveis.Total = variaveis.subTotal - desconto;
                        txtTotalCompra.Text = Convert.ToString(variaveis.Total) + " ( A Vista)";
                }
                else if (rdbCrédito.Checked == true)
                {
                    Console.WriteLine(variaveis.subTotal);
                    txtTotalCompra.Text=Convert.ToString(variaveis.subTotal) + "  (1 parcela)";
                }
                else
                {
                    double acrecimo = 0;
                    Console.WriteLine(variaveis.Total);
                    Console.WriteLine(variaveis.subTotal);
                    acrecimo = variaveis.subTotal * 0.03;
                    variaveis.Total = variaveis.subTotal + acrecimo;
                    txtTotalCompra.Text = Convert.ToString(variaveis.Total) + "  (2 parcelas)";
                }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkAoLeite200_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAoLeite200.Checked == true)
            {
                txtQtdeAoLeite200.Enabled = true;
                txtQtdeAoLeite200.Focus();

            }
            else
            {
                txtQtdeAoLeite200.Text = "0";
                txtQtdeAoLeite200.Enabled = false;

            }
        }
        private void txtQtdeAoLeite200_TextChanged(object sender, EventArgs e)
        {
            if (txtQtdeAoLeite200.Text == "")
            {
                txtTotalParcialAoLeite200.Text = "0";
            }
            else
            {
                Console.WriteLine(variaveis.QtdeAoLeite200);
                Console.WriteLine(variaveis.TotalParcialAoLeite200);
                variaveis.QtdeAoLeite200 = Convert.ToDouble(txtQtdeAoLeite200.Text);
                variaveis.TotalParcialAoLeite200 = variaveis.QtdeAoLeite200 * 24.90;
                txtTotalParcialAoLeite200.Text = Convert.ToString(variaveis.TotalParcialAoLeite200);
            }
        }

        private void txtQtdeAoLeite500_TextChanged(object sender, EventArgs e)
        {
            if (txtQtdeAoLeite500.Text == "")
            {
                txtTotalParcialAoLeite500.Text = "0";
            }
            else
            {
                Console.WriteLine(variaveis.QtdeAoLeite500);
                Console.WriteLine(variaveis.TotalParcialAoLeite500);
                variaveis.QtdeAoLeite500 = Convert.ToDouble(txtQtdeAoLeite500.Text);
                variaveis.TotalParcialAoLeite500 = variaveis.QtdeAoLeite500 * 59.90;
                txtTotalParcialAoLeite500.Text = Convert.ToString(variaveis.TotalParcialAoLeite500);
            }
        
        }

        private void txtQtdeBranco200_TextChanged(object sender, EventArgs e)
        {
            if (txtQtdeBranco200.Text == "")
            {
                txtTotalParcialBranco200.Text = "0";
            }
            else
            {
                Console.WriteLine(variaveis.QtdeBranco200);
                Console.WriteLine(variaveis.TotalParcialBranco200);
                variaveis.QtdeBranco200 = Convert.ToDouble(txtQtdeBranco200.Text);
                variaveis.TotalParcialBranco200 = variaveis.QtdeBranco200 * 26.90;
                txtTotalParcialBranco200.Text = Convert.ToString(variaveis.TotalParcialBranco200);
            }
        }

        private void txtQtdeBranco500_TextChanged(object sender, EventArgs e)
        {
            if (txtQtdeBranco500.Text == "")
            {
                txtTotalParcialBranco500.Text = "0";
            }
            else
            {
                Console.WriteLine(variaveis.QtdeBranco500);
                Console.WriteLine(variaveis.TotalParcialBranco500);
                variaveis.QtdeBranco500 = Convert.ToDouble(txtQtdeBranco500.Text);
                variaveis.TotalParcialBranco500 = variaveis.QtdeBranco500 * 61.90;
                txtTotalParcialBranco500.Text = Convert.ToString(variaveis.TotalParcialBranco500);
            }
        }

        private void chkAoLeite500_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAoLeite500.Checked == true)
            {
                txtQtdeAoLeite500.Enabled = true;
                txtQtdeAoLeite500.Focus();
            }
            else
            {
                txtQtdeAoLeite500.Text = "0";
                txtQtdeAoLeite500.Enabled = false;

            }
        }

        private void chkBranco200_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBranco200.Checked == true)
            {
                txtQtdeBranco200.Enabled = true;
                txtQtdeBranco200.Focus();
            }
            else
            {

                txtQtdeBranco200.Text = "0";
                txtQtdeBranco200.Enabled = false;

            }
        }

        private void chkBranco500_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBranco500.Checked == true)
            {
                txtQtdeBranco500.Enabled = true;
                txtQtdeBranco500.Focus();
            }
            else
            {
                txtQtdeBranco500.Text = "0";
                txtQtdeBranco500.Enabled = false;

            }
        }

        private void txtQtdeAoLeite200_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoNumeros(e);
        }

        private void txtQtdeAoLeite500_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoNumeros(e);
        }

        private void txtQtdeBranco200_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoNumeros(e);
        }

        private void txtQtdeBranco500_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoNumeros(e);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (rdbDébito.Checked == true || rdbCrédito.Checked == true || rdbCrédito2X.Checked == true)
            {
                MessageBox.Show("Compra finalizada\n Obrigado e volte sempre ",":)");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chkAoLeite200.Checked = false;
            chkAoLeite500.Checked = false;
            chkBranco200.Checked = false;
            chkBranco500.Checked = false;

            txtQtdeAoLeite200.Text = "";
            txtQtdeAoLeite500.Text = "";
            txtQtdeBranco200.Text = "";
            txtQtdeBranco500.Text = "";
            txtSubTotal.Text = "";
            txtTotalCompra.Text = "";
            txtTotalParcialAoLeite200.Text = "";
            txtTotalParcialAoLeite500.Text = "";
            txtTotalParcialBranco200.Text = "";
            txtTotalParcialBranco500.Text = "";

            txtQtdeBranco200.Enabled = false;
            txtQtdeBranco500.Enabled = false;
            txtQtdeAoLeite200.Enabled = false;
            txtQtdeAoLeite500.Enabled = false;
        }

        private void txtTotalCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
