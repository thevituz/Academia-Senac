using System;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using projeto_academia.Model;

namespace projeto_academia
{
    public partial class CadastroInstrutor : Form
    {
        private readonly Banco banco = new Banco();

        public CadastroInstrutor()
        {
            InitializeComponent();
        }

        private void CadastroInstrutor_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtNomeinstrutor_TextChanged(object sender, EventArgs e) { }
        private void txtEspecialidade_TextChanged(object sender, EventArgs e) { }
        private void txtTelefone_TextChanged(object sender, EventArgs e) { }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeinstrutor.Text.Trim();
            string especialidade = txtEspecialidade.Text.Trim();
            string telefone = txtTelefone.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(especialidade) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            var instrutor = new projeto_academia.Model.Instrutor
            {
                Nome = nome,
                Especialidade = especialidade,
                Telefone = telefone
                // Email se tiver campo
            };

            bool ok = instrutor.CadastrarInstrutor();
            if (ok)
            {
                MessageBox.Show("Instrutor cadastrado com sucesso.");
                txtNomeinstrutor.Clear();
                txtEspecialidade.Clear();
                txtTelefone.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar instrutor.");
            }
        }

    }
}
