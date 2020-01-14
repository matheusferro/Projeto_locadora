using MySql.Data.MySqlClient;
using System.Configuration;

namespace Locadora.Conexao
{
    internal class ConnectionFactory
    {
        public static MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["locadora_ds"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
