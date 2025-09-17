namespace projeto_academia
{
    partial class MostrarInstrutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            BtnVoltar = new Label();
            label1 = new Label();
            label2 = new Label();
            btnExcluir = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.Transparent;
            BtnVoltar.Image = Properties.Resources.Seta_pequena_esquerda_preta;
            BtnVoltar.Location = new Point(-2, -4);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(100, 96);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 35);
            label1.Name = "label1";
            label1.Size = new Size(351, 37);
            label1.TabIndex = 2;
            label1.Text = "Instrutores Cadastrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 370);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 3;
            label2.Text = "Excluir";
            label2.Click += label2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Image = Properties.Resources.delete;
            btnExcluir.Location = new Point(313, 391);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 50);
            btnExcluir.TabIndex = 4;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // MostrarInstrutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5153829;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnVoltar);
            Controls.Add(dataGridView1);
            Name = "MostrarInstrutor";
            Text = "Mostrar Instrutor";
            Load += MostrarInstrutor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label BtnVoltar;
        private Label label1;
        private Label label2;
        private Label btnExcluir;
    }
}