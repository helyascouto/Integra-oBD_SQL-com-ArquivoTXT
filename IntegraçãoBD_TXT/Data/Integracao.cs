using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraçãoBD_TXT.Model.Data
{
    internal class Integracao

    {
        public Curso curso = new Curso();
        public Aluno aluno = new Aluno();
        Pessoa pessoa = new Pessoa();

        StreamReader sr = new StreamReader(@"C:\Users\Elias Couto\source\repos\IntegraçãoBD_TXT\IntegraçãoBD_TXT\Data\ArquivoTexto.txt");
        string linha;
        char ax;
        char dig = 'Z';

        public void LerArquivo()
        {
            //Recebe dados do aquivo txt 
            linha = sr.ReadLine();


            //// String[x] obtém o caractere no índice x de uma string 
            //char primeiraCaractere = linha[0];

            ////FirstOrDefault() obtém o primeiro caractere de uma string.
            //primeiraCaractere = linha.FirstOrDefault();

            ////String.ToCharArray() podemos obter o caractere no índice [0] do array de caracteres
            //linha = sr.ReadLine();
            //char[] charArray = linha.ToCharArray();
            //primeiraCaractere = charArray[0];


            while (linha != null)
            {
                ax = dig;
                string[] subs = linha.Split('-');
                dig = char.Parse(subs[0]);



                if (dig == 'Y')
                {
                    curso.digito = subs[0];
                    curso.matricula = subs[1];
                    curso.IdCurso = int.Parse(subs[2]);
                    curso.nomeCurso = subs[3];


                }
                else if (dig == 'Z')
                {

                    pessoa.digito = subs[0];
                    pessoa.nome = subs[1];
                    pessoa.telefone = subs[2];
                    pessoa.cidade = subs[3];
                    pessoa.RG = subs[4];
                    pessoa.CPF = subs[5];


                }


                if (VerificarAluno(dig, ax))
                {

                    aluno.digito = pessoa.digito;
                    aluno.nome = pessoa.nome;
                    aluno.telefone = pessoa.telefone;
                    aluno.cidade = pessoa.cidade;
                    aluno.RG = pessoa.RG;
                    aluno.CPF = pessoa.CPF;
                    aluno.curso = new Curso(curso.digito, curso.matricula, curso.IdCurso, curso.nomeCurso);
                   

                }





                linha = sr.ReadLine();


            }
            sr.Close();




        }

        private bool VerificarAluno(char _dig, char _ax)
        {
            bool res = false;

            if (_dig == 'Y' && _ax == 'Z')
            {
                res = true;
            }

            else
            {
                res = false;
            }
            return res;
        }
    }
}
