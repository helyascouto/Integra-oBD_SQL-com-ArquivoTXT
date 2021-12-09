using System;
using System.Collections.Generic;
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


    }
}
