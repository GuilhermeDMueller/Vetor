using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListaForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;
        public TipoPersonagemListaForm()
        {
            InitializeComponent();

            // Instanciando objeto da classe TipoPersonagemService para permitir:
            // - Listar todos
            // - Editar
            // - Apagar
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListaForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistroDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoFrom();
            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }

        private void AtualizarRegistroDataGridView()
        {
            // Obter todos os tipos de personagens cadastrados na tabela
            // tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // removido todos os registros do DataGridView1
            dataGridView1.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para
            // adicionar no DataGridView1 permitindo o usuário visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                // https://www.invertexto.com/fsens
                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistroDataGridView();

            MessageBox.Show("Registro apagdo com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum tipo de personagem");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            // Obter a linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o id da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter do banco de dados o tipo de personagem selecionado
            var tipoPersonagem = tipoPersonagemService.ObterPorId(id);
            // Instanciando objeto do Form para permitir ediçãopassando o tipo personagem, que permitirá preencher os campos com os dados do banco de dados
            var tipoPersonagemForm = new TipoPersonagemCadastroEdicaoFrom(tipoPersonagem);
            // Apresentando o form para o usuário
            tipoPersonagemForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }
    }
}