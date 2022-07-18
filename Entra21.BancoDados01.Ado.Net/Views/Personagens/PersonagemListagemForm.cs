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

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {
        // Definindo como readonly será permitdo a criação da instância somente no construtor
        private readonly PersonagemService _personagemService;

        // AQUI fica o construtor: tem como objetivo construir o objeto com propriedades
        // necessárias e execução de metódos obrigatórios, ou seja, neste cenário desenhar a tela e instanciar o objeto
        // do serviço que permitirá gerenciar os dados referentes ao personagem
        public PersonagemListagemForm()
        {
            InitializeComponent();

            _personagemService = new PersonagemService();

            PreencherDataGridViewComPersonagem();
        }

        private void PreencherDataGridViewComPersonagem()
        {
            var personagens = _personagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int indice = 0; indice < personagens.Count; indice++)
            {
                var personagem = personagens[indice];

                dataGridView1.Rows.Add(new object[]
                {
                    personagem.Id,
                    personagem.Nome,
                    personagem.TipoPersonagem.Tipo,
                    personagem.Editora.Nome
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemCadastroEdicaoForm();
            personagemForm.ShowDialog();

            PreencherDataGridViewComPersonagem();
        }
    }
}
