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
    public partial class Operadora : Form
    {
        public Operadora()
        {
            InitializeComponent();
        }

        private void Operadora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.venda_UnifunecDataSet.operadora);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Uma Nova Operadora?", "Adicionar Operadora",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadoraBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Operadora Selecionada?", "Apagar Operadora",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadoraBindingSource.RemoveCurrent();

                operadoraBindingSource.EndEdit();
                operadoraTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Nova Operadora?", "Salvar Operadora",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadoraBindingSource.EndEdit();
                operadoraTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)operadoraBindingSource.Current;

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
