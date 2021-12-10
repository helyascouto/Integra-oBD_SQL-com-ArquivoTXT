using IntegraçãoBD_TXT.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraçãoBD_TXT.Model
{
    class Aluno : Pessoa

    {
        public Aluno()
        {
        }

        public Aluno(int fk_Pessoa, int matricula, int fk_curso)
        {
            this.fk_Pessoa = fk_Pessoa;
            this.matricula = matricula;
            this.fk_curso = fk_curso;
        }

        public int fk_Pessoa { get; set; }
        public int matricula { get; set; }
        public int fk_curso { get; set; }

        public bool gravarAluno()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = " insert into alunos values (@fk_pessoa, @matricula, @fk_curso)";
            command.Parameters.Add("@fk_pessoa", SqlDbType.Int);
            command.Parameters.Add("@matricula", SqlDbType.Int);
            command.Parameters.Add("@fk_curso", SqlDbType.Int);
            command.Parameters[0].Value = fk_Pessoa;
            command.Parameters[1].Value = matricula;
            command.Parameters[2].Value = fk_curso;
           

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
        public void consultarAluno(DataGridView dataGridView)
        {
            try
            {
                Banco db = new Banco();
                string sql = "select * from alunos";

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
