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
            var aluno = new projeto_academia.Model.Aluno();
            try
            {
                DataTable dt = aluno.ListarAlunos();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e) { }

        private void Form3_Load(object sender, EventArgs e)
        {
            ExibirAlunos();
        }
    }
}
