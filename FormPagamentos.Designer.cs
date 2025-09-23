namespace projeto_academia
{
    partial class FormPagamentos
    {
        /// <summary>
        /// Variáveis de designer
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Button btnCadastrarPagamento;
        private System.Windows.Forms.Button btnExcluirPagamento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvPagamentos;

        /// <summary>
        /// Limpar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblAluno = new Label();
            cmbAluno = new ComboBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblMetodo = new Label();
            cmbMetodo = new ComboBox();
            btnCadastrarPagamento = new Button();
            btnExcluirPagamento = new Button();
            btnVoltar = new Button();
            dgvPagamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gerenciar Pagamentos";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(20, 55);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(42, 15);
            lblAluno.TabIndex = 1;
            lblAluno.Text = "Aluno:";
            // 
            // cmbAluno
            // 
            cmbAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAluno.FormattingEnabled = true;
            cmbAluno.Location = new Point(20, 75);
            cmbAluno.Name = "cmbAluno";
            cmbAluno.Size = new Size(280, 23);
            cmbAluno.TabIndex = 2;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(20, 110);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(20, 130);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(280, 23);
            txtValor.TabIndex = 4;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Location = new Point(20, 165);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(52, 15);
            lblMetodo.TabIndex = 5;
            lblMetodo.Text = "Método:";
            // 
            // cmbMetodo
            // 
            cmbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Location = new Point(20, 185);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(280, 23);
            cmbMetodo.TabIndex = 6;
            // 
            // btnCadastrarPagamento
            // 
            btnCadastrarPagamento.Location = new Point(20, 225);
            btnCadastrarPagamento.Name = "btnCadastrarPagamento";
            btnCadastrarPagamento.Size = new Size(140, 40);
            btnCadastrarPagamento.TabIndex = 7;
            btnCadastrarPagamento.Text = "Cadastrar";
            btnCadastrarPagamento.UseVisualStyleBackColor = true;
            btnCadastrarPagamento.Click += btnCadastrarPagamento_Click;
            // 
            // btnExcluirPagamento
            // 
            btnExcluirPagamento.Location = new Point(160, 225);
            btnExcluirPagamento.Name = "btnExcluirPagamento";
            btnExcluirPagamento.Size = new Size(140, 40);
            btnExcluirPagamento.TabIndex = 8;
            btnExcluirPagamento.Text = "Excluir Selecionado";
            btnExcluirPagamento.UseVisualStyleBackColor = true;
            btnExcluirPagamento.Click += btnExcluirPagamento_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(20, 280);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(280, 40);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvPagamentos
            // 
            dgvPagamentos.AllowUserToAddRows = false;
            dgvPagamentos.AllowUserToDeleteRows = false;
            dgvPagamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPagamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagamentos.Location = new Point(320, 15);
            dgvPagamentos.MultiSelect = false;
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.ReadOnly = true;
            dgvPagamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagamentos.Size = new Size(460, 420);
            dgvPagamentos.TabIndex = 10;
            dgvPagamentos.SelectionChanged += dgvPagamentos_SelectionChanged;
            // 
            // FormPagamentos
            // 
            BackgroundImage = Properties.Resources._5153829;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblAluno);
            Controls.Add(cmbAluno);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblMetodo);
            Controls.Add(cmbMetodo);
            Controls.Add(btnCadastrarPagamento);
            Controls.Add(btnExcluirPagamento);
            Controls.Add(btnVoltar);
            Controls.Add(dgvPagamentos);
            Name = "FormPagamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Pagamentos";
            Load += FormPagamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
