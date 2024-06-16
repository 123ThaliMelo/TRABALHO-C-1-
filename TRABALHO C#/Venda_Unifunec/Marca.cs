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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.venda_UnifunecDataSet.marca);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Uma Nova Marca?", "Adicionar Marca",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Marca Selecionada?", "Apagar Marca",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaBindingSource.RemoveCurrent();

                marcaBindingSource.EndEdit();
                marcaTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Nova Marca?", "Salvar Marca",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaBindingSource.EndEdit();
                marcaTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            marcaBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)marcaBindingSource.Current;

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
