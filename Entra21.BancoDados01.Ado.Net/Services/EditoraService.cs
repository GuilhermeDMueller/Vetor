using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class EditoraService : IEditoraService
    {
        public List<Editora> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, apelido, data_criacao, faturamento FROM editoras";

            // Instanciando tabela em memória para armazenar os registros da consulta
            var tabelaEmMemoria = new DataTable();
            // Executa a consulta SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criar lista para armazenar as editoras
            var editoras = new List<Editora>();

            // Percorrido os registros retornados da consulta adiconando na lista de editoras
            for (int i = 0; i <tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var editora = new Editora();
                editora.Id = Convert.ToInt32(linha[0]);
                editora.Nome = linha[1].ToString();
                editora.Apelido = linha[2].ToString();
                editora.DataCriacao = Convert.ToDateTime(linha[3]);
                editora.Faturamento = Convert.ToDecimal(linha[4]);

                editoras.Add(editora);
            }
            // Fechar a conexão
            conexao.Close();

            return editoras;
        }
    }
}
