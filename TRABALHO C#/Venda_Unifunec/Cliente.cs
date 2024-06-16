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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.venda_UnifunecDataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.venda_UnifunecDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.venda_UnifunecDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.venda_UnifunecDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.venda_UnifunecDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.venda_UnifunecDataSet.sexo);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.venda_UnifunecDataSet.cliente);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Novo Cliente?", "Adicionar Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Cliente Selecionado?", "Apagar Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBindingSource.RemoveCurrent();

                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Cliente?", "Salvar Cliente",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)clienteBindingSource.Current;

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

        private void Carregar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                fotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
                

            
        }
    }
}
