using System;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using projeto_academia.Model;

namespace projeto_academia
{
    public partial class Form2 : Form
    {
        private readonly Banco banco = new Banco();

        public Form2()
        {
            InitializeComponent();
        }

        private void tbnvoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string nome = txbnome.Text.Trim();
            string endereco = txbendereco.Text.Trim();
            string telefone = txbtelefone.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            var aluno = new projeto_academia.Model.Aluno
            {
                Nome = nome,
                Endereco = endereco,
                Telefone = telefone
            };

            bool ok = aluno.CadastrarAluno();
            if (ok)
            {
                MessageBox.Show("Aluno cadastrado com sucesso.");
                txbnome.Clear();
                txbendereco.Clear();
                txbtelefone.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar aluno. Verifique a conexão.");
            }
        }

        private void txbnome_TextChanged(object sender, EventArgs e) { }
        private void txbendereco_TextChanged(object sender, EventArgs e) { }
        private void txbtelefone_TextChanged(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }
    }
}
