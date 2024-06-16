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
    public partial class ItensTelefoneCliente : Form
    {
        public ItensTelefoneCliente()
        {
            InitializeComponent();
        }

        private void ItensTelefoneCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.venda_UnifunecDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.venda_UnifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itenstelefonecliente'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefoneclienteTableAdapter.Fill(this.venda_UnifunecDataSet.itenstelefonecliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Telefone-Cliente?", "Adicionar Itens-Telefone-Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefoneclienteBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Telefone-Cliente Selecionado?", "Apagar Itens-Telefone-Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefoneclienteBindingSource.RemoveCurrent();

                itenstelefoneclienteBindingSource.EndEdit();
                itenstelefoneclienteTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Telefone-Cliente?", "Salvar Itens-Telefone-Cliente",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefoneclienteBindingSource.EndEdit();
                itenstelefoneclienteTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itenstelefoneclienteBindingSource.Current;

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
