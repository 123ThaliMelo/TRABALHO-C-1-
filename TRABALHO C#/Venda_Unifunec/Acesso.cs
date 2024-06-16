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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.acessoTableAdapter.Fill(this.venda_UnifunecDataSet.acesso);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Cep?", "Adicionar Cep",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acessoBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Cep Selecionado?", "Apagar Cep",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acessoBindingSource.RemoveCurrent();

                acessoBindingSource.EndEdit();
                acessoTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Cep?", "Salvar Cep",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acessoBindingSource.EndEdit();
                acessoTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            acessoBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)acessoBindingSource.Current;

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
