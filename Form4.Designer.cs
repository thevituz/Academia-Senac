namespace projeto_academia
{
    partial class Form4
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
            btnNome = new Button();
            btnInstrutor = new Button();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft New Tai Lue", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(162, 29);
            label1.Name = "label1";
            label1.Size = new Size(305, 49);
            label1.TabIndex = 0;
            label1.Text = "Academia Senac";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(238, 78);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 1;
            label2.Text = "Bem-Vindo";
            // 
            // btnNome
            // 
            btnNome.BackColor = Color.White;
            btnNome.FlatStyle = FlatStyle.Flat;
            btnNome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNome.Location = new Point(238, 193);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(145, 48);
            btnNome.TabIndex = 2;
            btnNome.Text = "Aluno";
            btnNome.UseVisualStyleBackColor = false;
            btnNome.Click += button1_Click;
            // 
            // btnInstrutor
            // 
            btnInstrutor.BackColor = Color.White;
            btnInstrutor.FlatStyle = FlatStyle.Flat;
            btnInstrutor.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstrutor.Location = new Point(238, 269);
            btnInstrutor.Name = "btnInstrutor";
            btnInstrutor.Size = new Size(145, 49);
            btnInstrutor.TabIndex = 3;
            btnInstrutor.Text = "Instrutor";
            btnInstrutor.UseVisualStyleBackColor = false;
            btnInstrutor.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(212, 160);
            label3.Name = "label3";
            label3.Size = new Size(194, 19);
            label3.TabIndex = 4;
            label3.Text = "Você é aluno ou Instrutor";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(561, 405);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 5;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e863be10388e1829b8c2bd85bf81f8df;
            ClientSize = new Size(648, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(btnInstrutor);
            Controls.Add(btnNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnNome;
        private Button btnInstrutor;
        private Label label3;
        private Button button3;
    }
}