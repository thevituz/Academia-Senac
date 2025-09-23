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

            var instrutor = new projeto_academia.Model.Instrutor { IdInstrutor = idParaExcluir };
            bool ok = instrutor.ApagarInstrutor();

            if (ok)
            {
                MessageBox.Show("Registro excluído com sucesso!");
                ExibirInstrutores();
            }
            else
            {
                MessageBox.Show("Erro ao excluir registro.");
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
            var instr = new projeto_academia.Model.Instrutor();
            try
            {
                DataTable dt = instr.ListarInstrutores();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar instrutores: " + ex.Message);
            }
        }

    }
}
