using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        // Construtor: construir o objeto que está sendo instanciando com as devidas informações u rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instanciando objeto de PacienteServico o permitirá listar os pacientes no ComboBox e decorrente
            // disso será possível o usuário selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEnderecos();

            // Irá preencher o ComboBox(campo de seleção) com os pacientes
            PreencherComboBoxComNomesDosPacientes();
        }

        private void PreencherComboBoxComNomesDosPacientes()
        {
            // Obter lista dos pacientes, que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os pacientes adicionando no ComboBox
            for (int indice = 0; indice < pacientes.Count; indice++)
            {
                var paciente = pacientes[indice];
                comboBox1.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBox1.SelectedItem);

            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereço na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do DataGridView
            dataGridView1.Rows.Clear();

            // Percorree cada um dos endereços 


            // Percorrer cada um dos endereços adicionando uma nova linha na Tabela
            for (var indice = 0; indice < enderecos.Count; indice++)
            {
                // Obter endereço percorrido
                var endereco = enderecos[indice];

                // Criar uma nova linha no DataGridView com os dados referentes ao endereeço

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "");

            // HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o site ViCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync(
                $"https://viacep.com.br/ws/{cep}/json").Result;

            // Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisitados>(resposta);

                textBoxEnderecoCompleto =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }
    }
}