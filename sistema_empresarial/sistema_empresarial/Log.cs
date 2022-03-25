
using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_empresarial
{
    class Log
    {
        private static string nome;
        private static string tipo;

        public bool Validarlog(string email, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("select* from funcionarios where email = '{0}' and senha = '{1}'", email, senha);
            DataTable dt = new DataTable();
            dt = bd.Consultar(sql);
            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["email"].ToString();
                tipo = dt.Rows[0]["senha"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Logado()
        {
            return nome;
        }
        public string LogadoTipo()
        {
            return tipo;
        }
    }
}
