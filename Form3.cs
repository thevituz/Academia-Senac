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
    public partial class Form3 : Form
    {
        string conexao = "Server=localhost;Database=academia;User ID=root;Password=;";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExibirAlunos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string comandoSQL = "SELECT id_aluno, nome, endereco, telefone FROM aluno";

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ExibirAlunos();
        }
    }
}
