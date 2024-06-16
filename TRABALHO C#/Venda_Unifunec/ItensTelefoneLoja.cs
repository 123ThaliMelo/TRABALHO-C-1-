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
    public partial class ItensTelefoneLoja : Form
    {
        public ItensTelefoneLoja()
        {
            InitializeComponent();
        }

        private void ItensTelefoneLoja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.venda_UnifunecDataSet.loja);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.venda_UnifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itenstelefoneloja'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonelojaTableAdapter.Fill(this.venda_UnifunecDataSet.itenstelefoneloja);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Telefone-Loja?", "Adicionar Itens-Telefone-Loja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonelojaBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Telefone-Loja Selecionado?", "Apagar Itens-Telefone-Loja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonelojaBindingSource.RemoveCurrent();

                itenstelefonelojaBindingSource.EndEdit();
                itenstelefonelojaTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Telefone-Loja?", "Salvar Itens-Telefone-Loja",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonelojaBindingSource.EndEdit();
                itenstelefonelojaTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itenstelefonelojaBindingSource.Current;

            if (currentRowView != null)
            {
                // Obter o DataRow associado
                DataRow currentRow = currentRowView.Row;

                // Carregar os dados nos controles de edição
               // Codigo.Text = currentRow["Codigo"].ToString();
                //Sexo2.Text = currentRow["Sexo"].ToString();


                // Habilitar os controles de edição (caso estejam desabilitados)
                //Sexo2.Enabled = true;
                //Codigo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para editar.");
            }
        }

    }
}
