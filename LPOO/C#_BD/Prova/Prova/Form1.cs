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

namespace Prova
{
    public partial class frmFun : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "server = localhost; user = sa; password = 123456; persist security info = true; initial catalog = Prova";
        private string strSql = string.Empty;

        Verifica ver = new Verifica();

        public frmFun()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "Select * from registro where id = @id";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor insira o ID!", "!!!Alerta!!!");
            }
            else
            {
                comando.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    dr.Read();
                    txtNome.Text = Convert.ToString(dr["nome"]);
                    txtCargo.Text = Convert.ToString(dr["cargo"]);

                    configCon();
                }
                else
                {
                    MessageBox.Show("Registro não existe");


                }
                sqlCon.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "Delete registro where id = @id";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;

            sqlCon.Open();

            comando.ExecuteNonQuery();
            MessageBox.Show("Deletado com sucesso");

            sqlCon.Close();
            limparTxt();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTxt();
        }


        // Comandos //

        private void limparTxt()
        {
            txtCargo.Text = "";
            txtId.Text = "";
            txtNome.Text = "";
            txtId.Enabled = true;
            btnConsultar.Enabled = true;
            btnExcluir.Enabled = false;

            txtId.Focus();
        }

        private void configCon()
        {
            txtId.Enabled = false;
            btnExcluir.Enabled = true;
            btnConsultar.Enabled = false;
        }
        private void configConNao()
        {
            limparTxt();
            txtId.Focus();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ver.Sonumeros(e);
        }

        private void frmFun_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }
    }
}
