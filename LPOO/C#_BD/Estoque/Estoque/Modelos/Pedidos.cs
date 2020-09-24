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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        Verificação val = new Verificação();
        //---------BOTÕES---------------

        private void pctConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterPorNomePed(txtBuscarPedido.Text);

            if (dt.Rows.Count != 0)
            {
                dgvPedidos.DataSource = dt;

                //-----------DESIGN------------
                dgvPedidos.Columns["cod_pedido"].HeaderText = "Código do Pedido";
                dgvPedidos.Columns["valor_total"].HeaderText = "Valor Total";
                dgvPedidos.Columns["dt_emis"].HeaderText = "Data de Emissão";
                dgvPedidos.Columns["cpf"].HeaderText = "CPF do Cliente";
                dgvPedidos.Columns["id_ven_pedido"].HeaderText = "ID do Vendedor";
            }
            else
            {
                DialogResult resp2 = MessageBox.Show("Este registro não existe, deseja Cadastrá-lo?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp2 == DialogResult.Yes)
                {
                    mtxtCPFCli.Focus();
                }
                else
                {
                    limparTexts();
                }
            }
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if(txtIDVendedor.Text != "" & txtValorTotal.Text != "" & mtxtCPFCli.Text != "" & mtxtDataEmissao.Text != "")
            {           
                Estoque_Ped ped = new Estoque_Ped();
                ped._cpf = Convert.ToDouble(mtxtCPFCli.Text);
                ped._dt_emis = Convert.ToDateTime(mtxtDataEmissao.Text);
                ped._val_total = Convert.ToDouble(txtValorTotal.Text);
                ped._id_ven_pedido = Convert.ToInt32(txtIDVendedor.Text);

                EstoqueDAO DAO = new EstoqueDAO();

                var result = MessageBox.Show("Deseja cadastrar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.inserirPedido(ped);
                    if (ped._cod_ped != 0)
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new EstoqueDAO().ObterTodosPed();

            if (dt.Rows.Count != 0)
            {
                dgvPedidos.DataSource = dt;

                //-----------DESIGN------------
                dgvPedidos.Columns["cod_pedido"].HeaderText = "Código do Pedido";
                dgvPedidos.Columns["valor_total"].HeaderText = "Valor Total";
                dgvPedidos.Columns["dt_emis"].HeaderText = "Data de Emissão";
                dgvPedidos.Columns["cpf"].HeaderText = "CPF do Cliente";
                dgvPedidos.Columns["id_ven_pedido"].HeaderText = "ID do Vendedor";
            }
            else
            {
                MessageBox.Show("Não há registros na tabela");
            }
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTexts();
        }
        //----------------OPERAÇÕES-----------

        private void limparTexts()
        {
            mtxtCPFCli.Text = "";
            txtValorTotal.Text = "";
            mtxtDataEmissao.Text = "";
            lblVendedor.Text = "";
            txtBuscarPedido.Text = "";
            dgvPedidos.DataSource = "";
        }

        //-------------DESIGN-------------------------

        private void txtBuscarPedido_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPedido.Text == "")
            {
                pctConsultar.Enabled = false;
                pctConsultar.BackColor = Color.DarkSlateBlue;
            }
            else
            {
                pctConsultar.Enabled = true;
                pctConsultar.BackColor = Color.GhostWhite;
            }
        }

        private void txtBuscarPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtIDVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumerosV(e);
        }
    }
}
