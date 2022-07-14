using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguido de uma interface, que dizer que a classe será
    // obrigada a implementar os métodos(contrados) estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Instanciando um objeto da classe SqlConnection,
            // que permitira fazer selects, insert, updates, deletes, etc...
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o 
            // que permitira conectar ao banco de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme.Mueller\source\repos\GuilhermeDMueller\Vetor\ExemplosSQLBasico\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o banco de dados
            conexao.Open();

            // Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            // Especificado o comando que será executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES (' " + tipoPersonagem.Tipo +"')";

            // Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}