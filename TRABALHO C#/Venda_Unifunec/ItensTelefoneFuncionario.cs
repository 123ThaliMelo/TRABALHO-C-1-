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
    public partial class ItensTelefoneFuncionario : Form
    {
        public ItensTelefoneFuncionario()
        {
            InitializeComponent();
        }

        private void ItensTelefoneFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.venda_UnifunecDataSet.funcionario);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.venda_UnifunecDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itenstelefonefuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonefuncionarioTableAdapter.Fill(this.venda_UnifunecDataSet.itenstelefonefuncionario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Telefone-Funcionario?", "Adicionar Itens-Telefone-Funcionario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefuncionarioBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Telefone-Funcionario Selecionado?", "Apagar Itens-Telefone-Funcionario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefuncionarioBindingSource.RemoveCurrent();

                itenstelefonefuncionarioBindingSource.EndEdit();
                itenstelefonefuncionarioTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Telefone-Funcionario?", "Salvar Itens-Telefone-Funcionario",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefuncionarioBindingSource.EndEdit();
                itenstelefonefuncionarioTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itenstelefonefuncionarioBindingSource.Current;

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
