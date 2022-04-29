using SibEscalas.Dominio.Extensions;
using SibEscalas.Dominio.Models;
using SibEscalas.Dominio.Servico;
using System;
using System.ComponentModel;
using System.Security;
using System.Windows.Forms;

namespace SibEscalas
{
    public partial class SibEscalas : Form
    {
        private Store Store { get; set; }
        public SibEscalas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Store = new Store();
            IniciarGridFuncoes();
            IniciarGridPessoas();
        }
        private void IniciarGridFuncoes()
        {
            Store.Funcoes = new BindingList<Funcao>();
            GridFuncoes.DataSource = Store.Funcoes;
            GridFuncoes.Columns[0].Visible = false;
            GridFuncoes.Columns[1].Width = GridFuncoes.Width - 3;
            GridFuncoes.RowHeadersVisible = GridFuncoes.ColumnHeadersVisible = false;
        }

        private void IniciarGridPessoas()
        {
            Store.Pessoas = new BindingList<Pessoa>();
            GridPessoas.DataSource = Store.Pessoas;
            GridPessoas.Columns[0].Visible = GridPessoas.Columns[2].Visible = false;
            GridPessoas.Columns[1].Width = GridPessoas.Width - 3;
            GridPessoas.RowHeadersVisible = GridPessoas.ColumnHeadersVisible = false;
        }

        private void InserirFuncaoButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FuncaoTextBox.Text))
            {
                Store.Funcoes.Add(new Funcao { Descricao = FuncaoTextBox.Text, Id = Guid.NewGuid() });
                FuncaoTextBox.Text = "";
            }
        }

        private void RemoverFuncaoButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in GridFuncoes.SelectedRows)
            {
                Funcao funcao = item.DataBoundItem as Funcao;
                Store.Funcoes.Remove(funcao);
            }
        }

        private void InserirPessoaButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(PessoaTexBox.Text))
            {
                Store.Pessoas.Add(new Pessoa { Nome = PessoaTexBox.Text, Id = Guid.NewGuid() });
                PessoaTexBox.Text = "";
            }
        }

        private void RemoverPessoaButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in GridPessoas.SelectedRows)
            {
                Pessoa pessoa = item.DataBoundItem as Pessoa;
                Store.Pessoas.Remove(pessoa);
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
                ArquivoServico.SalvarArquivo(fileDialog, Store);
        }

        private void AbrirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Store.AtualizarStore(ArquivoServico.AbrirArquivo(fileDialog));
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
