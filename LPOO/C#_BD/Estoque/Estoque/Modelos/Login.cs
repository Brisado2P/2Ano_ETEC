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
    public partial class frmBemVindo : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "server = localhost; user id = sa; password = 123456; persist security info = true; initial catalog = Estoque";
        private string strSql = string.Empty;

        Verificação val = new Verificação();

        public frmBemVindo()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            strSql = "select * from vendedor where nome_ven = @nome_ven and senha = @senha";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome_ven", SqlDbType.VarChar).Value = txtLogin.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

            sqlCon.Open();

            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                this.Hide();
                Pags pags = new Pags();
                pags.Show();
            }
            else
            {
                MessageBox.Show("Usuario e/ou Senha Incorreto", "AVISO");
            }      
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoliciteAgora_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNovoLog SL = new frmNovoLog();
            SL.Show();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
           if(txtLogin.Text == "Nome")
            {
                txtLogin.Text = "";
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Nome";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "senha")
            {
                txtSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "senha";
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoNumeros(e);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoLetra(e);
        }

        private void frmBemVindo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
