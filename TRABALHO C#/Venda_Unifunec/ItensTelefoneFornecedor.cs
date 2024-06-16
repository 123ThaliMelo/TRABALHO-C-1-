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
    public partial class ItensTelefoneFornecedor : Form
    {
        public ItensTelefoneFornecedor()
        {
            InitializeComponent();
        }

        private void ItensTelefoneFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.venda_UnifunecDataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.venda_UnifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itenstelefonefornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonefornecedorTableAdapter.Fill(this.venda_UnifunecDataSet.itenstelefonefornecedor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Telefone-Fornecedor?", "Adicionar Itens-Telefone-Fornecedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefornecedorBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Telefone-Fornecedor Selecionado?", "Apagar Itens-Telefone-Fornecedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefornecedorBindingSource.RemoveCurrent();

                itenstelefonefornecedorBindingSource.EndEdit();
                itenstelefonefornecedorTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Telefone-Fornecedor?", "Salvar Itens-Telefone-Fornecedor",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefornecedorBindingSource.EndEdit();
                itenstelefonefornecedorTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itenstelefonefornecedorBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itenstelefonefornecedorBindingSource.Current;

            if (currentRowView != null)
            {
                // Obter o DataRow associado
                DataRow currentRow = currentRowView.Row;

                // Carregar os dados nos controles de edição
                // Codigo.Text = currentRow["Codigo"].ToString();
                // Sexo2.Text = currentRow["Sexo"].ToString();


                // Habilitar os controles de edição (caso estejam desabilitados)
                // Sexo2.Enabled = true;
                //Codigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para editar.");
            }
        }

    }
}
