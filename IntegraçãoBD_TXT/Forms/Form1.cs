using IntegraçãoBD_TXT.Data;
using IntegraçãoBD_TXT.Model;
using IntegraçãoBD_TXT.Model.Data;
using System.Data;

namespace IntegraçãoBD_TXT
{
    public partial class Form1 : Form
    {
        Pessoa pessoa = new Pessoa();
        Aluno aluno = new Aluno();
        Curso curso = new Curso();
        Integracao integracao = new Integracao();
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnCadastrarBanco_Click(object sender, EventArgs e)
        {
            Integracao integracao = new Integracao();
            pessoa.gravarPessoa();
            curso.gravarCurso();
            aluno.gravarAluno();

        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            aluno.consultarAluno(dataGridView1);
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            curso.consultarCurso(dataGridView1);
        }

        private void BtnPessoa_Click(object sender, EventArgs e)
        {
            pessoa.consultarPessoas(dataGridView1);
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
           
            integracao.LerArquivo();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            integracao.mostrar();
        }
    }
}