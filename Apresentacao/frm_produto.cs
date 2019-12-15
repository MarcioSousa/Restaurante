using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class frm_produto : Form
    {
        string escolha = "";

        public frm_produto()
        {
            InitializeComponent();
            dgvProduto.AutoGenerateColumns = false;
            dgvEntrada.AutoGenerateColumns = false;

        }
        private void carregaGrid()
        {
            cls_produtoNegocio produtoNegocios = new cls_produtoNegocio();
            cls_produtoColecao produtoColecao = new cls_produtoColecao();

            produtoColecao = produtoNegocios.TodosProduto();

            dgvProduto.DataSource = null;
            dgvProduto.DataSource = produtoColecao;

            dgvProduto.Update();
            dgvProduto.Refresh();

            carregaCampos();
        }
        private void carregaCampos()
        {
            if (dgvProduto.Rows.Count != 0)
            {
                txtCodigo.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[0].Value.ToString();
                txtNome.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[1].Value.ToString();
                txtValor.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[2].Value.ToString();
                txtTipo.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[3].Value.ToString();
                txtQtde.Text = dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[4].Value.ToString();
            }
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                txtCodigo.Text = "";
                txtNome.Text = "";
                txtTipo.Text = "";
                txtValor.Text = "";
                txtQtde.Text = "";
            }
        }
        private void abreTudo()
        {
            dgvProduto.Enabled = false;
            btnAdicionar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNome.ReadOnly = false;
            txtValor.ReadOnly = false;
            txtQtde.ReadOnly = false;
            txtTipo.ReadOnly = false;

            if (escolha == "A")
            {
                txtCodigo.Text = "";
                txtNome.Text = "";
                txtValor.Text = "";
                txtQtde.Text = "";
                txtTipo.Text = "";
            }

            txtNome.Focus();
        }
        private void fechaTudo()
        {
            eP.Clear();

            dgvProduto.Enabled = true;
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNome.ReadOnly = true;
            txtTipo.ReadOnly = true;
            txtQtde.ReadOnly = true;
            txtValor.ReadOnly = true;

            dgvProduto.ReadOnly = true;

            carregaGrid();

            btnAdicionar.Focus();
        }
        private void carregaResumo()
        {

            cls_entradaNegocio entradaNegocio = new cls_entradaNegocio();
            cls_entradaColecao entradaColecao = new cls_entradaColecao();

            entradaColecao = entradaNegocio.HistóricoCadaProduto(Convert.ToInt32(dgvProduto.Rows[dgvProduto.CurrentRow.Index].Cells[0].Value));

            dgvEntrada.DataSource = null;
            dgvEntrada.DataSource = entradaColecao;

            dgvEntrada.Update();
            dgvEntrada.Refresh();
        }

        private void frm_produto_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }
        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            carregaCampos();
            carregaResumo();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            escolha = "A";
            abreTudo();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            escolha = "E";
            abreTudo();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir o Produto Selecionado?", "Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                    cls_produto produto = new cls_produto();

                    produto.Codigo = Convert.ToInt32(txtCodigo.Text);

                    int valor = Convert.ToInt32(produtoNegocio.Excluir(produto));
                    MessageBox.Show("Produto Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregaGrid();
                }
                else
                {
                    MessageBox.Show("Exclusão não Finalizada!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Excluir o Produto Selecionado.");
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txtValor.Text);

                try
                {
                    if (txtNome.Text != "" && txtValor.Text != "")
                    {
                        cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                        cls_produto produto = new cls_produto();

                        produto.Nome = txtNome.Text;
                        produto.Valor = Convert.ToDouble(txtValor.Text);
                        produto.QtdeAtual = Convert.ToInt32(txtQtde.Text);
                        produto.TipoUnidade = Convert.ToString(txtTipo.Text);

                        if (escolha == "A")
                        {
                            produtoNegocio.Inserir(produto);
                            MessageBox.Show("Produto Adicionado com Sucesso.", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            produto.Codigo = Convert.ToInt32(txtCodigo.Text);
                            produtoNegocio.Alterar(produto);
                            MessageBox.Show("Produto Editado com Sucesso", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        escolha = "";
                        fechaTudo();
                    }
                    else
                    {
                        MessageBox.Show("Digite o Nome do produto e o Valor do produto!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    carregaGrid();
                    btnAdicionar.Focus();
                }
                catch (Exception ex)
                {
                    txtValor.Text = "";
                    MessageBox.Show("Não foi possível finalizar o cadastro. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível finalizar o cadastro, verifique o campo Valor. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor.Text = "";
                txtValor.Focus();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            escolha = "";
            fechaTudo();
        }
        private void btnExcluirEnt_Click(object sender, EventArgs e)
        {
            if (dgvEntrada.Rows.Count != 0)
            {
                if (MessageBox.Show("Deseja deletar a Entrada do produto de selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cls_entrada entrada = new cls_entrada();
                    cls_entradaNegocio entradaNegocio = new cls_entradaNegocio();

                    entrada.Codigo = Convert.ToInt32(dgvEntrada.Rows[dgvEntrada.CurrentRow.Index].Cells[0].Value);
                    entradaNegocio.Excluir(entrada);

                    MessageBox.Show("Entrada excluida com Sucesso!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregaResumo();
                }
            }
            else
            {
                MessageBox.Show("Não há produtos a serem Excluidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTipo_Validating(object sender, CancelEventArgs e)
        {
            if (txtTipo.Text != "A" && txtTipo.Text != "B" && txtTipo.Text != "C")
            {
                eP.SetError(txtTipo, "Digite A: Almoxarifado, B: Balcao, C: Cozinha");
                txtTipo.Focus();
                return;
            }
            eP.Clear();
        }
        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if (txtValor.Text == "")
            {
                eP.SetError(txtValor, "Digite o Valor de Venda do produto");
                txtValor.Focus();
                return;
            }
            eP.Clear();
        }
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text == "")
            {
                eP.SetError(txtNome, "Digite o Nome do Produto");
                txtNome.Focus();
                return;
            }
            eP.Clear();
        }
        private void txtQtde_Validating(object sender, CancelEventArgs e)
        {
            if (txtQtde.Text == "")
            {
                eP.SetError(txtQtde, "Digite Qtde Inicial");
                txtQtde.Focus();
                return;
            }
            eP.Clear();
        }

        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if(txtTipo.Text == "A")
            {
                txtQtde.Text = "0";
                txtQtde.Enabled = false;
            }else
            {
                txtQtde.Text = "";
                txtQtde.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_produto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

