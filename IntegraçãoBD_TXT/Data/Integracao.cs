using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegraçãoBD_TXT.Model.Data
{
    internal class Integracao

    {
        public Curso curso = new Curso();
        public Aluno aluno = new Aluno();
        public Pessoa pessoa = new Pessoa();


        StreamReader sr = new StreamReader(@"C:\Users\Elias Couto\source\repos\IntegraçãoBD_TXT\IntegraçãoBD_TXT\Data\ArquivoTexto.txt");
        string linha;
        char ax;
        char dig = 'Z';
        int quatAlunos, quatPessoas,id;
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
                    curso.gravarCurso();


                }
                else if (dig == 'Z')
                {
                    pessoa.idPessoa = id;
                    pessoa.digito = subs[0];
                    pessoa.nome = subs[1];
                    pessoa.telefone = subs[2];
                    pessoa.cidade = subs[3];
                    pessoa.RG = subs[4];
                    pessoa.CPF = subs[5];
                    pessoa.gravarPessoa();

                }


                if (VerificarAluno(dig, ax))
                {
                    id++;
                    aluno.fk_Pessoa = pessoa.idPessoa = id; 
                    aluno.matricula = int.Parse(curso.matricula);
                    aluno.fk_curso = curso.IdCurso;
                    aluno.gravarAluno();
                    quatAlunos++;

                }
                else
                {
                    quatPessoas++;
                }


                linha = sr.ReadLine();


            }
            sr.Close();

            MessageBox.Show("Arquivo lido e gravado com sucesso!", "Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

       public void mostrar()
        {
            MessageBox.Show("Pessoas "+quatPessoas+" Alunos "+quatAlunos, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
