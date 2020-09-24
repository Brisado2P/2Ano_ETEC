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

namespace aula_edson1
{
    public partial class frmCadastro : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "server = localhost; user id = sa; password = 123456; persist security info = true; initial catalog = aula_edson";
        private string strSql = string.Empty;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            strSql = "insert into alimentos(id_alimento, alimento, quantidade, data_fabricacao, data_validade, preco) values (@id_alimento, @alimento, @quantidade, @data_fabricacao, @data_validade, @preco)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
          
            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = txtAlimento.Text;
            comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtQuantidade.Text;
            comando.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = txtDataDeFabricacao.Text;
            comando.Parameters.Add("@data_validade", SqlDbType.Date).Value = txtDataDeValidade.Text;
            comando.Parameters.Add("@preco", SqlDbType.Int).Value = txtPreco.Text;

            sqlCon.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastro efetuado com sucesso");

            sqlCon.Close();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "select * from alimentos where id_alimento = @id_alimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtId.Text;

            sqlCon.Open();

            SqlDataReader dr = comando.ExecuteReader();
            if(dr.HasRows == true)
            {
                dr.Read();
                txtAlimento.Text = Convert.ToString(dr["alimento"]);
                txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
                txtDataDeFabricacao.Text = Convert.ToString(dr["data_fabricacao"]);
                txtDataDeValidade.Text = Convert.ToString(dr["data_validade"]);
                txtPreco.Text = Convert.ToString(dr["preco"]);

                txtId.Enabled = false;

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro não existe");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAlimento.Text = ""; 
            txtQuantidade.Text = "";
            txtDataDeFabricacao.Text = "";
            txtDataDeValidade.Text = "";
            txtPreco.Text = "";

            txtId.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE alimentos SET alimento = @alimento, quantidade = @quantidade, data_fabricacao = @data_fabricacao, data_validade = @data_validade, preco = @preco";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = txtAlimento.Text;
            comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtQuantidade.Text;
            comando.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = txtDataDeFabricacao.Text;
            comando.Parameters.Add("@data_validade", SqlDbType.Date).Value = txtDataDeValidade.Text;
            comando.Parameters.Add("@preco", SqlDbType.Int).Value = txtPreco.Text;

            sqlCon.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Alteração efetuada com sucesso");

            sqlCon.Close();

            // strSql = "update alimentos"
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE alimentos WHERE id_alimento = @id_alimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtId.Text;
 
            sqlCon.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Deletado com sucesso");

            sqlCon.Close();

            txtId.Text = "";
            txtAlimento.Text = ""; 
            txtQuantidade.Text = "";
            txtDataDeFabricacao.Text = "";
            txtDataDeValidade.Text = "";
            txtPreco.Text = "";

            txtId.Enabled = true;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
    
}
