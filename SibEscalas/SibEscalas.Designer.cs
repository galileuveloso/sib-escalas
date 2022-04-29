
namespace SibEscalas
{
    partial class SibEscalas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.TabFuncoes = new System.Windows.Forms.TabPage();
            this.RemoverFuncaoButton = new System.Windows.Forms.Button();
            this.GridFuncoes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FuncaoTextBox = new System.Windows.Forms.TextBox();
            this.InserirFuncaoButton = new System.Windows.Forms.Button();
            this.TabPessoas = new System.Windows.Forms.TabPage();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.PessoaTexBox = new System.Windows.Forms.TextBox();
            this.RemoverPessoaButton = new System.Windows.Forms.Button();
            this.InserirPessoaButton = new System.Windows.Forms.Button();
            this.GridPessoas = new System.Windows.Forms.DataGridView();
            this.AbrirButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.TabPanel.SuspendLayout();
            this.TabFuncoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncoes)).BeginInit();
            this.TabPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.TabFuncoes);
            this.TabPanel.Controls.Add(this.TabPessoas);
            this.TabPanel.Location = new System.Drawing.Point(26, 56);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(1077, 500);
            this.TabPanel.TabIndex = 0;
            // 
            // TabFuncoes
            // 
            this.TabFuncoes.Controls.Add(this.RemoverFuncaoButton);
            this.TabFuncoes.Controls.Add(this.GridFuncoes);
            this.TabFuncoes.Controls.Add(this.label1);
            this.TabFuncoes.Controls.Add(this.FuncaoTextBox);
            this.TabFuncoes.Controls.Add(this.InserirFuncaoButton);
            this.TabFuncoes.Location = new System.Drawing.Point(4, 25);
            this.TabFuncoes.Name = "TabFuncoes";
            this.TabFuncoes.Padding = new System.Windows.Forms.Padding(3);
            this.TabFuncoes.Size = new System.Drawing.Size(1069, 471);
            this.TabFuncoes.TabIndex = 0;
            this.TabFuncoes.Text = "Funcoes";
            this.TabFuncoes.UseVisualStyleBackColor = true;
            // 
            // RemoverFuncaoButton
            // 
            this.RemoverFuncaoButton.Location = new System.Drawing.Point(295, 304);
            this.RemoverFuncaoButton.Name = "RemoverFuncaoButton";
            this.RemoverFuncaoButton.Size = new System.Drawing.Size(87, 23);
            this.RemoverFuncaoButton.TabIndex = 4;
            this.RemoverFuncaoButton.Text = "Remover";
            this.RemoverFuncaoButton.UseVisualStyleBackColor = true;
            this.RemoverFuncaoButton.Click += new System.EventHandler(this.RemoverFuncaoButton_Click);
            // 
            // GridFuncoes
            // 
            this.GridFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFuncoes.Location = new System.Drawing.Point(32, 85);
            this.GridFuncoes.Name = "GridFuncoes";
            this.GridFuncoes.RowHeadersWidth = 51;
            this.GridFuncoes.RowTemplate.Height = 24;
            this.GridFuncoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFuncoes.Size = new System.Drawing.Size(350, 213);
            this.GridFuncoes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Função:";
            // 
            // FuncaoTextBox
            // 
            this.FuncaoTextBox.Location = new System.Drawing.Point(32, 37);
            this.FuncaoTextBox.Name = "FuncaoTextBox";
            this.FuncaoTextBox.Size = new System.Drawing.Size(256, 22);
            this.FuncaoTextBox.TabIndex = 1;
            // 
            // InserirFuncaoButton
            // 
            this.InserirFuncaoButton.Location = new System.Drawing.Point(294, 37);
            this.InserirFuncaoButton.Name = "InserirFuncaoButton";
            this.InserirFuncaoButton.Size = new System.Drawing.Size(88, 23);
            this.InserirFuncaoButton.TabIndex = 0;
            this.InserirFuncaoButton.Text = "Inserir";
            this.InserirFuncaoButton.UseVisualStyleBackColor = true;
            this.InserirFuncaoButton.Click += new System.EventHandler(this.InserirFuncaoButton_Click);
            // 
            // TabPessoas
            // 
            this.TabPessoas.Controls.Add(this.lblPessoa);
            this.TabPessoas.Controls.Add(this.PessoaTexBox);
            this.TabPessoas.Controls.Add(this.RemoverPessoaButton);
            this.TabPessoas.Controls.Add(this.InserirPessoaButton);
            this.TabPessoas.Controls.Add(this.GridPessoas);
            this.TabPessoas.Location = new System.Drawing.Point(4, 25);
            this.TabPessoas.Name = "TabPessoas";
            this.TabPessoas.Padding = new System.Windows.Forms.Padding(3);
            this.TabPessoas.Size = new System.Drawing.Size(1069, 471);
            this.TabPessoas.TabIndex = 1;
            this.TabPessoas.Text = "Pessoas";
            this.TabPessoas.UseVisualStyleBackColor = true;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(28, 34);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(59, 17);
            this.lblPessoa.TabIndex = 4;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // PessoaTexBox
            // 
            this.PessoaTexBox.Location = new System.Drawing.Point(31, 54);
            this.PessoaTexBox.Name = "PessoaTexBox";
            this.PessoaTexBox.Size = new System.Drawing.Size(251, 22);
            this.PessoaTexBox.TabIndex = 3;
            // 
            // RemoverPessoaButton
            // 
            this.RemoverPessoaButton.Location = new System.Drawing.Point(288, 297);
            this.RemoverPessoaButton.Name = "RemoverPessoaButton";
            this.RemoverPessoaButton.Size = new System.Drawing.Size(79, 23);
            this.RemoverPessoaButton.TabIndex = 2;
            this.RemoverPessoaButton.Text = "Remover";
            this.RemoverPessoaButton.UseVisualStyleBackColor = true;
            this.RemoverPessoaButton.Click += new System.EventHandler(this.RemoverPessoaButton_Click);
            // 
            // InserirPessoaButton
            // 
            this.InserirPessoaButton.Location = new System.Drawing.Point(288, 54);
            this.InserirPessoaButton.Name = "InserirPessoaButton";
            this.InserirPessoaButton.Size = new System.Drawing.Size(83, 23);
            this.InserirPessoaButton.TabIndex = 1;
            this.InserirPessoaButton.Text = "Inserir";
            this.InserirPessoaButton.UseVisualStyleBackColor = true;
            this.InserirPessoaButton.Click += new System.EventHandler(this.InserirPessoaButton_Click);
            // 
            // GridPessoas
            // 
            this.GridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPessoas.Location = new System.Drawing.Point(31, 92);
            this.GridPessoas.Name = "GridPessoas";
            this.GridPessoas.RowHeadersWidth = 51;
            this.GridPessoas.RowTemplate.Height = 24;
            this.GridPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPessoas.Size = new System.Drawing.Size(340, 199);
            this.GridPessoas.TabIndex = 0;
            // 
            // AbrirButton
            // 
            this.AbrirButton.Location = new System.Drawing.Point(26, 12);
            this.AbrirButton.Name = "AbrirButton";
            this.AbrirButton.Size = new System.Drawing.Size(75, 23);
            this.AbrirButton.TabIndex = 1;
            this.AbrirButton.Text = "Abrir";
            this.AbrirButton.UseVisualStyleBackColor = true;
            this.AbrirButton.Click += new System.EventHandler(this.AbrirButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Location = new System.Drawing.Point(107, 12);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(75, 23);
            this.SalvarButton.TabIndex = 2;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // SibEscalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.AbrirButton);
            this.Controls.Add(this.TabPanel);
            this.Name = "SibEscalas";
            this.Text = "Sib Escalas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPanel.ResumeLayout(false);
            this.TabFuncoes.ResumeLayout(false);
            this.TabFuncoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncoes)).EndInit();
            this.TabPessoas.ResumeLayout(false);
            this.TabPessoas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage TabFuncoes;
        private System.Windows.Forms.TabPage TabPessoas;
        private System.Windows.Forms.Button AbrirButton;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FuncaoTextBox;
        private System.Windows.Forms.Button InserirFuncaoButton;
        private System.Windows.Forms.DataGridView GridFuncoes;
        private System.Windows.Forms.Button RemoverFuncaoButton;
        private System.Windows.Forms.TextBox PessoaTexBox;
        private System.Windows.Forms.Button RemoverPessoaButton;
        private System.Windows.Forms.Button InserirPessoaButton;
        private System.Windows.Forms.DataGridView GridPessoas;
        private System.Windows.Forms.Label lblPessoa;
    }
}

