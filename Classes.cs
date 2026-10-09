using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ContaEstrelas
{
    public static class BancoDeDados
    {
        //Indica o caminho do banco
        private static readonly string strConexao = "server=SERVER;port=3306;database=DB;user=USER;pwd=PASSWORD;";

        //Cria uma conexão
        public static MySqlConnection AbrirConexao()
        {
            MySqlConnection conexaoBanco = new MySqlConnection(strConexao);
            conexaoBanco.Open();
            return conexaoBanco;
        }

        //Executa um comando SQL, pensado para ALTER, DELETE e UPDATE
        public static int Executar(string strComandoSQL, Action<MySqlCommand> parametros = null)
        {
            using (MySqlConnection conexaoBanco = BancoDeDados.AbrirConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(strComandoSQL, conexaoBanco))
                {
                    parametros?.Invoke(comando);

                    return comando.ExecuteNonQuery();
                }
            }
        }

        //Executa um comando SQL, pensado para INSERT
        public static (int numeroLinhas, long ultimoId) Inserir(string strComandoSQL, Action<MySqlCommand> parametros = null)
        {
            using (MySqlConnection conexaoBanco = BancoDeDados.AbrirConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(strComandoSQL, conexaoBanco))
                {
                    parametros?.Invoke(comando);

                    int linhas = comando.ExecuteNonQuery();
                    long id = comando.LastInsertedId;
                    return (linhas, id);
                }
            }
        }

        //Executa um comando SQL, pensado para SELECT
        public static MySqlDataReader Consultar(string strComandoSQL, Action<MySqlCommand> parametros = null)
        {
            MySqlConnection conexaoBanco = BancoDeDados.AbrirConexao();

            MySqlCommand consulta = new MySqlCommand(strComandoSQL, conexaoBanco);

            parametros?.Invoke(consulta);

            return consulta.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }

    public static class Seguranca
    {
        //Cria uma "hash" de senha, para criptografia
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        //Testa uma "hash" de senha, para proteção
        public static bool ConferirSenha(string senha, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(senha, hash);
        }
    }
}
