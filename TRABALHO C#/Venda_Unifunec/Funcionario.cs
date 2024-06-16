using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venda_Unifunec.Venda_UnifunecDataSetTableAdapters;

namespace Venda_Unifunec
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.funcaoTableAdapter.Fill(this.venda_UnifunecDataSet.funcao);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.venda_UnifunecDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.venda_UnifunecDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.venda_UnifunecDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.venda_UnifunecDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.venda_UnifunecDataSet.loja);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.venda_UnifunecDataSet.funcionario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Novo Funcionario?", "Adicionar Funcionario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionarioBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Funcionario Selecionado?", "Apagar Funcionario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionarioBindingSource.RemoveCurrent();

                funcionarioBindingSource.EndEdit();
                funcionarioTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Funcionario?", "Salvar Funcionario",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionarioBindingSource.EndEdit();
                funcionarioTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)funcionarioBindingSource.Current;

            if (currentRowView != null)
            {
                // Obter o DataRow associado
                DataRow currentRow = currentRowView.Row;

                // Carregar os dados nos controles de edição
                Codigo.Text = currentRow["Codigo"].ToString();
                Sexo2.Text = currentRow["Sexo"].ToString();


                // Habilitar os controles de edição (caso estejam desabilitados)
                Sexo2.Enabled = true;
                Codigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para editar.");
            }
        }

    }
}
