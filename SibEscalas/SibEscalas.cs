using SibEscalas.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibEscalas
{
    public partial class SibEscalas : Form
    {
        private BindingList<Funcao> Funcoes { get; set; }
        private BindingList<Pessoa> Pessoas { get; set; }
        public SibEscalas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FolderBrowserDialog folderDalog = new FolderBrowserDialog();
            //folderDalog.ShowDialog();
            IniciarGridFuncoes();
            IniciarGridPessoas();
        }
        private void IniciarGridFuncoes()
        {
            Funcoes = new BindingList<Funcao>();
            GridFuncoes.DataSource = Funcoes;
            GridFuncoes.Columns[0].Visible = false;
            GridFuncoes.Columns[1].Width = GridFuncoes.Width - 3;
            GridFuncoes.RowHeadersVisible = GridFuncoes.ColumnHeadersVisible = false;
        }

        private void IniciarGridPessoas()
        {
            Pessoas = new BindingList<Pessoa>();
            GridPessoas.DataSource = Pessoas;
            GridPessoas.Columns[0].Visible = GridPessoas.Columns[2].Visible = false;
            GridPessoas.Columns[1].Width = GridPessoas.Width - 3;
            GridPessoas.RowHeadersVisible = GridPessoas.ColumnHeadersVisible = false;
        }

        private void InserirFuncaoButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FuncaoTextBox.Text))
            {
                Funcoes.Add(new Funcao { Descricao = FuncaoTextBox.Text, Id = Guid.NewGuid() });
                FuncaoTextBox.Text = "";
            }
        }

        private void RemoverFuncaoButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in GridFuncoes.SelectedRows)
            {
                Funcao funcao = item.DataBoundItem as Funcao;
                Funcoes.Remove(funcao);
            }
        }

        private void InserirPessoaButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(PessoaTexBox.Text))
            {
                Pessoas.Add(new Pessoa { Nome = PessoaTexBox.Text, Id = Guid.NewGuid() });
                PessoaTexBox.Text = "";
            }
        }

        private void RemoverPessoaButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in GridPessoas.SelectedRows)
            {
                Pessoa pessoa = item.DataBoundItem as Pessoa;
                Pessoas.Remove(pessoa);
            }
        }
    }
}
