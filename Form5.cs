using projeto_academia.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace projeto_academia
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        // Método para carregar os dados dos alunos
        private void CarregarDados()
        {
            try
            {
                Pagamentos pagamento = new Pagamentos();

                // Lista de pagamentos em dia
                DataTable emDia = pagamento.ListarPagamentosEmDia();
                dgvPagamentosEmDia.DataSource = emDia;

                // Lista de pagamentos pendentes
                DataTable pendentes = pagamento.ListarPagamentosPendentes();
                dgvPagamentosPendentes.DataSource = pendentes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }
    }
}
