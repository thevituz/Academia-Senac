using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_academia
{
    public partial class Form2 : Form
    {
        string conexao = "Server=Localhost;Database=academia;User ID=root;password=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void tbnvoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string nome = txbnome.Text;
            string endereco = txbendereco.Text;
            string telefone = txbtelefone.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(telefone)) 
            {

                MessageBox.Show("Por favor, preencha todos os campos.");
                return;

            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string comandoSQL = "INSERT INTO aluno (nome, endereco, telefone) values (@nome, @endereco, @telefone)";

                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        cmd.ExecuteNonQuery();
                    }
                }


                MessageBox.Show("Aluno cadastrado com sucesso,");

                txbnome.Clear();
                txbendereco.Clear();
                txbtelefone.Clear();
            }
            catch (Exception ex)
            { 
                   MessageBox.Show("Erro ao Cadastrar: " +  ex.Message);
            }
                


        }

        private void txbnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbtelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
