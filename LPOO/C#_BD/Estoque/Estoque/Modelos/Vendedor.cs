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
    public partial class frmCadAltVendedor : Form
    {
        public frmCadAltVendedor()
        {
            InitializeComponent();
        }

        Verificação val = new Verificação();

        //---------BOTÕES---------------

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Pags pags = new Pags();
            pags.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTexts();
        }

        private void pctConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterPorNomevend(txtBuscarVendedor.Text);

            if (dt.Rows.Count != 0)
            {
                dgvVend.DataSource = dt;
            }
            else
            {
                DialogResult resp2 = MessageBox.Show("Este funcionario não existe, deseja Cadastrá-lo?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp2 == DialogResult.Yes)
                {
                    txtNome.Focus();
                    txtNome.Text = txtBuscarVendedor.Text;
                    txtBuscarVendedor.Text = "";
                }
                else
                {
                    limparTexts();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterTodosvend();

            if (dt.Rows.Count != 0)
            {
                dgvVend.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Não há registros na tabela");
            }
        }

        private void btnCadastrarVendedor_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" & txtEndereco.Text != "" & txtSalario.Text != "" & txtSenha.Text != "" & mtxtDataRegistro.Text != "" & mtxtTelefone.Text != "" & cmbNivelAcesso.Text != "")
            {
                Estoque_Vend vend = new Estoque_Vend();
                vend._nome_ven = txtNome.Text;
                vend._dt_registro = Convert.ToDateTime(mtxtDataRegistro.Text);
                vend._tell = Convert.ToInt32(mtxtTelefone.Text);
                vend._endereco = txtEndereco.Text;
                vend._senha = Convert.ToInt32(txtSenha.Text);
                vend._salario_fixo = Convert.ToDouble(txtSalario.Text);
                //vend._id_ven = Convert.ToInt32(lblid.Text);

                /*if (cmbNivelAcesso.Text == "Administrador")
                {
                    vend._id_vend_adm = 1;
                }
                else
                {
                    vend._id_vend_adm = null;
                }*/

                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja alterar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.inserirVendedor(vend);
                    if (vend._id_ven != 0)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTexts();
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            dgvVend.Enabled = true;
            btnCadastrarVendedor.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" & txtEndereco.Text != "" & txtSalario.Text != "" & txtSenha.Text != "" & mtxtDataRegistro.Text != "" & mtxtTelefone.Text != "" & cmbNivelAcesso.Text != "")
            {
                Estoque_Vend vend = new Estoque_Vend();
                vend._nome_ven = txtNome.Text;
                vend._dt_registro = Convert.ToDateTime(mtxtDataRegistro.Text);
                vend._tell = Convert.ToInt32(mtxtTelefone.Text);
                vend._endereco = txtEndereco.Text;
                vend._senha = Convert.ToInt32(txtSenha.Text);
                vend._salario_fixo = Convert.ToDouble(txtSalario.Text);
                vend._id_ven = Convert.ToInt32(lblid.Text);

                /*if (cmbNivelAcesso.Text == "Administrador")
                {
                    vend._id_vend_adm = 1;
                }
                else
                { 
                    vend._id_vend_adm = 2;
                }*/

                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja alterar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.AlterarVend(vend);
                    if (vend._id_ven != 0)
                        MessageBox.Show("Dados inseridos com sucesso");
                    limparTexts();
                    dgvVend.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnCadastrarVendedor.Enabled = true;
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

        private void dgvVend_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvVend.Rows[e.RowIndex].Cells["nome_ven"].Value.ToString();
            txtEndereco.Text = dgvVend.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
            mtxtDataRegistro.Text = dgvVend.Rows[e.RowIndex].Cells["dt_registro"].Value.ToString();
            mtxtTelefone.Text = dgvVend.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtSenha.Text = dgvVend.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txtSalario.Text = dgvVend.Rows[e.RowIndex].Cells["salario_fixo"].Value.ToString();
            lblid.Text = dgvVend.Rows[e.RowIndex].Cells["id_ven"].Value.ToString();
            cmbNivelAcesso.Text = dgvVend.Rows[e.RowIndex].Cells["id_vend_adm"].Value.ToString();
            dgvVend.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnCadastrarVendedor.Enabled = false;
        }
    

        //----------------OPERAÇÕES-----------

        private void limparTexts()
        {
            txtNome.Text = "";
            txtBuscarVendedor.Text = "";
            mtxtTelefone.Text = "";
            txtEndereco.Text = "";
            cmbNivelAcesso.Text = "";
            txtSalario.Text = "";
            mtxtDataRegistro.Text = "";
            txtBuscarVendedor.Focus();
            dgvVend.DataSource = "";
            txtSenha.Text = "";
            lblid.Text = "";
            cmbNivelAcesso.Text = "";
        }

        //-------------DESIGN-------------------------

        private void txtBuscarVendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarVendedor.Text == "")
            {
                pctConsultar.Enabled = false;
                pctConsultar.BackColor = Color.MediumOrchid;
            }
            else
            {
                pctConsultar.Enabled = true;
                pctConsultar.BackColor = Color.GhostWhite;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumerosV(e);
        }

        private void txtBuscarVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoLetra(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoLetra(e);
        }

        private void mtxtDataRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void mtxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }
    }
}
