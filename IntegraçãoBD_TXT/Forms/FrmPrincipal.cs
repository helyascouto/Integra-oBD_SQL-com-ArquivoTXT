using IntegraçãoBD_TXT.Data;
using IntegraçãoBD_TXT.Model;
using IntegraçãoBD_TXT.Model.Data;
using System.Data;

namespace IntegraçãoBD_TXT
{
    public partial class FrmPrincipal : Form
    {
        Pessoa pessoa = new Pessoa();
        Aluno aluno = new Aluno();
        Curso curso = new Curso();
        Integracao integracao = new Integracao();
        public FrmPrincipal()
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

            abilitarCamposAlunos();

        }

        private void abilitarCamposAlunos()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            mostraPainel();
            abilitarBotao();


            Label lbnfk_pessoa = new Label();
            lbnfk_pessoa.Location = new Point(0, 0);
            lbnfk_pessoa.Text = "fk_pessoa:";
            TextBox textBoxFk_pessoa = new TextBox();
            textBoxFk_pessoa.Text = "";
            textBoxFk_pessoa.Location = new Point(0, 25);

            Label lbnMatricula = new Label();
            lbnMatricula.Location = new Point(0, 50);
            lbnMatricula.Text = "Matricula:";
            TextBox textBoxMatricula = new TextBox();
            textBoxMatricula.Text = "";
            textBoxMatricula.Location = new Point(0, 75);


            Label lbnFk_curso = new Label();
            lbnFk_curso.Location = new Point(0, 100);
            lbnFk_curso.Text = "fk_curso::";
            TextBox textBoxFk_curso = new TextBox();
            textBoxFk_curso.Text = "";
            textBoxFk_curso.Location = new Point(0, 125);




            panel1.Controls.Add(lbnfk_pessoa);
            panel1.Controls.Add(lbnFk_curso);
            panel1.Controls.Add(lbnMatricula);
            panel1.Controls.Add(textBoxMatricula);
            panel1.Controls.Add(textBoxFk_curso);
            panel1.Controls.Add(textBoxFk_pessoa);
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            curso.consultarCurso(dataGridView1);
            abilitarCamposCursos();
        }

        private void BtnPessoa_Click(object sender, EventArgs e)
        {
            pessoa.consultarPessoas(dataGridView1);

            abilitarCamposPessoas();

        }



        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            escondePainel();
            integracao.LerArquivo();
            desabilitarBotao();
            

        }



        private void btnMostrar_Click(object sender, EventArgs e)
        {
            desabilitarBotao();
            escondePainel();
            integracao.mostrar();

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            //{
            //    try
            //    {
            //        Programador programador = new Programador();
            //        int idProgramador = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //        programador = programador.retornaProgramador(idProgramador);
            //        txtId.Text = programador.id.ToString();
            //        txtNome.Text = programador.nome;
            //        txtLinguagem.Text = programador.linguagem;
            //        txtBanco.Text = programador.banco;
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }

        private void abilitarCamposPessoas()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            mostraPainel();
            abilitarBotao();


            Label lbnId = new Label();
            lbnId.Location = new Point(0, 0);
            lbnId.Text = "ID:";
            TextBox textBoxId = new TextBox();
            textBoxId.Text = "";
            textBoxId.Location = new Point(0, 25);

            Label lbnDigito = new Label();
            lbnDigito.Location = new Point(0, 50);
            lbnDigito.Text = "Digito:";
            TextBox textBoxDigito = new TextBox();
            textBoxDigito.Text = "";
            textBoxDigito.Location = new Point(0, 75);


            Label lbnTelefone = new Label();
            lbnTelefone.Location = new Point(0, 100);
            lbnTelefone.Text = "Telefone::";
            TextBox textBoxTelefone = new TextBox();
            textBoxTelefone.Text = "";
            textBoxTelefone.Location = new Point(0, 125);

            Label lbnCidade = new Label();
            lbnCidade.Location = new Point(0, 150);
            lbnCidade.Text = "Cidade:";
            TextBox textBoxCidade = new TextBox();
            textBoxCidade.Text = "";
            textBoxCidade.Location = new Point(0, 175);


            panel1.Controls.Add(lbnId);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(lbnDigito);
            panel1.Controls.Add(textBoxDigito);
            panel1.Controls.Add(lbnTelefone);
            panel1.Controls.Add(textBoxTelefone);
            panel1.Controls.Add(lbnCidade);
            panel1.Controls.Add(textBoxCidade);



            Label lbnRG = new Label();
            lbnRG.Location = new Point(0, 25);
            lbnRG.Text = "RG:";
            TextBox textBoxRg = new TextBox();
            textBoxRg.Text = "";
            textBoxRg.Location = new Point(0, 50);


            Label lbnCpf = new Label();
            lbnCpf.Location = new Point(0, 75);
            lbnCpf.Text = "CPF:";
            TextBox textBoxCpf = new TextBox();
            textBoxCpf.Text = "";
            textBoxCpf.Location = new Point(0, 100);

            Label lbnPessoa = new Label();
            lbnPessoa.Location = new Point(0, 125);
            lbnPessoa.Text = "Pessoa:";
            TextBox textBoxPessoa = new TextBox();
            textBoxPessoa.Text = "";
            textBoxPessoa.Location = new Point(0, 150);


            panel2.Controls.Add(textBoxRg);
            panel2.Controls.Add(lbnRG);
            panel2.Controls.Add(textBoxCpf);
            panel2.Controls.Add(lbnCpf);
            panel2.Controls.Add(textBoxPessoa);
            panel2.Controls.Add(lbnPessoa);
        }

        private void abilitarCamposCursos()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            abilitarBotao();
            mostraPainel();

            Label lbnId = new Label();
            lbnId.Location = new Point(0, 0);
            lbnId.Text = "ID:";
            TextBox textBoxId = new TextBox();
            textBoxId.Text = "";
            textBoxId.Location = new Point(0, 25);

            Label lbnNomeCurso = new Label();
            lbnNomeCurso.Location = new Point(0, 50);
            lbnNomeCurso.Text = "Nome Curso:";
            TextBox textBoxNomeCurso = new TextBox();
            textBoxNomeCurso.Text = "";
            textBoxNomeCurso.Location = new Point(0, 75);


            Label lbnMatricula = new Label();
            lbnMatricula.Location = new Point(0, 100);
            lbnMatricula.Text = "Matricula::";
            TextBox textBoxMatricula = new TextBox();
            textBoxMatricula.Text = "";
            textBoxMatricula.Location = new Point(0, 125);

            Label lbndigito = new Label();
            lbndigito.Location = new Point(0, 150);
            lbndigito.Text = "Cidade:";
            TextBox textBoxDigito = new TextBox();
            textBoxDigito.Text = "";
            textBoxDigito.Location = new Point(0, 175);


            panel1.Controls.Add(lbnId);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(lbnNomeCurso);
            panel1.Controls.Add(textBoxNomeCurso);
            panel1.Controls.Add(lbnMatricula);
            panel1.Controls.Add(textBoxMatricula);
            panel1.Controls.Add(lbndigito);
            panel1.Controls.Add(textBoxDigito);


        }

        private void abilitarBotao()
        {
            btnAtualizar.Visible = true;
            btnExcluir.Visible = true;
            btnLimpar.Visible = true;
            btnSalvar.Visible = true;
        }
        private void desabilitarBotao()
        {
            btnAtualizar.Visible = false;
            btnExcluir.Visible = false;
            btnLimpar.Visible = false;
            btnSalvar.Visible = false;
        }
        private void escondePainel()
        {

            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void mostraPainel()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Visible = true;
            panel2.Visible = true;
        }
    }
}