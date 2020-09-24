using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Estoque
{
    class EstoqueDAO
    {

        private SqlConnection con;
        private SqlCommand cmd;

        // Inserir //

        public void inserirClie(Estoque_Clie clie)
        {
            con = new ConexaoBanco().obterConexao();

            try
            {
                String sql = "insert into cliente (cpf, nome, endereco, dt_nasci, situacao, telefone) values (@cpf, @nome, @endereco, @dt_nasci, @situacao, @telefone); select scope_identity(); ";
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@cpf", clie._cpf);
                cmd.Parameters.AddWithValue("@nome", clie._nome);
                cmd.Parameters.AddWithValue("@endereco", clie._endereco);
                cmd.Parameters.AddWithValue("@dt_nasci", clie._dt_nasci);
                cmd.Parameters.AddWithValue("@situacao", clie._situacao);
                cmd.Parameters.AddWithValue("@telefone", clie._telefone);

                object o = cmd.ExecuteScalar();

                /*if (o != null)
                    clie._cpf = Convert.ToInt32(o);*/
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro: " + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void inserirPedido(Estoque_Ped ped)
        {
            con = new ConexaoBanco().obterConexao();

            try
            {
                String sql = "insert into pedido (valor_total, dt_emis, cpf, id_ven_pedido) values (@valor_total, @dt_emis, @cpf, @id_ven_pedido); select scope_identity(); ";
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@valor_total", ped._val_total);
                cmd.Parameters.AddWithValue("@dt_emis", ped._dt_emis);
                cmd.Parameters.AddWithValue("@cpf", ped._cpf);
                cmd.Parameters.AddWithValue("@id_ven_pedido", ped._id_ven_pedido);

                object o = cmd.ExecuteScalar();

                if (o != null)
                    ped._cod_ped = Convert.ToInt32(o);
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro: " + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void inserirProd(Estoque_prod prod)
        {
            con = new ConexaoBanco().obterConexao();

            try
            {
                String sql = "insert into produto (nome, dt_fabric, dt_valid, preco, marca) values (@nome, @dt_fabric, @dt_valid, @preco, @marca); select scope_identity(); ";
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                
                cmd.Parameters.AddWithValue("@nome", prod._nome);
                cmd.Parameters.AddWithValue("@dt_fabric", prod._dt_fabric);
                cmd.Parameters.AddWithValue("@dt_valid", prod._dt_validade);
                cmd.Parameters.AddWithValue("@preco", prod._preco);
                cmd.Parameters.AddWithValue("@marca", prod._marca);

                object o = cmd.ExecuteScalar();

                
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro: " + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void inserirVendedor(Estoque_Vend vend)
        {
            con = new ConexaoBanco().obterConexao();

            try
            {
                String sql = "insert into vendedor (senha, nome_ven, endereco, salario_fixo, dt_registro, telefone) values(@senha, @nome_ven, @endereco, @salario_fixo, @dt_registro, @telefone)";
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                //cmd.Parameters.AddWithValue("@id_ven", vend._id_ven);
                cmd.Parameters.AddWithValue("@senha", vend._senha);
                cmd.Parameters.AddWithValue("@nome_ven", vend._nome_ven);
                cmd.Parameters.AddWithValue("@endereco", vend._endereco);
                cmd.Parameters.AddWithValue("@salario_fixo", vend._salario_fixo);
                cmd.Parameters.AddWithValue("@dt_registro", vend._dt_registro);
                cmd.Parameters.AddWithValue("@telefone", vend._tell);
                //cmd.Parameters.AddWithValue("@id_vend_adm", vend._id_vend_adm);

                object o = cmd.ExecuteScalar();

                if (o != null)
                    vend._id_ven = Convert.ToInt32(o);
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro: " + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Consulta //

        public DataTable ObterTodosProd()
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select id_prod [id_prod], nome [nome], dt_fabric [dt_fabric], dt_valid [dt_valid], preco [preço], marca [marca]");
                sql.AppendLine(" from produto");

                cmd = con.CreateCommand();
                //cmd.Parameters.AddWithValue("@id_produto", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao mostrar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterTodosEst()
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine("select p.id_prod [id_prod], p.nome [nome], e.qtd_prod [qtd_prod], p.marca [marca], p.preco [preço], p.dt_fabric [dt_fabric], p.dt_valid [dt_valid], e.situacao_estoque [situacao_estoque], e.area_armaz [area_armaz], e.endereco [endereco], p.id_estoq_prod [id_estoq_prod], e.id_estoq [id_estoq] ");
                sql.AppendLine(" from estoque e inner join produto p on e.id_estoq = p.id_estoq_prod");

                cmd = con.CreateCommand();
                //cmd.Parameters.AddWithValue("@id_produto", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao mostrar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        

        public DataTable ObterTodosvend()
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select id_ven [id_ven], senha [senha], nome_ven [nome_ven], endereco [endereco], salario_fixo [salario_fixo], dt_registro [dt_registro], telefone [telefone],  id_vend_adm [id_vend_adm]");
                sql.AppendLine(" from vendedor  ");

                cmd = con.CreateCommand();
                //cmd.Parameters.AddWithValue("@id_produto", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao mostrar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterTodosPed()
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select cod_pedido [cod_pedido], valor_total [valor_total], dt_emis [dt_emis], cpf [cpf], id_ven_pedido [id_ven_pedido]");
                sql.AppendLine(" from pedido");

                cmd = con.CreateCommand();
                //cmd.Parameters.AddWithValue("@id_produto", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao mostrar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterTodosClie()
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select cpf [cpf], nome [nome], endereco [endereco], dt_nasci [dt_nasci], situacao [situacao], telefone [telefone]");
                sql.AppendLine(" from cliente");

                cmd = con.CreateCommand();
                //cmd.Parameters.AddWithValue("@id_produto", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao mostrar o Registro");
            }
            finally
            {
                con.Close();
            }
        }


        //------------Por Nome--------------

        public DataTable ObterPorNomeProd(string termo)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select id_prod [id_prod], nome [nome], dt_fabric [dt_fabric], dt_valid [dt_valid], preco [preço], marca [marca]");
                sql.AppendLine(" from produto where nome like @nome + '%' ");

                cmd = con.CreateCommand();
                cmd.Parameters.AddWithValue("@nome", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterPorNomevend(string termo)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select id_ven [id_ven], senha [senha], nome_ven [nome_ven], endereco [endereco], salario_fixo [salario_fixo], dt_registro [dt_registro], telefone [telefone],  id_vend_adm [id_vend_adm]");
                sql.AppendLine(" from vendedor where nome_ven like @nome_ven + '%' ");

                cmd = con.CreateCommand();
                cmd.Parameters.AddWithValue("@nome_ven", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterPorNomePed(string termo)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select cod_pedido [cod_pedido], valor_total [valor_total], dt_emis [dt_emis], cpf [cpf], id_ven_pedido [id_ven_pedido]");
                sql.AppendLine(" from pedido where cod_pedido like @cod_pedido + '%' ");

                cmd = con.CreateCommand();
                cmd.Parameters.AddWithValue("@cod_pedido", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterPorNomeClie(string termo)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select cpf [cpf], nome [nome], endereco [endereco], dt_nasci [dt_nasci], situacao [situacao], telefone [telefone]");
                sql.AppendLine(" from cliente where cpf like @cpf + '%' ");

                cmd = con.CreateCommand();
                cmd.Parameters.AddWithValue("@cpf", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObterPorNomeEst(string termo)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine("select p.id_prod [id_prod], p.nome [nome], e.qtd_prod [qtd_prod], p.marca [marca], p.preco [preço], p.dt_fabric [dt_fabric], p.dt_valid [dt_valid], e.situacao_estoque [situacao_estoque], e.area_armaz [area_armaz], e.endereco [endereco], p.id_estoq_prod [id_estoq_prod], e.id_estoq [id_estoq] ");
                sql.AppendLine(" from estoque e inner join produto p on e.id_estoq = p.id_estoq_prod where nome like @nome + '%' ");

                cmd = con.CreateCommand();
                cmd.Parameters.AddWithValue("@nome", "%" + termo + "%");
                cmd.CommandText = sql.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        //-------------ALTERAR--------------

        public DataTable AlterarClie(Estoque_Clie clie)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE cliente SET nome = @nome, endereco = @endereco, dt_nasci = @dt_nasci, situacao = @situacao, telefone = @telefone");
                sql.AppendLine("WHERE cpf = @cpf ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql.ToString();

                cmd.Parameters.AddWithValue("@cpf", clie._cpf);
                cmd.Parameters.AddWithValue("@nome", clie._nome);
                cmd.Parameters.AddWithValue("@endereco", clie._endereco);
                cmd.Parameters.AddWithValue("@dt_nasci", clie._dt_nasci);
                cmd.Parameters.AddWithValue("@situacao", clie._situacao);
                cmd.Parameters.AddWithValue("@telefone", clie._telefone);
                
                //cmd.Parameters.AddWithValue("@nome", "%" + termo + "%");
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao alterar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable AlterarVend(Estoque_Vend vend)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE vendedor SET nome_ven = @nome_ven, senha = @senha, salario_fixo = @salario_fixo, endereco = @endereco, dt_registro = @dt_registro, telefone = @telefone");
                sql.AppendLine("WHERE id_ven = @id_ven ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql.ToString();

                cmd.Parameters.AddWithValue("@id_ven", vend._id_ven);
                cmd.Parameters.AddWithValue("@senha", vend._senha);
                cmd.Parameters.AddWithValue("@nome_ven", vend._nome_ven);
                cmd.Parameters.AddWithValue("@endereco", vend._endereco);
                cmd.Parameters.AddWithValue("@salario_fixo", vend._salario_fixo);
                cmd.Parameters.AddWithValue("@dt_registro", vend._dt_registro);
                cmd.Parameters.AddWithValue("@telefone", vend._tell);
               // cmd.Parameters.AddWithValue("@id_vend_adm", vend._id_vend_adm);
                

                //cmd.Parameters.AddWithValue("@nome", "%" + termo + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao alterar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable AlterarEst(Estoque_Est est)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {

                StringBuilder sql = new StringBuilder();
                
                sql.AppendLine("UPDATE estoque SET area_armaz = @area_armaz, qtd_prod = @qtd_prod, endereco = @endereco, situacao_estoque = @situacao_estoque");
                sql.AppendLine("WHERE id_estoq = @id_estoq ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql.ToString();

                cmd.Parameters.AddWithValue("@id_estoq", est._id_estoq);
                cmd.Parameters.AddWithValue("@area_armaz", est._area_armaz);
                cmd.Parameters.AddWithValue("@qtd_prod", est._qtd_prod);
                cmd.Parameters.AddWithValue("@endereco", est._endereco);
                cmd.Parameters.AddWithValue("@situacao_estoque", est._situacao_estoque);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                
                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao alterar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public void AlterarEstProd(Estoque_prod prod)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql2 = new StringBuilder();

                sql2.AppendLine("UPDATE produto SET  id_estoq_prod = @id_estoq_prod");
                sql2.AppendLine("WHERE id_prod = @id_prod ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql2.ToString();

                cmd.Parameters.AddWithValue("@id_prod", prod._id_prod);
                cmd.Parameters.AddWithValue("@id_estoq_prod", prod._id_estoq_prod);

                SqlDataAdapter da2 = new SqlDataAdapter(cmd);

                da2.Fill(dt);
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao alterar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        //--------Calcular------

        public DataTable CalcularFaturamento(Estoque_relatorio rel)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select sum(valor_total) as 'Faturamento' from pedido where dt_emis between @data1 and @data2 ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql.ToString();

                cmd.Parameters.AddWithValue("@data1", rel._data1);
                cmd.Parameters.AddWithValue("@data2", rel._data2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch(SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable CalcularProd(Estoque_relatorio rel)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select id_ven_pedido, sum(qtd_prod) as 'Faturamento' from pedido inner join item_pedido on fk_pedido = cod_pedido where dt_emis between @data1 and @data2 ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql.ToString();

                cmd.Parameters.AddWithValue("@data1", rel._data1);
                cmd.Parameters.AddWithValue("@data2", rel._data2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable CalcularVend(Estoque_relatorio rel)
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select sum(valor_total) as 'Faturamento' from pedido where dt_emis between @data1 and @data2 ");

                cmd = con.CreateCommand();
                cmd.CommandText = sql.ToString();

                cmd.Parameters.AddWithValue("@data1", rel._data1);
                cmd.Parameters.AddWithValue("@data2", rel._data2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao pesquisar o Registro");
            }
            finally
            {
                con.Close();
            }

        }
    }
}
