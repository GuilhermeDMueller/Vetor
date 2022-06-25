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

            ObterDadosCep();

            LimparCampos();
        }

        private void PreencherComboBoxComNomesDosPacientes()
        {
            // Obter lista dos pacientes, que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os pacientes adicionando no ComboBox
            for (int indice = 0; indice < pacientes.Count; indice++)
            {
                var paciente = pacientes[indice];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            var dadosValidos = ValidarDados(cep, enderecoCompleto, nomePaciente);

            // Verifica se os dados são inválidos para n dar continuidade no cadastro do endereço
            if (dadosValidos == false)
            {
                return;
            }

            // Verificar senão está em modo de edição 
            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarNovoEndereco(cep, enderecoCompleto, nomePaciente);

            else
                EditarEndereco(cep, enderecoCompleto, nomePaciente);

            CadastrarNovoEndereco(cep, enderecoCompleto, nomePaciente);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            // Obter linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter código que está na coluna oculta do DatGridView
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Construir Objeto com os dados da tela
            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Atualizar  o dado da lista de endereços  e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);

        }

        private void CadastrarNovoEndereco(string cep, string enderecoCompleto, string? nomePaciente)
        {
            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereço na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);
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

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count ==  0)
            {
                MessageBox.Show("");
            }
            var resposta = MessageBox.Show("Deseja realente apagar o endereço?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa o teu registro ta salvo");

                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = enderecoServico.ObterPorCodigo(codigo);

            enderecoServico.Apagar(endereco);

            PreencherDataGridViewComEnderecos();

            dataGridView1.ClearSelection();
        }

        public bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                return false;
            }
            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço Completo deve conter no minimo 10 Caracters");

                return false;
            }
            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente");

                comboBoxPaciente.DroppedDown = true;

                return false;
            }
            return true;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }
            // Obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //Obter o código do endereço que o usuário selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter o endereço escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apresentar os dados do endereço na tela de edição
            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPaciente.SelectedItem = endereco.Paciente.Nome;
        }

        // Quando o formulario é carregado apresenta os dados do DataGridView
        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
    }
}