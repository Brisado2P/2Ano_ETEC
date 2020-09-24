using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{

    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        Verificação val = new Verificação();
        int id;

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
            DataTable dt = new EstoqueDAO().ObterPorNomeClie(txtBuscarClientes.Text);

            if (dt.Rows.Count != 0)
            {
                dgvClie.DataSource = dt;

                //-----------DESIGN------------
                dgvClie.Columns["cpf"].HeaderText = "CPF do Cliente";
                dgvClie.Columns["nome"].HeaderText = "Nome";
                dgvClie.Columns["endereco"].HeaderText = "Endereço";
                dgvClie.Columns["dt_nasci"].HeaderText = "Data de Nascimento";
                dgvClie.Columns["situacao"].HeaderText = "Situação";
                dgvClie.Columns["telefone"].HeaderText = "Telefone";
            }
            else
            {
                DialogResult resp2 = MessageBox.Show("Este registro não existe, deseja Cadastrá-lo?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp2 == DialogResult.Yes)
                {
                    txtNome.Focus();
                }
                else
                {
                    limparTexts();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterTodosClie();

            if (dt.Rows.Count != 0)
            {
                dgvClie.DataSource = dt;

                //-----------DESIGN------------
                dgvClie.Columns["cpf"].HeaderText = "CPF do Cliente";
                dgvClie.Columns["nome"].HeaderText = "Nome";
                dgvClie.Columns["endereco"].HeaderText = "Endereço";
                dgvClie.Columns["dt_nasci"].HeaderText = "Data de Nascimento";
                dgvClie.Columns["situacao"].HeaderText = "Situação";
                dgvClie.Columns["telefone"].HeaderText = "Telefone";
            }
            else
            {
                MessageBox.Show("Não há registros na tabela");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" & txtNome.Text != "" & mtxtCPF.Text != "" & mtxtDataNasc.Text != "" & mtxtTelefone.Text != "" & cmbSituacao.Text != "")
            {

                Estoque_Clie clie = new Estoque_Clie();
                clie._nome = txtNome.Text;
                clie._dt_nasci = Convert.ToDateTime(mtxtDataNasc.Text);
                clie._telefone = Convert.ToInt32(mtxtTelefone.Text);
                clie._endereco = txtEndereco.Text;
                clie._cpf = Convert.ToDouble(mtxtCPF.Text);

                if (cmbSituacao.Text == "Ativo")
                {
                    id = 1;
                    clie._situacao = id;
                }
                else
                {
                    id = 0;
                    clie._situacao = id;
                }

                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja cadastrar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.inserirClie(clie);
                    if (clie._cpf != 0)
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
                MessageBox.Show("Preencha todos os campos.", "Alerta");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" & txtNome.Text != "" & mtxtCPF.Text != "" & mtxtDataNasc.Text != "" & mtxtTelefone.Text != "" & cmbSituacao.Text != "")
            {
                Estoque_Clie clie = new Estoque_Clie();
                clie._nome = txtNome.Text;
                clie._dt_nasci = Convert.ToDateTime(mtxtDataNasc.Text);
                clie._telefone = Convert.ToInt32(mtxtTelefone.Text);
                clie._endereco = txtEndereco.Text;
                clie._cpf = Convert.ToDouble(mtxtCPF.Text);

                if (cmbSituacao.Text == "Ativo")
                {
                    id = 1;
                    clie._situacao = id;
                }
                else
                {
                    id = 0;
                    clie._situacao = id;
                }

                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja alterar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.AlterarClie(clie);
                    if (clie._cpf != 0)
                        MessageBox.Show("Dados inseridos com sucesso");
                    limparTexts();
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    dgvClie.Enabled = true;
                }
                else
                {
                    limparTexts();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Alerta");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTexts();
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            dgvClie.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            mtxtCPF.Clear();
            mtxtDataNasc.Clear();
            mtxtTelefone.Clear();
            cmbSituacao.Text = "";
        }

        private void dgvClie_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvClie.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEndereco.Text = dgvClie.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
            mtxtDataNasc.Text = dgvClie.Rows[e.RowIndex].Cells["dt_nasci"].Value.ToString();
            cmbSituacao.Text = dgvClie.Rows[e.RowIndex].Cells["situacao"].Value.ToString();
            mtxtTelefone.Text = dgvClie.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            mtxtCPF.Text = dgvClie.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            dgvClie.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //----------------OPERAÇÕES-----------

        private void limparTexts()
        {
            cmbSituacao.Text = "";
            mtxtCPF.Text = "";
            txtNome.Text = "";
            mtxtDataNasc.Text = "";
            mtxtTelefone.Text = "";
            txtEndereco.Text = "";
            txtBuscarClientes.Text = "";
            txtBuscarClientes.Focus();
            dgvClie.DataSource = "";
        }

        //-------------DESIGN-------------------------

        private void cmbSituacao_TextChanged(object sender, EventArgs e)
        {
            cmbSituacao.Text = "";
        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarClientes.Text == "")
            {
                pctConsultar.Enabled = false;
                pctConsultar.BackColor = Color.Indigo;
            }
            else
            {
                pctConsultar.Enabled = true;
                pctConsultar.BackColor = Color.GhostWhite;
            }
        }

        private void pctConsultar_MouseHover(object sender, EventArgs e)
        {
            pctConsultar.BackColor = Color.Lavender;
        }

        private void pctConsultar_MouseLeave(object sender, EventArgs e)
        {
            pctConsultar.BackColor = Color.GhostWhite;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoLetra(e);
        }

        private void txtBuscarClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }
    }
}
