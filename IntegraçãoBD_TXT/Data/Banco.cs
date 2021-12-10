using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraçãoBD_TXT.Data
{
    class Banco
    {
        
        private string stringConexao = "Data Source = localhost; Initial Catalog = IntegraçãoBD_TXT; User ID = usuario; password=senha;language=Portuguese";
        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;

            }
            catch (Exception ex)
            {

                return null;
            }


        }
        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception)
            {

                return;
            }
        }

        public DataTable executarColsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
