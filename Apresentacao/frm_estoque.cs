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
    public partial class frm_estoque : Form
    {
        int qtdeAnterior;
        int codproduto;

        public frm_estoque()
        {
            InitializeComponent();
            dgvEstoque.AutoGenerateColumns = false;
            dgvEntrada.AutoGenerateColumns = false;
        }

        private void carregaGrid()
        {
            cls_entradaNegocio estoqueNegocio = new cls_entradaNegocio();
            cls_entradaColecao entradaColecao = new cls_entradaColecao();

            entradaColecao = estoqueNegocio.EntradaCompleto();

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = entradaColecao;

            dgvEstoque.Update();
            dgvEstoque.Refresh();

            if (dgvEstoque.Rows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                dtpDataRecebFiltro.Enabled = false;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.Text == "Adicionar")
            {
                dgvEntrada.Rows.Add(txtCodProduto.Text, txtProduto.Text, dtpDataVenc.Text, txtQtde.Text, txtValorTotal.Text, txtTipo.Text, dtpDataReceb.Text);
                limpa_campos();
            }
            else
            {
                int qtdeProduto, qtdeDiferenca;

                cls_entrada entrada = new cls_entrada();
                cls_produto produto = new cls_produto();
                cls_entradaNegocio entradaNegocio = new cls_entradaNegocio();
                cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                entrada.Codigo = Convert.ToInt32(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[5].Value);
                entrada.Cod_Produto = Convert.ToInt32(txtCodProduto.Text);
                entrada.Qtde = Convert.ToInt32(txtQtde.Text);
                entrada.DataEntrada = Convert.ToDateTime(dtpDataReceb.Text);
                entrada.Tipo = Convert.ToString(txtTipo.Text);
                entrada.DataVencimento = Convert.ToDateTime(dtpDataVenc.Text);
                entrada.ValorTotal = Convert.ToDouble(txtValorTotal.Text.Replace("R$", ""));

                if (entrada.Cod_Produto == codproduto)
                {
                    string result = entradaNegocio.Alterar(entrada);

                    produtoColecao = produtoNegocio.TrazerQuantidade(produto.Codigo = Convert.ToInt32(txtCodProduto.Text));
                    qtdeProduto = produtoColecao[0].QtdeAtual;

                    qtdeDiferenca = (qtdeProduto - qtdeAnterior) + Convert.ToInt32(txtQtde.Text);
                    produto.QtdeAtual = qtdeDiferenca;
                    produtoNegocio.AlterarQtde(produto);

                    MessageBox.Show(result);
                }
                else
                {
                    string result = entradaNegocio.Inserir(entrada);

                    produtoColecao = produtoNegocio.TrazerQuantidade(produto.Codigo = Convert.ToInt32(txtCodProduto.Text));
                    qtdeProduto = produtoColecao[0].QtdeAtual;

                    produto.QtdeAtual = qtdeProduto + entrada.Qtde;
                    //produto.QtdeAtual = qtdeProduto -
                    produtoNegocio.AlterarQtde(produto);

                    MessageBox.Show(result);
                    btnAdicionar.Text = "Adicionar";
                    qtdeAnterior = 0;
                }

                MessageBox.Show("Produto do estoque alterado com Sucesso!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaGrid();
                fecha_campos();
            }
       
        }
        private void limpa_campos()
        {
            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtQtde.Text = "";
            txtTipo.Text = "";
            dtpDataReceb.Value = DateTime.Today.Date;
            dtpDataVenc.Value = DateTime.Today.Date;
            txtValorTotal.Text = "";
            txtCodProduto.Focus();
        }
        private void fecha_campos()
        {
            txtCodProduto.Enabled = false;

            txtQtde.Enabled = false;
            txtTipo.Enabled = false;
            dtpDataReceb.Enabled = false;
            dtpDataVenc.Enabled = false;
            txtValorTotal.Enabled = false;
            btnAdicionar.Enabled = false;

            btnFinaliza.Enabled = false;
            btnCancelar.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            dgvEstoque.Enabled = true;
            dtpDataRecebFiltro.Enabled = true;
            carregaGrid();
        }
        private void abre_campos()
        {
            txtQtde.Enabled = true;
            dtpDataReceb.Enabled = true;
            dtpDataVenc.Enabled = true;
            txtValorTotal.Enabled = true;
            btnFinaliza.Enabled = true;

            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = true;

            dgvEstoque.Enabled = false;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

            dtpDataRecebFiltro.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            abre_campos();
            txtCodProduto.Enabled = true;
            limpa_campos();
        }
        private void frm_estoque_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntrada.Rows.Count != 0)
                {
                    cls_entradaNegocio entradaNegocios = new cls_entradaNegocio();

                    for (int t = 0; t < dgvEntrada.Rows.Count; t++)
                    {
                        cls_entrada entrada = new cls_entrada();

                        entrada.Cod_Produto = Convert.ToInt32(dgvEntrada.Rows[t].Cells[0].Value);
                        entrada.DataEntrada = Convert.ToDateTime(dgvEntrada.Rows[t].Cells[6].Value);
                        entrada.DataVencimento = Convert.ToDateTime(dgvEntrada.Rows[t].Cells[2].Value);
                        entrada.Qtde = Convert.ToInt32(dgvEntrada.Rows[t].Cells[3].Value);
                        entrada.ValorTotal = Convert.ToDouble(dgvEntrada.Rows[t].Cells[4].Value);
                        entradaNegocios.Inserir(entrada);

                        cls_produto produto = new cls_produto();
                        cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                        cls_produtoColecao produtoColecao = new cls_produtoColecao();


                        produto.Codigo = entrada.Cod_Produto;
                        produtoColecao = produtoNegocio.TrazerQuantidade(produto.Codigo);

                        produto.QtdeAtual = produtoColecao[0].QtdeAtual + entrada.Qtde;
                        produtoNegocio.AlterarQtde(produto);
                    }

                    dgvEntrada.Rows.Clear();
                    carregaGrid();
                    fecha_campos();
                }
                else
                {
                    MessageBox.Show("Cadastre aqui os produtos que foram estocados!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            abre_campos();
            btnFinaliza.Enabled = false;
            qtdeAnterior = Convert.ToInt32(txtQtde.Text);
            codproduto = Convert.ToInt32(txtCodProduto.Text);
            btnAdicionar.Text = "Confirmar";
            txtCodProduto.Enabled = false;
            abre_campos();
            txtQtde.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fecha_campos();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o produto Selecionado na lista abaixo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cls_entrada entrada = new cls_entrada();
                    cls_entradaNegocio entradaNegocio = new cls_entradaNegocio();

                    entrada.Codigo = Convert.ToInt32(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[5].Value);
                    string ent = entradaNegocio.Excluir(entrada);

                    cls_produto produto = new cls_produto();
                    cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                    cls_produtoColecao produtoColecao = new cls_produtoColecao();

                    produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value));
                    qtdeAnterior = produtoColecao[0].QtdeAtual;

                    produto.Codigo = Convert.ToInt32(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value);
                    produto.QtdeAtual = qtdeAnterior - Convert.ToInt32(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[3].Value);

                    produtoNegocio.AlterarQtde(produto);

                    if (ent == "0")
                    {
                        MessageBox.Show("Entrada do produto excluído e produto Atualizado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        carregaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exclusão não finalizada. Aviso: " + ex.Message, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvEstoque_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstoque.Rows.Count != 0)
            {
                txtCodProduto.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString();
                txtProduto.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[1].Value.ToString();
                dtpDataReceb.Value = Convert.ToDateTime(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[2].Value);
                dtpDataVenc.Value = Convert.ToDateTime(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[4].Value);
                txtQtde.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[3].Value.ToString();
                txtTipo.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[6].Value.ToString();
                txtValorTotal.Text = string.Format("{0:C}", dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[7].Value);
            }
            else
            {
                limpa_campos();
            }
     
        }
        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                if (e.KeyChar == 13)
                {
                    if (txtCodProduto.Text != "")
                    {
                        cls_produto produto = new cls_produto();
                        cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                        cls_produtoColecao produtoColecao = new cls_produtoColecao();

                        produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));
                        try
                        {
                            produto.Codigo = produtoColecao[0].Codigo;
                            produto.Nome = produtoColecao[0].Nome;
txtTipo.Text = produtoColecao[0].TipoUnidade;

                            txtProduto.Text = produto.Nome;
                            
                            txtQtde.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Produto não existe, cadastre antes no formulário de Produtos. Aviso: " + ex.Message, "Produto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodProduto.Text = "";
                            txtCodProduto.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo Vazio, digite o código de um produto existente", "Cadastro de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodProduto.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o Produto. Digite Novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodProduto.Focus();
            }

        }
        private void dtpDataRecebFiltro_ValueChanged(object sender, EventArgs e)
        {
            cls_entradaNegocio estoqueNegocio = new cls_entradaNegocio();
            cls_entradaColecao entradaColecao = new cls_entradaColecao();

            entradaColecao = estoqueNegocio.VerificarporData(dtpDataRecebFiltro.Value);

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = entradaColecao;

            dgvEstoque.Update();
            dgvEstoque.Refresh();

            if(dgvEstoque.Rows.Count == 0)
            {
                limpa_campos();
            }
        }
        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == 13)
            {
                btnAdicionar.Focus();
            }
        }
        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                if (e.KeyChar == 13)
                {
                    dtpDataReceb.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar o produto. Digite novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQtde.Focus();
            }
        }
        private void dtpDataReceb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpDataVenc.Focus();
            }
        }
        private void dtpDataVenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtValorTotal.Focus();
            }
        }
        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != "")
            {
                cls_produto produto = new cls_produto();
                cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));
                try
                {
                    produto.Codigo = produtoColecao[0].Codigo;
                    produto.Nome = produtoColecao[0].Nome;
                    txtTipo.Text = produtoColecao[0].TipoUnidade;

                    txtProduto.Text = produto.Nome;

                    txtQtde.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Produto não existe, cadastre antes no formulário de Produtos. Aviso: " + ex.Message, "Produto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodProduto.Text = "";
                    txtCodProduto.Focus();
                }
            }
        }

        private void frm_estoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
