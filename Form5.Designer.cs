namespace projeto_academia
{
    partial class Form5
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
            btnVoltar = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Image = Properties.Resources.Seta_pequena_esquerda_preta;
            btnVoltar.Location = new Point(-4, -1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 84);
            btnVoltar.TabIndex = 0;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 169);
            label1.Name = "label1";
            label1.Size = new Size(385, 94);
            label1.TabIndex = 1;
            label1.Text = "Em Breve... \r\nfiquei com preguiça :c\r\n";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5153829;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Name = "Form5";
            Text = "Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnVoltar;
        private Label label1;
    }
}