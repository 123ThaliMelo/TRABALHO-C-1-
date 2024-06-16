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
    public partial class Uf : Form
    {
        public Uf()
        {
            InitializeComponent();
        }

        private void Uf_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.uf'. Você pode movê-la ou removê-la conforme necessário.
            this.ufTableAdapter.Fill(this.venda_UnifunecDataSet.uf);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ufBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ufBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ufBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ufBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo UF?", "Adicionar UF",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ufBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar UF Selecionado?", "Apagar UF",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ufBindingSource.RemoveCurrent();

                ufBindingSource.EndEdit();
                ufTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo UF?", "Salvar UF",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ufBindingSource.EndEdit();
                ufTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            ufBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)ufBindingSource.Current;

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
