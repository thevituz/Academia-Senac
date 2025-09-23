using System;
using System.Data;
using MySqlConnector;

namespace projeto_academia.Model
{
    public class Instrutor
    {
        public int IdInstrutor { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Especialidade { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }

        // Listar instrutores
        public DataTable ListarInstrutores()
        {
            string comando = "SELECT id_instrutor, nome, especialidade, telefone, email, data_cadastro FROM instrutor";

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

        // Cadastrar instrutor
        public bool CadastrarInstrutor()
        {
            string comando = "INSERT INTO instrutor (nome, especialidade, telefone, email) VALUES (@nome, @especialidade, @telefone, @email)";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            if (con == null) return false;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@especialidade", Especialidade);
                cmd.Parameters.AddWithValue("@telefone", Telefone);
                cmd.Parameters.AddWithValue("@email", Email);

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

        // Apagar instrutor
        public bool ApagarInstrutor()
        {
            string comando = "DELETE FROM instrutor WHERE id_instrutor = @id";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            if (con == null) return false;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Parameters.AddWithValue("@id", IdInstrutor);
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
