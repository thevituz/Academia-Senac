using System;
using System.Data;
using MySqlConnector;

namespace projeto_academia.Model
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }

        // Listar alunos (SELECT)
        public DataTable ListarAlunos()
        {
            string comando = "SELECT id_aluno, nome, endereco, telefone, data_cadastro FROM aluno";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();

            DataTable tabela = new DataTable();

            if (con == null) return tabela;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Prepare();
                tabela.Load(cmd.ExecuteReader());
            }

            conexaoBD.Desconectar(con);
            return tabela;
        }

        // Cadastrar aluno (INSERT)
        public bool CadastrarAluno()
        {
            string comando = "INSERT INTO aluno (nome, endereco, telefone) VALUES (@nome, @endereco, @telefone)";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            if (con == null) return false;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@endereco", Endereco);
                cmd.Parameters.AddWithValue("@telefone", Telefone);

                cmd.Prepare();

                try
                {
                    int affected = cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar(con);
                    return affected > 0;
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
        }
    }
}
