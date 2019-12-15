using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_produto produto = new frm_produto();
            produto.ShowDialog();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frm_estoque estoque = new frm_estoque();
            estoque.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frm_saida saida = new frm_saida();
            saida.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frm_caixa caixa = new frm_caixa();
            caixa.ShowDialog();
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            Frm_mesas mesa = new Frm_mesas();
            mesa.ShowDialog();
        }

        private void btnAberFech_Click(object sender, EventArgs e)
        {
            Frm_AbreFechaCaixa abreFechaCaixa = new Frm_AbreFechaCaixa();
            abreFechaCaixa.ShowDialog();
        }

        private void btnResumo_Click(object sender, EventArgs e)
        {
            frm_vendas vendas = new frm_vendas();
            vendas.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produto produto = new frm_produto();
            produto.ShowDialog();
        }

        private void sAIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Sistema?", "Fechar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Focus();
            }
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_estoque estoque = new frm_estoque();
            estoque.ShowDialog();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_saida saida = new frm_saida();
            saida.ShowDialog();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_caixa caixa = new frm_caixa();
            caixa.ShowDialog();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mesas mesas = new Frm_mesas();
            mesas.ShowDialog();
        }

        private void resumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vendas vendas = new frm_vendas();
            vendas.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Sistema?", "Fechar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Focus();
            }
        }
    }
}

            //if (MessageBox.Show("Deseja sair do Sistema?", "Fechar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    this.Focus();
            //}