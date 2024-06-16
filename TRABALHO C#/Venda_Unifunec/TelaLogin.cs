using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Unifunec
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.venda_UnifunecDataSet);

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'venda_UnifunecDataSet.login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.venda_UnifunecDataSet.login);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            

    

             loginTableAdapter.FillByloginsenha(venda_UnifunecDataSet.login,txtusuario.Text,txtsenha.Text+"%");

            //if ()
            //{
            //    FrmPrincpal frmPrincpal = new FrmPrincpal();
            //    frmPrincpal.ShowDialog();
           // }

           
            

            


        }



    }
}
