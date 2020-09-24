using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Estoque
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        //---------BOTÕES---------------

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Pags pags = new Pags();
            pags.Show();
        }

        private void btnLimparFatDatas_Click(object sender, EventArgs e)
        {
            limparTexts();
        }

        private void btnLimparQuantVendedorVend_Click(object sender, EventArgs e)
        {
            limparTexts();
            btnCalcularVendaVendedor.Enabled = false;
        }

        private void btnLimparQuantProdVend_Click(object sender, EventArgs e)
        {
            limparTexts();
            btnCalcularVendaVendedor.Enabled = false;
        }

        private void btnCalcularFaturamento_Click(object sender, EventArgs e)
        {
            if (mtxtDataInicialFaturamento.Text != "" || mtxtDataFinalFaturamento.Text != "")
            {
                Estoque_relatorio rel = new Estoque_relatorio();

                rel._data2 = Convert.ToDateTime(mtxtDataFinalFaturamento.Text);
                rel._data1 = Convert.ToDateTime(mtxtDataInicialFaturamento.Text);

                DataTable dt = new EstoqueDAO().CalcularFaturamento(rel);


                if (dt.Rows.Count != 0)
                {
                    dgvResultadoFaturamento.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Não há faturamento.");
                    limparTexts();

                }
            }
            else
            {
                MessageBox.Show("Prencha as datas para calcular o faturamento.");
            }
        }

        private void btnCalcularVendaVendedor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcularQuantProd_Click(object sender, EventArgs e)
        {
            if (mtxtDataInicialFaturamento.Text != "" || mtxtDataFinalFaturamento.Text != "")
            {
                Estoque_relatorio rel = new Estoque_relatorio();

                rel._data2 = Convert.ToDateTime(mtxtDataFinalQuantProd.Text);
                rel._data1 = Convert.ToDateTime(mtxtDataInicialQuantProd.Text);

                DataTable dt = new EstoqueDAO().CalcularProd(rel);

                if (dt.Rows.Count != 0)
                {
                    dgvQuantProdVend.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Não há faturamento.");
                    limparTexts();
                }
            }
            else
            {
                MessageBox.Show("Prencha as datas para calcular.");
            }
        }

        //----------------OPERAÇÕES-----------

        private void limparTexts()
        {
            dgvResultadoFaturamento.Text = "";
            dgvQuantVend.Text = "";
            dgvQuantProdVend.Text = "";
            cmbMeses.Text = "";
            mtxtDataFinalFaturamento.Text = "";
            mtxtDataFinalQuantProd.Text = "";
            mtxtDataInicialFaturamento.Text = "";
            mtxtDataInicialQuantProd.Text = "";
        }

        //-------------DESIGN-------------------------

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            cmbMeses.Text = "";
        }

        private void mtxtDataFinalFaturamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxtDataFinalFaturamento.Text == "" && mtxtDataInicialFaturamento.Text == "")
            {
                btnCalcularFaturamento.Enabled = false;
            }
            else
            {
                btnCalcularFaturamento.Enabled = true;
            }
        }

        private void mtxtDataFinalQuantProd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxtDataInicialQuantProd.Text == "" && mtxtDataFinalQuantProd.Text == "")
            {
                btnCalcularQuantProd.Enabled = false;
            }
            else
            {
                btnCalcularQuantProd.Enabled = true;
            }
        }
    }
}
