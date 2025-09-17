namespace projeto_academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn = new Button();
            btn2 = new Button();
            btnsair = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnInstrutor = new Button();
            btnMostrarInstrutor = new Button();
            SuspendLayout();
            // 
            // btn
            // 
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.Location = new Point(109, 173);
            btn.Name = "btn";
            btn.Size = new Size(169, 47);
            btn.TabIndex = 0;
            btn.Text = "Cadastrar Alunos";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(109, 241);
            btn2.Name = "btn2";
            btn2.Size = new Size(169, 47);
            btn2.TabIndex = 1;
            btn2.Text = "Mostrar Alunos";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.Red;
            btnsair.FlatStyle = FlatStyle.Flat;
            btnsair.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsair.Location = new Point(800, 396);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(75, 36);
            btnsair.TabIndex = 2;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(585, 126);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 3;
            label1.Text = "Painel Instrutor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 126);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 4;
            label2.Text = "Painel Aluno";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(46, 91);
            label3.Name = "label3";
            label3.Size = new Size(299, 242);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(519, 91);
            label4.Name = "label4";
            label4.Size = new Size(299, 242);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 24);
            label5.Name = "label5";
            label5.Size = new Size(249, 37);
            label5.TabIndex = 7;
            label5.Text = "Painel Academia";
            // 
            // btnInstrutor
            // 
            btnInstrutor.FlatStyle = FlatStyle.Flat;
            btnInstrutor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstrutor.Location = new Point(594, 173);
            btnInstrutor.Name = "btnInstrutor";
            btnInstrutor.Size = new Size(169, 47);
            btnInstrutor.TabIndex = 8;
            btnInstrutor.Text = "Cadastrar Instrutor";
            btnInstrutor.UseVisualStyleBackColor = true;
            btnInstrutor.Click += btnInstrutor_Click;
            // 
            // btnMostrarInstrutor
            // 
            btnMostrarInstrutor.FlatStyle = FlatStyle.Flat;
            btnMostrarInstrutor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarInstrutor.Location = new Point(594, 241);
            btnMostrarInstrutor.Name = "btnMostrarInstrutor";
            btnMostrarInstrutor.Size = new Size(169, 47);
            btnMostrarInstrutor.TabIndex = 9;
            btnMostrarInstrutor.Text = "Mostrar Instrutor";
            btnMostrarInstrutor.UseVisualStyleBackColor = true;
            btnMostrarInstrutor.Click += btnMostrarInstrutor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(887, 444);
            Controls.Add(btnMostrarInstrutor);
            Controls.Add(btnInstrutor);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsair);
            Controls.Add(btn2);
            Controls.Add(btn);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Button btn2;
        private Button btnsair;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnInstrutor;
        private Button btnMostrarInstrutor;
    }
}
