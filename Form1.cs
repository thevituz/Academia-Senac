namespace projeto_academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnInstrutor_Click(object sender, EventArgs e)
        {
            CadastroInstrutor form6 = new CadastroInstrutor();
            form6.Show();
            this.Hide();
        }

        private void btnMostrarInstrutor_Click(object sender, EventArgs e)
        {
            MostrarInstrutor form7 = new MostrarInstrutor();
            form7.Show();
            this.Hide();
        }
    }
}
