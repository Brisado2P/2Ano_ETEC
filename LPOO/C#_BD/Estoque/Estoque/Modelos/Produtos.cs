using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private EstoqueDAO dao = new EstoqueDAO();

        Verificação val = new Verificação();
        //---------BOTÕES---------------

        private void pctConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterPorNomeProd(txtNomeProdBusca.Text);

            if (dt.Rows.Count != 0)
            {
                dgvProd.DataSource = dt;

                //-----------DESIGN------------
                dgvProd.Columns["id_prod"].HeaderText = "ID do Produto";
                dgvProd.Columns["nome"].HeaderText = "Nome";
                dgvProd.Columns["dt_fabric"].HeaderText = "Data Fabricação";
                dgvProd.Columns["dt_valid"].HeaderText = "Data Validade";
                dgvProd.Columns["preço"].HeaderText = "Preço";
                dgvProd.Columns["marca"].HeaderText = "Marca";

            }
            else
            {
                DialogResult resp2 = MessageBox.Show("Este registro não existe, deseja Cadastrá-lo?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp2 == DialogResult.Yes)
                {
                    txtNome.Focus();
                    txtNome.Text = txtNomeProdBusca.Text;
                    txtNomeProdBusca.Text = "";
                }
                else
                {
                    limparTexts();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterTodosProd();

            if (dt.Rows.Count != 0)
            {
                dgvProd.DataSource = dt;

                //-----------DESIGN------------
                dgvProd.Columns["id_prod"].HeaderText = "ID do Produto";
                dgvProd.Columns["nome"].HeaderText = "Nome";
                dgvProd.Columns["dt_fabric"].HeaderText = "Data Fabricação";
                dgvProd.Columns["dt_valid"].HeaderText = "Data Validade";
                dgvProd.Columns["preço"].HeaderText = "Preço";
                dgvProd.Columns["marca"].HeaderText = "Marca";
            }
            else
            {
                MessageBox.Show("Não há registros na tabela");
            }
        }

        private void btnCadastrarNovoProd_Click(object sender, EventArgs e)
        {
            Estoque_prod prod = new Estoque_prod();
            if (txtNome.Text != "" & txtMarca.Text != "" & txtPreco.Text != "" & mtxtDt_Fabri.Text != "" & mtxtValidade.Text != "")
            {
                prod._nome = txtNome.Text;
                prod._dt_fabric = Convert.ToDateTime(mtxtDt_Fabri.Text);
                prod._dt_validade = Convert.ToDateTime(mtxtValidade.Text);
                prod._preco = Convert.ToDouble(txtPreco.Text);
                prod._marca = txtMarca.Text;

                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja cadastrar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.inserirProd(prod);
                    if (prod._id_prod != 0)
                        MessageBox.Show("Dados inseridos com sucesso");
                    limparTexts();
                }
                else
                {
                    limparTexts();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta");
            }
        }

         private void btnLimpar_Click(object sender, EventArgs e)
         {
                limparTexts();
         }

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

         //----------------OPERAÇÕES-----------

         private void limparTexts()
         {
            txtNome.Text = "";
            mtxtDt_Fabri.Text = "";
            mtxtValidade.Text = "";
            txtPreco.Text = "";
            txtMarca.Text = "";
            txtNome.Focus();
            dgvProd.DataSource = "";
            txtNomeProdBusca.Text = "";
         }

         //-------------DESIGN-------------------------

         private void txtNomeProdBusca_TextChanged(object sender, EventArgs e)
         {
            if (txtNomeProdBusca.Text == "")
            {
               pctConsultar.Enabled = false;
               pctConsultar.BackColor = Color.DarkMagenta;
            }
            else
            {
               pctConsultar.Enabled = true;
               pctConsultar.BackColor = Color.GhostWhite;
            }
         }

         private void pctConsultar_MouseHover_1(object sender, EventArgs e)
         {
             pctConsultar.BackColor = Color.Lavender;
         }

         private void pctConsultar_MouseLeave_1(object sender, EventArgs e)
         {
             pctConsultar.BackColor = Color.GhostWhite;
         }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumerosV(e);
        }
    }
}

