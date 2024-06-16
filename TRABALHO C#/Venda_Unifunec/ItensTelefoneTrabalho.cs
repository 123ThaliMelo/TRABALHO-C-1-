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
    public partial class ItensTelefoneTrabalho : Form
    {
        public ItensTelefoneTrabalho()
        {
            InitializeComponent();
        }

        private void ItensTelefoneTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.venda_UnifunecDataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.venda_UnifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itenstelefonetrabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonetrabalhoTableAdapter.Fill(this.venda_UnifunecDataSet.itenstelefonetrabalho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Telefone-Trabalho?", "Adicionar Itens-Telefone-Trabalho",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonetrabalhoBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Telefone-Trabalho Selecionado?", "Apagar Itens-Telefone-Trabalho",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonetrabalhoBindingSource.RemoveCurrent();

                itenstelefonetrabalhoBindingSource.EndEdit();
                itenstelefonetrabalhoTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Telefone-Trabalho?", "Salvar Itens-Telefone-Trabalho",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonetrabalhoBindingSource.EndEdit();
                itenstelefonetrabalhoTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itenstelefonetrabalhoBindingSource.Current;

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
