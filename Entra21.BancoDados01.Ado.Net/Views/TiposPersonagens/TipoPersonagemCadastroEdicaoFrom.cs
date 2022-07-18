using Entra21.BancoDados01.Ado.Net.Models;
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
    public partial class TipoPersonagemCadastroEdicaoFrom : Form
    {
        // Armazenar o id do tipo do personagem para permitir a edição
        private int idEdicao = -1;
        public TipoPersonagemCadastroEdicaoFrom()
        {
            InitializeComponent();
        }

        public TipoPersonagemCadastroEdicaoFrom(TipoPersonagem tipoPersonagem) : this()
        {
            // Definidoo valor do idEdicao para posteriormente saber qual registro deve ser apagado
            idEdicao = tipoPersonagem.Id;

            // Preenchido o campo com o tipo com o valor do banco de dados
            textBoxTipo.Text = tipoPersonagem.Tipo;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBoxTipo.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            // Instanciar do objeto do TipoPersonagemService que permitirá
            // persistir o registro
            var tipoPersonagemService = new TipoPersonagemService();

            // Verficar se está em modo de cadastro
            if(idEdicao == -1)
            {
                // Persistir a informaçãona tabela de tipos_personagens
                tipoPersonagemService.Cadastrar(tipoPersonagem);

                MessageBox.Show("Tipo de personagem cadastrado com sucesso");

                Close();

                return;
            }

            tipoPersonagem.Id = idEdicao;
            // Atualizar a informação na tabela de tipos_personagens
            tipoPersonagemService.Editar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem alterado com sucesso!!!");

            Close();
        }
    }
}