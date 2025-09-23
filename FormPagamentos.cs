using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using projeto_academia.Model;

namespace projeto_academia
{
    public partial class FormPagamentos : Form
    {
        public FormPagamentos()
        {
            InitializeComponent();
        }

        private void FormPagamentos_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
            PreencherMetodo();
            ExibirPagamentos();
        }

        // Carrega alunos no ComboBox (display=nome, value=id_aluno)
        private void CarregarAlunos()
        {
            try
            {
                var alunoModel = new Aluno();
                DataTable dt = alunoModel.ListarAlunos();

                cmbAluno.DataSource = dt;
                cmbAluno.DisplayMember = "nome";
                cmbAluno.ValueMember = "id_aluno";
                cmbAluno.SelectedIndex = -1; // nenhum selecionado por padrão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }
        }

        private void PreencherMetodo()
        {
            cmbMetodo.Items.Clear();
            cmbMetodo.Items.Add("Dinheiro");
            cmbMetodo.Items.Add("Cartão");
            cmbMetodo.Items.Add("Pix");
            cmbMetodo.Items.Add("Transferência");
            cmbMetodo.SelectedIndex = 0;
        }

        // Exibe pagamentos no DataGridView
        private void ExibirPagamentos()
        {
            try
            {
                var pagModel = new Pagamentos();
                DataTable dt = pagModel.ListarPagamentos();
                dgvPagamentos.DataSource = dt;

                // formatação opcional da coluna valor (se existir)
                if (dgvPagamentos.Columns.Contains("valor"))
                {
                    dgvPagamentos.Columns["valor"].DefaultCellStyle.Format = "N2";
                    dgvPagamentos.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pagamentos: " + ex.Message);
            }
        }

        // Botão Cadastrar -> cria Pagamento e chama model
        private void btnCadastrarPagamento_Click(object sender, EventArgs e)
        {
            if (cmbAluno.SelectedValue == null)
            {
                MessageBox.Show("Selecione um aluno.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Informe o valor do pagamento.");
                return;
            }

            // parse decimal usando cultura atual (aceita vírgula ou ponto conforme sistema)
            if (!decimal.TryParse(txtValor.Text, System.Globalization.NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valor))
            {
                MessageBox.Show("Valor inválido. Ex.: 120.50 ou 120,50");
                return;
            }

            int idAluno = Convert.ToInt32(cmbAluno.SelectedValue);
            string metodo = cmbMetodo.Text.Trim();

            var pag = new Pagamentos
            {
                IdAluno = idAluno,
                Valor = valor,
                Metodo = metodo
            };

            bool ok = pag.CadastrarPagamento();
            if (ok)
            {
                MessageBox.Show("Pagamento cadastrado com sucesso.");
                txtValor.Clear();
                cmbAluno.SelectedIndex = -1;
                cmbMetodo.SelectedIndex = 0;
                ExibirPagamentos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar pagamento. Verifique a conexão ou dados.");
            }
        }

        // Botão Excluir -> deleta o pagamento selecionado no DataGridView
        private void btnExcluirPagamento_Click(object sender, EventArgs e)
        {
            if (dgvPagamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pagamento para excluir.");
                return;
            }

            var cellVal = dgvPagamentos.SelectedRows[0].Cells["id_pagamento"].Value;
            if (cellVal == null || !int.TryParse(cellVal.ToString(), out int idPagamento))
            {
                MessageBox.Show("Não foi possível obter o id do pagamento selecionado.");
                return;
            }

            var pag = new Pagamentos { IdPagamento = idPagamento };
            bool ok = pag.ApagarPagamento();

            if (ok)
            {
                MessageBox.Show("Pagamento excluído com sucesso.");
                ExibirPagamentos();
            }
            else
            {
                MessageBox.Show("Erro ao excluir pagamento.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4(); //Volta para o Menu
            form1.Show();
            this.Hide();
        }

        // Quando o usuário clicar em uma linha, opcionalmente carregar valores nos controles
        private void dgvPagamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPagamentos.SelectedRows.Count == 0) return;

            var row = dgvPagamentos.SelectedRows[0];
            if (row.Cells["id_aluno"].Value != null)
            {
                int idAluno = Convert.ToInt32(row.Cells["id_aluno"].Value);
                // tenta selecionar o aluno no combobox
                for (int i = 0; i < cmbAluno.Items.Count; i++)
                {
                    // o DataSource é DataTable, então acessamos o item via DataRowView
                    var drv = cmbAluno.Items[i] as DataRowView;
                    if (drv != null && Convert.ToInt32(drv["id_aluno"]) == idAluno)
                    {
                        cmbAluno.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (row.Cells["valor"].Value != null)
            {
                txtValor.Text = row.Cells["valor"].Value.ToString();
            }

            if (row.Cells["metodo"].Value != null)
            {
                string metodo = row.Cells["metodo"].Value.ToString();
                if (cmbMetodo.Items.Contains(metodo))
                    cmbMetodo.SelectedItem = metodo;
                else
                    cmbMetodo.Text = metodo;
            }
        }
    }
}
