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
    public partial class ItensAcessoLogin : Form
    {
        public ItensAcessoLogin()
        {
            InitializeComponent();
        }

        private void ItensAcessoLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.venda_UnifunecDataSet.login);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.acessoTableAdapter.Fill(this.venda_UnifunecDataSet.acesso);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.itensacessologin'. Você pode movê-la ou removê-la conforme necessário.
            this.itensacessologinTableAdapter.Fill(this.venda_UnifunecDataSet.itensacessologin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Itens-Acesso-Login?", "Adicionar Itens-Acesso-Login",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itensacessologinBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Itens-Acesso-Login Selecionado?", "Apagar Itens-Acesso-Login",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itensacessologinBindingSource.RemoveCurrent();

                itensacessologinBindingSource.EndEdit();
                itensacessologinTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Itens-Acesso-Login?", "Salvar Itens-Acesso-Login",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itensacessologinBindingSource.EndEdit();
                itensacessologinTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)itensacessologinBindingSource.Current;

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
