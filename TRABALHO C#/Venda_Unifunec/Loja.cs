﻿using System;
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
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void Loja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.venda_UnifunecDataSet.loja);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Uma Nova Loja?", "Adicionar Loja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Loja Selecionada?", "Apagar Loja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaBindingSource.RemoveCurrent();

                lojaBindingSource.EndEdit();
                lojaTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Nova Loja?", "Salvar Loja",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaBindingSource.EndEdit();
                lojaTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            lojaBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)lojaBindingSource.Current;

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
