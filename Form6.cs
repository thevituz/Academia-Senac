using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_academia
{
    public partial class CadastroInstrutor : Form
    {
        string conexao = "Server=Localhost;Database=academia;User ID=root;password=;";
        public CadastroInstrutor()
        {
            InitializeComponent();
        }

        private void CadastroInstrutor_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtNomeinstrutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecialidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeinstrutor.Text;
            string especialidade = txtEspecialidade.Text;
            string telefone = txtTelefone.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(especialidade) || string.IsNullOrEmpty(telefone))
            {

                MessageBox.Show("Por favor, preencha todos os campos.");
                return;

            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string comandoSQL = "INSERT INTO instrutor (nome, especialidade, telefone) values (@nome, @especialidade, @telefone)";

                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@especialidade", especialidade);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        cmd.ExecuteNonQuery();
                    }
                }


                MessageBox.Show("Instrutor cadastrado com sucesso,");

                txtNomeinstrutor.Clear();
                txtEspecialidade.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar: " + ex.Message);
            }
        }
    }
}
