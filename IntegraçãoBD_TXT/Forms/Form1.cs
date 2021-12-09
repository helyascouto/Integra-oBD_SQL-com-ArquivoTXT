using IntegraçãoBD_TXT.Model.Data;

namespace IntegraçãoBD_TXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Integracao integracao = new Integracao();
            integracao.LerArquivo();
        }
    }
}