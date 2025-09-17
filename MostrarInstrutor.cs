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
    public partial class MostrarInstrutor : Form
    {
        string conexao = "Server=Localhost;Database=academia;User ID=root;password=;";
        public MostrarInstrutor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obter o Id do registro selecionado
                int idParaExcluir = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_instrutor"].Value); // Substitua "Id" pelo nome correto da coluna

                // String de conexão com o banco de dados

                // Comando SQL para exclusão
                string query = "DELETE FROM instrutor WHERE id_instrutor = @id_instrutor";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conexao))
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir o valor do parâmetro @Id
                            cmd.Parameters.AddWithValue("@id_instrutor", idParaExcluir);

                            // Executar o comando DELETE
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            // Verificar se a exclusão foi bem-sucedida
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!");
                                // Atualizar o DataGridView após a exclusão
                                ExibirInstrutores();
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarInstrutor_Load(object sender, EventArgs e)
        {
            ExibirInstrutores();
        }
        private void ExibirInstrutores()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string comandoSQL = "SELECT id_instrutor, nome, especialidade, telefone FROM instrutor";

                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        conn.Open();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dataGridView1.DataSource = dt;

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }


        }
    }
}
