using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Unifunec
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.venda_UnifunecDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.venda_UnifunecDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.venda_UnifunecDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.venda_UnifunecDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.venda_UnifunecDataSet.fornecedor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Fornecedor?", "Adicionar Fornecedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Fornecedor Selecionado?", "Apagar Fornecedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorBindingSource.RemoveCurrent();

                fornecedorBindingSource.EndEdit();
                fornecedorTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Fornecedor?", "Salvar Fornecedor",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorBindingSource.EndEdit();
                fornecedorTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)fornecedorBindingSource.Current;

            if (currentRowView != null)
            {
                // Obter o DataRow associado
                DataRow currentRow = currentRowView.Row;

                // Carregar os dados nos controles de edição
                Codigo.Text = currentRow["Codigo"].ToString();
               // Sexo2.Text = currentRow["Sexo"].ToString();


                // Habilitar os controles de edição (caso estejam desabilitados)
               // Sexo2.Enabled = true;
                Codigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para editar.");
            }
        }

    }
}
