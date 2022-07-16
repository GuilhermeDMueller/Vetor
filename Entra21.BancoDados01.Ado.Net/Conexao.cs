using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciando um objeto da classe SqlConnection,
            // que permitira fazer selects, insert, updates, deletes, etc...
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o 
            // que permitira conectar ao banco de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme.Mueller\source\repos\GuilhermeDMueller\Vetor\ExemplosSQLBasico\Bb2.mdf;Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}