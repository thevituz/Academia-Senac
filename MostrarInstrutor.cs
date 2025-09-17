using System;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using projeto_academia.Model;

namespace projeto_academia
{
    public partial class MostrarInstrutor : Form
    {
        private readonly Banco banco = new Banco();

        public MostrarInstrutor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            var cellValue = dataGridView1.SelectedRows[0].Cells["id_instrutor"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int idParaExcluir))
            {
                MessageBox.Show("Não foi possível obter o id do registro selecionado.");
                return;
            }

            string query = "DELETE FROM instrutor WHERE id_instrutor = @id_instrutor";

            MySqlConnection? con = null;
            try
            {
                con = banco.ObterConexao();
                if (!banco.ConexaoAberta(con))
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id_instrutor", idParaExcluir);
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso!");
                        ExibirInstrutores();
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                banco.Desconectar(con);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void MostrarInstrutor_Load(object sender, EventArgs e)
        {
            ExibirInstrutores();
        }

        private void ExibirInstrutores()
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

                string comandoSQL = "SELECT id_instrutor, nome, especialidade, telefone FROM instrutor";

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
    }
}
