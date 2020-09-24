using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Estoque
{
    class ConexaoBanco
    {
        private SqlConnection con;

        public SqlConnection obterConexao()
        {
            try
            {
                con = new SqlConnection("Data Source= localhost; initial catalog = Estoque; integrated security = True; user id = sa; password = 123456");
                con.Open();
                return con;
            }
            catch (SqlException erro)
            {
                throw new NullReferenceException("Banco de dados não Encontrado! " + erro.Message);
            }
        }
    }
}
