using System;
using System.Data;
using System.Windows.Forms;

namespace Venda_Unifunec
{
    public partial class ControleLogSistema : Form
    {
        public ControleLogSistema()
        {
            InitializeComponent();
        }

        private void ControleLogSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.venda_UnifunecDataSet.login);
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.controlelogsistema'. Você pode movê-la ou removê-la conforme necessário.
            this.controlelogsistemaTableAdapter.Fill(this.venda_UnifunecDataSet.controlelogsistema);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MoveNext();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Adicinar Um Novo Controle-log-sistema?", "Adicionar Controle-log-sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlelogsistemaBindingSource.AddNew();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar Controle-log-sistema Selecionado?", "Apagar Controle-log-sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlelogsistemaBindingSource.RemoveCurrent();

                controlelogsistemaBindingSource.EndEdit();
                controlelogsistemaTableAdapter.Update(venda_UnifunecDataSet);
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar Novo Controle-log-sistema?", "Salvar Controle-log-sistema",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlelogsistemaBindingSource.EndEdit();
                controlelogsistemaTableAdapter.Update(venda_UnifunecDataSet);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            // Obter o item selecionado no BindingSource
            DataRowView currentRowView = (DataRowView)controlelogsistemaBindingSource.Current;

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
