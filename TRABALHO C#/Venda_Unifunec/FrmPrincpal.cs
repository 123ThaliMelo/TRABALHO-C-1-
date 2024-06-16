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
    public partial class FrmPrincpal : Form
    {
        public FrmPrincpal()
        {
            InitializeComponent();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sexo sexo = new Sexo();
            sexo.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja sair da Aplicação?","Vendas Unifunec",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void ruaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Rua rua = new Rua();
            rua.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bairro bairro = new Bairro();
            bairro.ShowDialog();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cep cep = new Cep();    
            cep.ShowDialog();
        }

        private void ufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uf uf = new Uf();   
            uf.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade();
            cidade.ShowDialog();
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabalho trabalho = new Trabalho();
            trabalho.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void operadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operadora operadora = new Operadora();
            operadora.ShowDialog();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefone telefone = new Telefone();
            telefone.ShowDialog();
        }

        private void itensTelefoneClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensTelefoneCliente itensTelefoneCliente = new ItensTelefoneCliente();
            itensTelefoneCliente.ShowDialog();
        }

        private void itensTelefoneTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensTelefoneTrabalho itensTelefoneTrabalho = new ItensTelefoneTrabalho();
            itensTelefoneTrabalho.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Função função = new Função();
            função.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.ShowDialog(); 
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.ShowDialog();
        }

        private void itensTelefoneFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensTelefoneFuncionario itensTelefoneFuncionario = new ItensTelefoneFuncionario();
            itensTelefoneFuncionario.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void controleLogSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleLogSistema controleLogSistema = new ControleLogSistema();
            controleLogSistema.ShowDialog();
        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();   
            acesso.ShowDialog();
        }

        private void itensAcessoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensAcessoLogin itensAcessoLogin = new ItensAcessoLogin();
            itensAcessoLogin.ShowDialog();
        }

        private void itensTelefoneLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensTelefoneLoja itensTelefoneLoja = new ItensTelefoneLoja();
            itensTelefoneLoja.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.ShowDialog();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ShowDialog();
        }

        private void imagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagens imagens = new Imagens();
            imagens.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ShowDialog();
        }

        private void itensTelefoneFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensTelefoneFornecedor itensTelefoneFornecedor = new ItensTelefoneFornecedor();
            itensTelefoneFornecedor.ShowDialog();
        }

        private void compraProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraProduto compraProduto = new CompraProduto();
            compraProduto.ShowDialog();
        }

        private void itensCompraProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensCompraProduto itensCompraProduto = new ItensCompraProduto();
            itensCompraProduto.ShowDialog();
        }

        private void situacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Situação situação = new Situação();
            situação.ShowDialog();
        }

        private void parcelaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcelaCompra parcelaCompra = new ParcelaCompra();
            parcelaCompra.ShowDialog();
        }
    }
}
