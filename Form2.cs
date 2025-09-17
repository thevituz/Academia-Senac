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

            MySqlConnection? con = null;
            try
            {
                con = banco.ObterConexao();
                if (!banco.ConexaoAberta(con))
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string comandoSQL = "INSERT INTO aluno (nome, endereco, telefone) VALUES (@nome, @endereco, @telefone)";

                using (MySqlCommand cmd = new MySqlCommand(comandoSQL, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@telefone", telefone);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Aluno cadastrado com sucesso.");
                    else
                        MessageBox.Show("Nenhum registro inserido.");
                }

                txbnome.Clear();
                txbendereco.Clear();
                txbtelefone.Clear();
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

        private void txbnome_TextChanged(object sender, EventArgs e) { }
        private void txbendereco_TextChanged(object sender, EventArgs e) { }
        private void txbtelefone_TextChanged(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }
    }
}
