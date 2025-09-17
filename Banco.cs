using MySqlConnector;
using System;
using System.Data;

namespace projeto_academia.Model 
{
    public class Banco
    {
        private const string SERVER = "localhost",
                             PORT = "49170",
                             DATABASE = "academia",
                             UID = "root",
                             PWD = "";

        
        public MySqlConnection? ObterConexao()
        {
            MySqlConnection? con = null;
            try
            {
                con = new MySqlConnection($"SERVER={SERVER};PORT={PORT};DATABASE={DATABASE};UID={UID};PWD={PWD};");
                con.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Não foi possível realizar a conexão.");
                
            }
            return con;
        }

        
        public bool ConexaoAberta(MySqlConnection? con)
        {
            return (con != null && con.State == ConnectionState.Open);
        }

        
        public void Desconectar(MySqlConnection? con)
        {
            try
            {
                if (con != null)
                    con.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Não foi possível encerrar a conexão.");
            }
        }
    }
}
