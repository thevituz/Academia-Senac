using System;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using projeto_academia.Model;

namespace projeto_academia
{
    public partial class Form3 : Form
    {
        private readonly Banco banco = new Banco();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void ExibirAlunos()
        {
            MySqlConnection? con = null;
            try
            {
                con = banco.ObterConexao();
                if (!banco.ConexaoAberta(con))
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string comandoSQL = "SELECT id_aluno, nome, endereco, telefone FROM aluno";

                using (MySqlCommand cmd = new MySqlCommand(comandoSQL, con))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                banco.Desconectar(con);
            }
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void Form3_Load(object sender, EventArgs e)
        {
            ExibirAlunos();
        }
    }
}
