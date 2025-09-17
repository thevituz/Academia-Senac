namespace projeto_academia
{
    partial class CadastroInstrutor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeinstrutor = new TextBox();
            txtEspecialidade = new TextBox();
            txtTelefone = new TextBox();
            btnVoltar = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(79, 92);
            label1.Name = "label1";
            label1.Size = new Size(358, 338);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 40);
            label2.Name = "label2";
            label2.Size = new Size(287, 37);
            label2.TabIndex = 1;
            label2.Text = "Cadastrar Instrudor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(195, 124);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 2;
            label3.Text = "Nome Sobrenome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(209, 187);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 3;
            label4.Text = "Especialidade";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(219, 254);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 4;
            label5.Text = "Telefone";
            // 
            // txtNomeinstrutor
            // 
            txtNomeinstrutor.Location = new Point(137, 144);
            txtNomeinstrutor.Name = "txtNomeinstrutor";
            txtNomeinstrutor.PlaceholderText = " Insira seu nome e sobrenome";
            txtNomeinstrutor.Size = new Size(235, 23);
            txtNomeinstrutor.TabIndex = 5;
            txtNomeinstrutor.TextChanged += txtNomeinstrutor_TextChanged;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(137, 218);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PlaceholderText = " Insira sua especialidade";
            txtEspecialidade.Size = new Size(235, 23);
            txtEspecialidade.TabIndex = 6;
            txtEspecialidade.TextChanged += txtEspecialidade_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(137, 283);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = " insira seu numero";
            txtTelefone.Size = new Size(235, 23);
            txtTelefone.TabIndex = 7;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.AutoEllipsis = true;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Image = Properties.Resources.Seta_pequena_esquerda_preta;
            btnVoltar.Location = new Point(1, 9);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(77, 42);
            btnVoltar.TabIndex = 8;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(195, 340);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(124, 47);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // CadastroInstrutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5153829;
            ClientSize = new Size(554, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEspecialidade);
            Controls.Add(txtNomeinstrutor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroInstrutor";
            Text = "Cadastro Instrutor";
            Load += CadastroInstrutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeinstrutor;
        private TextBox txtEspecialidade;
        private TextBox txtTelefone;
        private Label btnVoltar;
        private Button btnCadastrar;
    }
}