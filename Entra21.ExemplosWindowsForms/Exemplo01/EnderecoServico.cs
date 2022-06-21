using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        // Construtor: Mais para Frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }
        // Método Adicionar recebe como parametro o objeto do endereco completodo Form(Controler)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarNoArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            // Percorre lista de endereços afim de encontrar o enderço que deve ser alterado
            for (int indice = 0; indice < enderecos.Count; indice++)
            {
                // Obtém o endereço da lista de endereços
                var endereco = enderecos[indice];

                // Verificar se o código do endereço percorrido é o mesmo do endereço que deve ser alterado
                if(endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    // Atualizar campos do endereço encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarNoArquivo();

                    return;
                }
            }
        }
        public void Apagar(int codigoParaApagar)
        {
            // Percorre lista de endereços afim de encontrar o enderço que deve ser removido
            for (int indice = 0; indice < enderecos.Count; indice++)
            {
                // Obtém o endereço percorrido
                var endereco = enderecos[indice];

                if (endereco.Codigo == codigoParaApagar)
                {
                    // Remove o endereço encontrado da lista de endereços
                    enderecos.Remove(endereco);

                    SalvarNoArquivo();

                    return;
                }
            }
        }
        // Método que permite listar todos os endereços
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }
        public Endereco ObterPorCodigo(int codigo)
        {
            // Percorre lista de endereços afim de encontrar o enderço com o código
            for (int indice = 0; indice < enderecos.Count; indice++)
            {
                // Obtém o endereço percorrido
                var endereco = enderecos[indice];

                if (endereco.Codigo == codigo)
                {
                    return endereco;
                }
            }
            // Retorna null pois não encontrou o endereço com o código desejado
            return null;
        }

        public void SalvarEmArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("endereco.json", enderecosEmJson);
        }
        public void LerArquivo()
        {
            // Verificar se o edereço não existe
            if (File.Exists("enderecos.json") == false)
                return;

            // Ler arquivo JSON e converte para uma lista de objetos de endereços
            var enderecoEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecoEmJson);
        }
    }
}