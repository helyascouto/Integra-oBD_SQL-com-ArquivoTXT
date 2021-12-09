using System;
using System.Collections.Generic;
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

        public Aluno(int idAluno, int matricula, Curso curso)
        {
            this.idAluno = idAluno;
            this.matricula = matricula;
            this.curso = curso;
        }

        public int idAluno { get; set; }
        public int matricula { get; set; }
        public Curso curso { get; set; }



    }
}
