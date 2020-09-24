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
    public partial class frmVendedor_com : Form
    {
        public frmVendedor_com()
        {
            InitializeComponent();
        }

        private void llblCadAltVendedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult var = MessageBox.Show("Para Cadastrar você precisa acessar o sistema como Administrador. Deseja logar como administrador?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (var == DialogResult.Yes)
            {
                this.Close();
                frmNovoLog nlog = new frmNovoLog();
                nlog.Show();
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
                    DialogResult var = MessageBox.Show("Para Cadastrar você precisa acessar o sistema como Administrador. Deseja logar como administrador?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (var == DialogResult.Yes)
                    {
                        this.Close();
                        frmNovoLog nlog = new frmNovoLog();
                        nlog.Show();
                    }
                }
                else
                {
                    limparTexts();
                }
            }
        }
        //----------------OPERAÇÕES-----------

        private void limparTexts()
        {
            txtBuscarVendedor.Focus();
            dgvVend.DataSource = "";
            txtBuscarVendedor.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Pags pag = new Pags();
            pag.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscarVendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarVendedor.Text == "")
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
    }
}

