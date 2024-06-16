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
    public partial class CompraProduto : Form
    {
        public CompraProduto()
        {
            InitializeComponent();
        }

        private void CompraProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.venda_UnifunecDataSet.funcionario);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.venda_UnifunecDataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.compraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.compraprodutoTableAdapter.Fill(this.venda_UnifunecDataSet.compraproduto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo  Compra-Produto?", "Adicionar  Compra-Produto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                compraprodutoBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Compra-Produto Selecionado?", "Apagar  Compra-Produto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                compraprodutoBindingSource.RemoveCurrent();

                compraprodutoBindingSource.EndEdit();
                compraprodutoTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo  Compra-Produto?", "Salvar  Compra-Produto",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                compraprodutoBindingSource.EndEdit();
                compraprodutoTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            compraprodutoBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)compraprodutoBindingSource.Current;

            if (currentRowView != null)
            {
                // Obter o DataRow associado
                DataRow currentRow = currentRowView.Row;

                // Carregar os dados nos controles de edição
               // Codigo.Text = currentRow["Codigo"].ToString();
               // Sexo2.Text = currentRow["Sexo"].ToString();


                // Habilitar os controles de edição (caso estejam desabilitados)
               // Sexo2.Enabled = true;
               // Codigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para editar.");
            }
        }

    }
}
