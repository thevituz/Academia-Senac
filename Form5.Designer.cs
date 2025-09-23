private void InitializeComponent()
{
    this.lblTitulo = new System.Windows.Forms.Label();
    this.lblEmDia = new System.Windows.Forms.Label();
    this.lblPendentes = new System.Windows.Forms.Label();
    this.dgvPagamentosEmDia = new System.Windows.Forms.DataGridView();
    this.dgvPagamentosPendentes = new System.Windows.Forms.DataGridView();
    this.btnVoltar = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentosEmDia)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentosPendentes)).BeginInit();
    this.SuspendLayout();

    // 
    // lblTitulo
    // 
    this.lblTitulo.AutoSize = true;
    this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
    this.lblTitulo.Location = new System.Drawing.Point(270, 20);
    this.lblTitulo.Name = "lblTitulo";
    this.lblTitulo.Size = new System.Drawing.Size(250, 30);
    this.lblTitulo.Text = "Relatório de Pagamentos";

    // 
    // lblEmDia
    // 
    this.lblEmDia.AutoSize = true;
    this.lblEmDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
    this.lblEmDia.Location = new System.Drawing.Point(150, 80);
    this.lblEmDia.Name = "lblEmDia";
    this.lblEmDia.Size = new System.Drawing.Size(150, 20);
    this.lblEmDia.Text = "Pagamentos em Dia";

    // 
    // lblPendentes
    // 
    this.lblPendentes.AutoSize = true;
    this.lblPendentes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
    this.lblPendentes.Location = new System.Drawing.Point(500, 80);
    this.lblPendentes.Name = "lblPendentes";
    this.lblPendentes.Size = new System.Drawing.Size(180, 20);
    this.lblPendentes.Text = "Pagamentos Pendentes";

    // 
    // dgvPagamentosEmDia
    // 
    this.dgvPagamentosEmDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvPagamentosEmDia.Location = new System.Drawing.Point(50, 110);
    this.dgvPagamentosEmDia.Name = "dgvPagamentosEmDia";
    this.dgvPagamentosEmDia.Size = new System.Drawing.Size(300, 250);

    // 
    // dgvPagamentosPendentes
    // 
    this.dgvPagamentosPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvPagamentosPendentes.Location = new System.Drawing.Point(400, 110);
    this.dgvPagamentosPendentes.Name = "dgvPagamentosPendentes";
    this.dgvPagamentosPendentes.Size = new System.Drawing.Size(300, 250);

    // 
    // btnVoltar
    // 
    this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 10F);
    this.btnVoltar.Location = new System.Drawing.Point(300, 380);
    this.btnVoltar.Name = "btnVoltar";
    this.btnVoltar.Size = new System.Drawing.Size(100, 40);
    this.btnVoltar.Text = "Voltar";
    this.btnVoltar.UseVisualStyleBackColor = true;
    this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

    // 
    // Form5
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(750, 450);
    this.Controls.Add(this.lblTitulo);
    this.Controls.Add(this.lblEmDia);
    this.Controls.Add(this.lblPendentes);
    this.Controls.Add(this.dgvPagamentosEmDia);
    this.Controls.Add(this.dgvPagamentosPendentes);
    this.Controls.Add(this.btnVoltar);
    this.Name = "Form5";
    this.Text = "Relatório de Pagamentos";
    ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentosEmDia)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentosPendentes)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
}
