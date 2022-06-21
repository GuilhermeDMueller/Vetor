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
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int quantidadeLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();

            // Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            // Ler do arquivo JSON os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular imc
            var imc = CalcularImc(peso, altura);
            
            // Verificar se está em modo de adição
            if (quantidadeLinhaSelecionada == -1)
            {
                // Adicionar linha no dataGridView de pacientes
                dataGridView1.Rows.Add(new object[]
                {
                    ++codigo, nome, altura, peso, imc
                });
                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);

                return;
            }
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[quantidadeLinhaSelecionada].Cells[4].Value = imc.ToString();

            EditarDados(nome, peso, altura);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Obter a quantidade de linhas que o usuario selecionou no DataGridView
            var indiceLinhaSelecionada = dataGridView1.SelectedRows.Count;

            if (indiceLinhaSelecionada == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }
            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verificar se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Remove a linha utilizando o indice do DataGrideView
                dataGridView1.Rows.RemoveAt(quantidadeLinhaSelecionada);

                // Remove o paciente da lista de pacientes
                pacientes.RemoveAt(quantidadeLinhaSelecionada);

                // Atualiza o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }
            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passando a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[quantidadeLinhaSelecionada].Nome = nome;
            pacientes[quantidadeLinhaSelecionada].Peso = peso;
            pacientes[quantidadeLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();

            LimparCampos();
        }

        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };
            //var paciente = new Paciente();
            //paciente.Codigo = codigo;
            //paciente.Nome = nome;

            pacientes.Add(paciente);

            SalvarEmArquivo();

            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            quantidadeLinhaSelecionada = -1;

            dataGridView1.ClearSelection();
        }

        private void SalvarEmArquivo()
        {
            // Converter uma listade objetos em uma string contendo JSON
            var pacientesJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            // Salvar a string contendo o JSON em um arquivo no formato JSON
            File.WriteAllText(caminho, pacientesJson);
        }

        private void LerArquivoApresentandoPacientes()
        {
            // Validar se arquivo não existe, consequentemente não é necessário percorrer uma lista que não existe
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler arquivo e armazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            var maiorCodigo = int.MinValue;

            // Criar uma variavel para armazenar o código do último produto, para quando cadastrar um novo armazenar com o código correto
            for (int i = 0; i < pacientes.Count; i++)
            {
                // Obtém o paciente que está sendo percorrido
                var paciente = pacientes[i];

                // Adicionar o paciente que estava no arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome, paciente.Altura, paciente.Peso, CalcularImc(paciente.Peso, paciente.Altura)
                });
                // Rotina para descobrir o paciente com o maior código
                if (paciente.Codigo != int.MinValue)
                    maiorCodigo = paciente.Codigo;
            }
            // Validar se conseguiu encontrar algum código, caso contrário n deve atualizar o código do novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;
        }
        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}