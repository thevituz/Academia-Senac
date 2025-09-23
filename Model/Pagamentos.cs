using MySqlConnector;
using System;
using System.Data;

namespace projeto_academia.Model
{
    public class Pagamentos
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public bool StatusPagamento { get; set; } // true = em dia, false = pendente

        // Lista pagamentos em dia
        public DataTable ListarPagamentosEmDia()
        {
            string comando = "SELECT a.id, a.nome, p.data_pagamento, p.valor " +
                             "FROM pagamentos p " +
                             "INNER JOIN alunos a ON p.id_aluno = a.id " +
                             "WHERE p.status_pagamento = 1";

            Banco conexaoBD = new Banco();
            var con = conexaoBD.ObterConexao();
            var cmd = new MySqlCommand(comando, con);

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);
            return tabela;
        }

        // Lista pagamentos pendentes
        public DataTable ListarPagamentosPendentes()
        {
            string comando = "SELECT a.id, a.nome, p.data_pagamento, p.valor " +
                             "FROM pagamentos p " +
                             "INNER JOIN alunos a ON p.id_aluno = a.id " +
                             "WHERE p.status_pagamento = 0";

            Banco conexaoBD = new Banco();
            var con = conexaoBD.ObterConexao();
            var cmd = new MySqlCommand(comando, con);

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
