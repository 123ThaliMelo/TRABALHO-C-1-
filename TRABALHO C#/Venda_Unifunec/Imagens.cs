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
    public partial class Imagens : Form
    {
        public Imagens()
        {
            InitializeComponent();
        }

        private void Imagens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.venda_UnifunecDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.imagem'. Você pode movê-la ou removê-la conforme necessário.
            this.imagemTableAdapter.Fill(this.venda_UnifunecDataSet.imagem);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            imagemBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imagemBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imagemBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imagemBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Uma Nova imagem?", "Adicionar imagem",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imagemBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar imagem Selecionada?", "Apagar imagem",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imagemBindingSource.RemoveCurrent();

                imagemBindingSource.EndEdit();
                imagemTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Nova imagem?", "Salvar imagem",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imagemBindingSource.EndEdit();
                imagemTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            imagemBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)imagemBindingSource.Current;

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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
