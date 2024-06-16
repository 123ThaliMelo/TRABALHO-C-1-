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
    public partial class ParcelaCompra : Form
    {
        public ParcelaCompra()
        {
            InitializeComponent();
        }

        private void ParcelaCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.venda_UnifunecDataSet.situacao);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.compraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.compraprodutoTableAdapter.Fill(this.venda_UnifunecDataSet.compraproduto);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.parcelacompra'. Você pode movê-la ou removê-la conforme necessário.
            this.parcelacompraTableAdapter.Fill(this.venda_UnifunecDataSet.parcelacompra);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Uma Nova Parcela-Compra?", "Adicionar Parcela-Compra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                parcelacompraBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Parcela-Compra Selecionada?", "Apagar Parcela-Compra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                parcelacompraBindingSource.RemoveCurrent();

                parcelacompraBindingSource.EndEdit();
                parcelacompraTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Nova Parcela-Compra?", "Salvar Parcela-Compra",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                parcelacompraBindingSource.EndEdit();
                parcelacompraTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            parcelacompraBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)parcelacompraBindingSource.Current;

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
