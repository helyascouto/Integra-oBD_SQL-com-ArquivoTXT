using IntegraçãoBD_TXT.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegraçãoBD_TXT.Model
{
    public class Pessoa
    {
       

        public int idPessoa { get; set; }
        public string digito { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public Pessoa pessoa { get; }

        public bool gravarPessoa()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = " insert into pessoas values (@digito, @nome, @cidade, @RG, @CPF )";
            command.Parameters.Add("@digito", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@RG", SqlDbType.VarChar);
            command.Parameters.Add("@CPF", SqlDbType.VarChar);
            command.Parameters[0].Value = digito;
            command.Parameters[1].Value = nome;
            command.Parameters[2].Value = telefone;
            command.Parameters[3].Value = RG;
            command.Parameters[4].Value = CPF;


            try
            {
                command.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return false;
            }

            finally
            {
                bd.fecharConexao();
            }

        }

        public int RetornaPessoa(int id)
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlCommand command = new SqlCommand("SELECT * from pessoas", cn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetInt32(0) == id)
                {
                    this.idPessoa = reader.GetInt32(0);
                   
                }
            }
            return this.idPessoa;
            bd.fecharConexao();

           


        }

        public void consultarPessoas(DataGridView dataGridView)
        {
            try
            {
                Banco db = new Banco();
                string sql = "select * from pessoas";

                DataTable dt = new DataTable();
                dt = db.executarColsultaGenerica(sql);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
