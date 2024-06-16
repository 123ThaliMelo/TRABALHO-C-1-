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
    public partial class ItensCompraProduto : Form
    {
        public ItensCompraProduto()
        {
            InitializeComponent();
        }

        private void ItensCompraProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.venda_UnifunecDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.compraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.compraprodutoTableAdapter.Fill(this.venda_UnifunecDataSet.compraproduto);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itenscompraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.itenscompraprodutoTableAdapter.Fill(this.venda_UnifunecDataSet.itenscompraproduto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Compra-Produto?", "Adicionar Itens-Compra-Produto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenscompraprodutoBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Compra-Produto Selecionado?", "Apagar Itens-Compra-Produto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    itenscompraprodutoBindingSource.RemoveCurrent();

                itenscompraprodutoBindingSource.EndEdit();
                itenscompraprodutoTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Compra-Produto?", "Salvar Itens-Compra-Produto",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenscompraprodutoBindingSource.EndEdit();
                itenscompraprodutoTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itenscompraprodutoBindingSource.Current;

            if (currentRowView != null)
            {
                // Obter o DataRow associado
                DataRow currentRow = currentRowView.Row;

                // Carregar os dados nos controles de edição
                // Codigo.Text = currentRow["Codigo"].ToString();
                //  Sexo2.Text = currentRow["Sexo"].ToString();


                // Habilitar os controles de edição (caso estejam desabilitados)
                //  Sexo2.Enabled = true;
                //  Codigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para editar.");
            }
        }

    }
}
