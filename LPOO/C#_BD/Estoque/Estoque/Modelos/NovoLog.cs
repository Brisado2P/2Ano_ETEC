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
    public partial class frmNovoLog : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "server = localhost; user id = sa; password = 123456; persist security info = true; initial catalog = Estoque";
        private string strSql = string.Empty;

        public frmNovoLog()
        {
            InitializeComponent();
        }
        //---------BOTÕES---------------

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmBemVindo Inicio = new frmBemVindo();
            Inicio.Show();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            strSql = "select * from vendedor where nome_ven = @nome_ven and senha = @senha and  id_vend_adm = 1";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome_ven", SqlDbType.VarChar).Value = txtLogAdm.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaAdm.Text;

            sqlCon.Open();

            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                Close();
                frmCadAltVendedor vend = new frmCadAltVendedor();
                vend.Show();
            }
            else
            {
                MessageBox.Show("Usuario e/ou Senha Incorreto", "AVISO");
            }
            
        }

        private void txtSenhaAdm_TextChanged(object sender, EventArgs e)
        {
            if (txtLogAdm.Text == "" && txtSenhaAdm.Text == "")
            {
                btnVerificar.Enabled = false;
            }
            else
            {
                btnVerificar.Enabled = true;
            }
        }     
    }
}
