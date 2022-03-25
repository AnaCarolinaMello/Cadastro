
using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_empresarial
{
    class ConexaoBD
    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            conexao = new MySqlConnection("Persist Security Info = false; " +
            "server = localhost; " +
            "database = SISTEMA_EMPRESARIAL; " +
            "uid = root;pwd=;SslMode=none");
            conexao.Open();
        }

        public void Alterar(string sql)
        {
            ConectarBD();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable Consultar(string sql)
        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }

        
    }
}
