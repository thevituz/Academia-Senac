namespace projeto_academia
{
    partial class Form2
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
            btn = new Button();
            tbnvoltar = new Button();
            lblnome = new Label();
            lblendereco = new Label();
            lbltelefone = new Label();
            txbnome = new TextBox();
            txbendereco = new TextBox();
            txbtelefone = new TextBox();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(181, 244);
            btn.Name = "btn";
            btn.Size = new Size(120, 24);
            btn.TabIndex = 0;
            btn.Text = "Cadastrar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // tbnvoltar
            // 
            tbnvoltar.Location = new Point(201, 285);
            tbnvoltar.Name = "tbnvoltar";
            tbnvoltar.Size = new Size(86, 23);
            tbnvoltar.TabIndex = 1;
            tbnvoltar.Text = "Página Inicial";
            tbnvoltar.UseVisualStyleBackColor = true;
            tbnvoltar.Click += tbnvoltar_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(154, 64);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 2;
            lblnome.Text = "Nome";
            // 
            // lblendereco
            // 
            lblendereco.AutoSize = true;
            lblendereco.Location = new Point(154, 120);
            lblendereco.Name = "lblendereco";
            lblendereco.Size = new Size(56, 15);
            lblendereco.TabIndex = 3;
            lblendereco.Text = "Endereço";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(154, 178);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(51, 15);
            lbltelefone.TabIndex = 4;
            lbltelefone.Text = "Telefone";
            // 
            // txbnome
            // 
            txbnome.Location = new Point(154, 82);
            txbnome.Name = "txbnome";
            txbnome.Size = new Size(182, 23);
            txbnome.TabIndex = 5;
            txbnome.TextChanged += txbnome_TextChanged;
            // 
            // txbendereco
            // 
            txbendereco.Location = new Point(154, 138);
            txbendereco.Name = "txbendereco";
            txbendereco.Size = new Size(182, 23);
            txbendereco.TabIndex = 6;
            txbendereco.TextChanged += txbendereco_TextChanged;
            // 
            // txbtelefone
            // 
            txbtelefone.Location = new Point(154, 196);
            txbtelefone.Name = "txbtelefone";
            txbtelefone.Size = new Size(182, 23);
            txbtelefone.TabIndex = 7;
            txbtelefone.TextChanged += txbtelefone_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5153829;
            ClientSize = new Size(486, 450);
            Controls.Add(txbtelefone);
            Controls.Add(txbendereco);
            Controls.Add(txbnome);
            Controls.Add(lbltelefone);
            Controls.Add(lblendereco);
            Controls.Add(lblnome);
            Controls.Add(tbnvoltar);
            Controls.Add(btn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Button tbnvoltar;
        private Label lblnome;
        private Label lblendereco;
        private Label lbltelefone;
        private TextBox txbnome;
        private TextBox txbendereco;
        private TextBox txbtelefone;
    }
}