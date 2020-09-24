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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        Verificação val = new Verificação();

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

        private void pctConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterPorNomeEst(txtNomeBuscaEst.Text);

            dgvEst.Columns["nome"].HeaderText = "Nome";

            if (dt.Rows.Count != 0)
            {
                dgvEst.DataSource = dt;

                //-----------DESIGN------------
                dgvEst.Columns["nome"].HeaderText = "Nome";
                dgvEst.Columns["marca"].HeaderText = "Marca";
                dgvEst.Columns["qtd_prod"].HeaderText = "Quantidade";
                dgvEst.Columns["preço"].HeaderText = "Preço";
                dgvEst.Columns["dt_fabric"].HeaderText = "Data Fabricação";
                dgvEst.Columns["dt_valid"].HeaderText = "Data Validade";
                dgvEst.Columns["situacao_estoque"].HeaderText = "Situação";
                dgvEst.Columns["area_armaz"].HeaderText = "Área de Armazenamento";
                dgvEst.Columns["endereco"].HeaderText = "Endereço";
                dgvEst.Columns["id_estoq_prod"].HeaderText = "Está no Estoque";
            }
            else
            {
                MessageBox.Show("Sem registros no banco.");

                limparTexts();
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterTodosEst();

            txtNomeBuscaEst.Text = "";

            if (dt.Rows.Count != 0)
            {
                dgvEst.DataSource = dt;

                //-----------DESIGN------------
                dgvEst.Columns["nome"].HeaderText = "Nome";
                dgvEst.Columns["marca"].HeaderText = "Marca";
                dgvEst.Columns["qtd_prod"].HeaderText = "Quantidade";
                dgvEst.Columns["preço"].HeaderText = "Preço";
                dgvEst.Columns["dt_fabric"].HeaderText = "Data Fabricação";
                dgvEst.Columns["dt_valid"].HeaderText = "Data Validade";
                dgvEst.Columns["situacao_estoque"].HeaderText = "Situação";
                dgvEst.Columns["area_armaz"].HeaderText = "Área de Armazenamento";
                dgvEst.Columns["endereco"].HeaderText = "Endereço";
                dgvEst.Columns["id_estoq_prod"].HeaderText = "Está no Estoque";
            }
            else
            {
                MessageBox.Show("Não há registros na tabela");
            }
        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" & txtNomeProduto.Text != "" & txtQuantidade.Text != "" & txtSituacao.Text != "" & txtIdEstoqueProd.Text != "" & txtEndereco.Text != "")
            {
                Estoque_Est est = new Estoque_Est();

                est._area_armaz = txtLocalArmazenamento.Text;
                est._qtd_prod = Convert.ToInt32(txtQuantidade.Text);
                est._endereco = txtEndereco.Text;
                est._situacao_estoque = txtSituacao.Text;
                est._id_estoq = Convert.ToInt32(txtIDEST.Text);

                Estoque_prod prod = new Estoque_prod();

                prod._id_estoq_prod = Convert.ToInt32(txtIdEstoqueProd.Text);
                prod._id_prod = Convert.ToInt32(txtIDProd.Text);
           
                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja alterar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.AlterarEst(est);
                    DAO.AlterarEstProd(prod);

                    MessageBox.Show("Dados inseridos com sucesso");
                    limparTexts();
                    btnMostrarTodos.Enabled = true;
                    travarTxt();
                    btnCancelar.Enabled = false;
                    btnAlterarEstoque.Enabled = false;
                    txtNomeBuscaEst.Enabled = true;
                    txtIdEstoqueProd.Enabled = false;
                    dgvEst.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Alerta");
            }
        }

        private void dgvEst_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarEst();
            txtNomeProduto.Text = dgvEst.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dgvEst.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtQuantidade.Text = dgvEst.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLocalArmazenamento.Text = dgvEst.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtSituacao.Text = dgvEst.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtIDProd.Text = dgvEst.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdEstoqueProd.Text = dgvEst.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtIDEST.Text = dgvEst.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTexts();
            dgvEst.Enabled = true;
            travarTxt();
            btnMostrarTodos.Enabled = true;
            btnAlterarEstoque.Enabled = false;
            btnCancelar.Enabled = false;
            txtNomeBuscaEst.Enabled = true;
            txtIdEstoqueProd.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTexts();
            txtNomeBuscaEst.Enabled = true;
            btnMostrarTodos.Enabled = true;
        }

        //----------------OPERAÇÕES-----------

        private void travarTxt()
        {
            txtQuantidade.Enabled = false;
            txtSituacao.Enabled = false;
            txtEndereco.Enabled = false;
            txtLocalArmazenamento.Enabled = false;
            txtNomeBuscaEst.Enabled = false;          
        }

        private void limparTexts()
        {
            txtIDEST.Text = "";
            txtIdEstoqueProd.Text = "";
            txtQuantidade.Text = "";
            txtSituacao.Text = "";
            txtEndereco.Text = "";
            txtLocalArmazenamento.Text = "";
            txtNomeBuscaEst.Focus();
            dgvEst.DataSource = "";
            txtNomeBuscaEst.Text = "";
            txtNomeProduto.Text = "";
        }

        private void AlterarEst()
        {
            txtIdEstoqueProd.Enabled = true;
            txtNomeBuscaEst.Enabled = false;
            btnMostrarTodos.Enabled = false;
            btnAlterarEstoque.Enabled = true;   
            btnCancelar.Enabled = true;
            txtQuantidade.Enabled = true;
            txtSituacao.Enabled = true;
            txtEndereco.Enabled = true;
            txtLocalArmazenamento.Enabled = true;          
            dgvEst.Enabled = false;
           
        } 

        //-------------DESIGN-------------------------

        private void txtNomeBuscaEst_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeBuscaEst.Text == "")
            {
                pctConsultar.Enabled = false;
                pctConsultar.BackColor = Color.DarkOrchid;
            }
            else
            {
                pctConsultar.Enabled = true;
                pctConsultar.BackColor = Color.GhostWhite;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtIdEstoqueProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }
    }
}
