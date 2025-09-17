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

            MySqlConnection? con = null;
            try
            {
                con = banco.ObterConexao();
                if (!banco.ConexaoAberta(con))
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string comandoSQL = "INSERT INTO instrutor (nome, especialidade, telefone) VALUES (@nome, @especialidade, @telefone)";

                using (MySqlCommand cmd = new MySqlCommand(comandoSQL, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@especialidade", especialidade);
                    cmd.Parameters.AddWithValue("@telefone", telefone);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Instrutor cadastrado com sucesso.");
                    else
                        MessageBox.Show("Nenhum registro inserido.");
                }

                txtNomeinstrutor.Clear();
                txtEspecialidade.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                banco.Desconectar(con);
            }
        }
    }
}
