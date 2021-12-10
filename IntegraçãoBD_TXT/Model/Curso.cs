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
    class Curso
    {
        public Curso()
        {
        }

        public Curso(string digito ,string matricula, int idCurso, string nomeCurso)
        {
            IdCurso = idCurso;
            this.nomeCurso = nomeCurso;
            this.matricula = matricula;
            this.digito = digito;
        }

        public int IdCurso { get; set; }
        public string nomeCurso { get; set; }
        public string matricula { get; set; }
        public string digito { get; set; }

        public bool gravarCurso()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = " insert into curso values (@nomeCurso, @matricula, @digito)";
            command.Parameters.Add("@nomeCurso", SqlDbType.VarChar);
            command.Parameters.Add("@matricula", SqlDbType.VarChar);
            command.Parameters.Add("@digito", SqlDbType.VarChar);
            command.Parameters[0].Value = nomeCurso;
            command.Parameters[1].Value = matricula;
            command.Parameters[2].Value = digito;

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

        private Curso RetornaCursos(int id)
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("SELECT * from curso", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.IdCurso = reader.GetInt32(0);
                        nomeCurso = reader.GetString(1);
                        matricula = reader.GetString(2);
                        digito = reader.GetString(3);

                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
        public void consultarCurso(DataGridView dataGridView)
        {
            try
            {
                Banco db = new Banco();
                string sql = "select * from curso";

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
