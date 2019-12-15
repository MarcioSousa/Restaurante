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
using System.Drawing.Printing;
using System.IO;

namespace Apresentacao
{
    public partial class frm_caixa : Form
    {
        int qtdeAtual = 0;
        int qtdeAntes = 0;
        int codPedido = 0;

        public frm_caixa()
        {
            InitializeComponent();
        }

        private void salvanoGrid()
        {

            cls_produto produto = new cls_produto();
            cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
            cls_produtoColecao produtoColecao = new cls_produtoColecao();

            produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));

            if (produtoColecao.Count != 0)
            {
                double valorProduto = produtoColecao[0].Valor;
                dgvCaixa.Rows.Add(txtCodProduto.Text, txtProduto.Text.ToUpper(), valorProduto, txtQtde.Text, "", produtoColecao[0].TipoUnidade);
                txtCodProduto.Text = "";
                txtProduto.Text = "";
                txtQtde.Text = "1";
                txtPreco.Text = "";
                btnExcluir.Enabled = true;
                dgvCaixa.Enabled = true;
                txtCodProduto.Focus();
            }
            else
            {
                MessageBox.Show("Produto não existe, digite novamente o Código do Produto.", "Código do produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProduto.Text = "";
                txtCodProduto.Focus();
            }

            calculaValores();

        }
        private void calculaValores()
        {
            decimal total = 0;
            if (dgvCaixa.Rows.Count != 0 && txtQtde.Text != "")
            {

                for (int t = 0; t < dgvCaixa.Rows.Count; t++)
                {
                    total = total + (Convert.ToDecimal(dgvCaixa.Rows[t].Cells[2].Value) * Convert.ToDecimal(dgvCaixa.Rows[t].Cells[3].Value));
                }
            }
            else
            {
                lblValorTotal.Text = string.Format("{0:C2}", total);
            }

            lblValorTotal.Text = string.Format("{0:C}", total);
        }
        private void gravarPedidoBalcao()
        {
            cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();
            cls_pedido pedido = new cls_pedido();

            pedido.Cod_Garcon = 0;
            pedido.Livre = true;
            pedido.NumeroMesa = 0;
            codPedido = Convert.ToInt32(pedidoNegocio.Inserir(pedido));
        }
        private void gravarPedidoProdutoBalcao(int codProd, double valor, int qtde)
        {
            try
            {
                cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();
                cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();

                pedidoProduto.Cod_Pedido = Convert.ToInt32(lblCodigoPedido.Text);
                pedidoProduto.Cod_Produto = codProd;
                pedidoProduto.ValorUnitario = valor;
                pedidoProduto.Qtde = qtde;

                pedidoProdutoNegocio.Inserir(pedidoProduto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Inserir um cadastro novo" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void carregaGrid()
        {
            cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();
            cls_pedidoprodutoColecao pedidoProdutoColecao = new cls_pedidoprodutoColecao();

            pedidoProdutoColecao = pedidoProdutoNegocio.CarregaGridPedido(codPedido);

            for (int t = 0; t < pedidoProdutoColecao.Count; t++)
            {
                dgvCaixa.Rows.Add(pedidoProdutoColecao[t].Cod_Produto, pedidoProdutoColecao[t].Nome, pedidoProdutoColecao[t].ValorUnitario, pedidoProdutoColecao[t].Qtde, pedidoProdutoColecao[t].Cod_PedidoProduto, pedidoProdutoColecao[t].Tipo, pedidoProdutoColecao[t].CodCaixa);
            }
        }
        private void ImprimeB()
        {
            try
            {
                printDocB.PrinterSettings.PrinterName = "HP LaserJet Professional P 1102w";
                printDocB.DocumentName = "Cupom";

                if (!printDocB.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocB.PrintPage += new PrintPageEventHandler(printDocB_PrintPage);
                printDocB.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir a Conta. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ImprimeC()
        {
            try
            {
                printDocC.PrinterSettings.PrinterName = "HP LaserJet Professional P 1102w";
                printDocC.DocumentName = "Cupom";

                if (!printDocC.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocC.PrintPage += new PrintPageEventHandler(printDocC_PrintPage);
                printDocC.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir a Conta. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExcluiCaixa()
        {
            for (int t = 0; t < dgvCaixa.Rows.Count; t++)
            {
                if (dgvCaixa.Rows[t].Cells[6].Value.ToString() != "")
                {
                    cls_caixa caixa = new cls_caixa();
                    cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
                    caixa.Codigo = Convert.ToInt32(dgvCaixa.Rows[t].Cells[6].Value);

                    caixaNegocio.Excluir(caixa);
                    return;
                }
            }
        }
        private void AtualizaEstoque()
        {

            cls_produto produto = new cls_produto();
            cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();

            produto.QtdeAtual = qtdeAtual - Convert.ToInt32(txtQtde.Text);
            produto.Codigo = Convert.ToInt32(txtCodProduto.Text);
            produtoNegocio.AlterarQtde(produto);

            cls_pedidoproduto pedidoproduto = new cls_pedidoproduto();
            cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();

            pedidoproduto.Cod_Pedido = Convert.ToInt32(lblCodigoPedido.Text);
            pedidoproduto.Cod_Produto = Convert.ToInt32(txtCodProduto.Text);
            pedidoproduto.ValorUnitario = Convert.ToDouble(txtPreco.Text);
            pedidoproduto.Qtde = Convert.ToInt32(txtQtde.Text);

            pedidoProdutoNegocio.Inserir(pedidoproduto);

            qtdeAtual = 0;
        }
        private void SubtraiEstoque(int linha)
        {
            try
            {
                cls_produto produto = new cls_produto();
                cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                cls_produtoColecao produtoColecao = new cls_produtoColecao();
                produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(dgvCaixa.Rows[linha].Cells[0].Value));
                produto.QtdeAtual = produtoColecao[0].QtdeAtual - Convert.ToInt32(dgvCaixa.Rows[linha].Cells[3].Value);
                produto.Codigo = Convert.ToInt32(dgvCaixa.Rows[linha].Cells[0].Value);
                produtoNegocio.AlterarQtde(produto);
                qtdeAtual = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Decrementar o Produto. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GravarSaida(int linha)
        {
            cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
            cls_saida saida = new cls_saida();

            saida.Cod_Produto = Convert.ToInt32(dgvCaixa.Rows[linha].Cells[0].Value);
            saida.DataSaida = DateTime.Now;
            saida.Qtde = Convert.ToInt32(dgvCaixa.Rows[linha].Cells[3].Value);

            saidaNegocio.Inserir(saida);
        }

        private void CarregaEstoque()
        {
            cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();
            cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();

            pedidoProduto.Cod_PedidoProduto = Convert.ToInt32(dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[4].Value);
            pedidoProdutoNegocio.Excluir(pedidoProduto);

            cls_produto produto = new cls_produto();
            cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
            cls_produtoColecao produtoColecao = new cls_produtoColecao();

            produto.Codigo = Convert.ToInt32(dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[0].Value);
            produtoColecao = produtoNegocio.TrazerQuantidade(produto.Codigo);

            qtdeAtual = produtoColecao[0].QtdeAtual;

            qtdeAtual = qtdeAtual + Convert.ToInt32(dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[3].Value);

            produtoNegocio.AlterarQtde(produto);
        }
        private void frm_caixa_Load(object sender, EventArgs e)
        {
            lblCodigoPedido.Text = codPedido.ToString();
            if (codPedido != 0)
            {
                carregaGrid();
                calculaValores();
            }
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProduto.Text != "")
                {
                    cls_produto produto = new cls_produto();
                    cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                    cls_produtoColecao produtoColecao = new cls_produtoColecao();

                    produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));

                    if (produtoColecao.Count != 0)
                    {
                        txtProduto.Text = produtoColecao[0].Nome.ToString();
                        txtPreco.Text = string.Format("{0:C}", produtoColecao[0].Valor);
                    }
                    else
                    {
                        txtProduto.Text = "";
                        txtPreco.Text = "";
                        txtQtde.Text = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    salvanoGrid();
                    lblTroco.Text = "R$ 0,00";
                    txtPagam.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    salvanoGrid();
                    lblTroco.Text = "R$ 0,00";
                    txtPagam.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtPagam_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void txtPagam_TextChanged(object sender, EventArgs e)
        {
            double valor = 0;
            double receb = 0;
            double troco = 0;

            try
            {
                if (txtPagam.Text != "")
                {
                    receb = Convert.ToDouble(txtPagam.Text);
                    valor = Convert.ToDouble(lblValorTotal.Text.Replace("R$", ""));
                    troco = receb - valor;
                    if (troco < 0)
                    {
                        lblTroco.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        lblTroco.ForeColor = Color.White;
                    }

                    lblTroco.Text = string.Format("{0:C}", troco);
                }
                else
                {
                    lblTroco.Text = "R$ 0,00";
                    lblTroco.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Valor Inválido, digite novamente", "Recebimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPagam.Text = "";
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                bool passouB = false;
                bool passouC = false;

                if (dgvCaixa.Rows.Count != 0)
                {
                    gravarPedidoBalcao();
                    for (int t = 0; t < dgvCaixa.Rows.Count; t++)
                    {
                        if (dgvCaixa.Rows[t].Cells[5].Value.ToString() == "B" && passouB == false)
                        {
                            ImprimeB();
                            passouB = true;
                        }

                        if (dgvCaixa.Rows[t].Cells[5].Value.ToString() == "C" && passouC == false)
                        {
                            ImprimeC();
                            passouC = true;
                        }
                        if (passouB == true && passouC == true)
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível fazer a Impressão!", "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void printDocB_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 17f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString("Balc. Pedido " + codPedido, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("---- PEDIDO FEITO PELO BALCAO ----------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                ", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvCaixa.Rows.Count; t++)
            {
                if (dgvCaixa.Rows[t].Cells[5].Value.ToString() == "B")
                {
                    e.Graphics.DrawString("   " + dgvCaixa.Rows[t].Cells[3].Value.ToString() + "  " + dgvCaixa.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                    size = e.Graphics.MeasureString("Pedidos", pdvFont);
                    currentUsedHeight += size.Height;
                }
            }

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("                    " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }
        private void printDocC_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 17f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString("Balcão Pedido  " + codPedido, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("---- PEDIDO FEITO PELO BALCAO ----------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                ", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvCaixa.Rows.Count; t++)
            {
                if (dgvCaixa.Rows[t].Cells[5].Value.ToString() == "C")
                {
                    e.Graphics.DrawString("   " + dgvCaixa.Rows[t].Cells[3].Value.ToString() + "  " + dgvCaixa.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                    size = e.Graphics.MeasureString("Pedidos", pdvFont);
                    currentUsedHeight += size.Height;
                }
            }

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("                    " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if(txtPagam.Text == "")
            {
                if(dgvCaixa.Rows.Count == 0)
                {
                    MessageBox.Show("Coloque o código do produto no primeiro campo.", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodProduto.Focus();
                    return;
                }
                MessageBox.Show("Digite o valor de pagamento.", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPagam.Text = "";
                return;
            }
            try
            {
                if (dgvCaixa.Rows.Count != 0)
                {
                    cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
                    cls_caixa caixa = new cls_caixa();


                    gravarPedidoBalcao();

                    for (int t = 0; t < dgvCaixa.Rows.Count; t++)
                    {
                        gravarPedidoProdutoBalcao(Convert.ToInt32(dgvCaixa.Rows[t].Cells[0].Value), Convert.ToDouble(dgvCaixa.Rows[t].Cells[2].Value), Convert.ToInt32(dgvCaixa.Rows[t].Cells[3].Value));
                        SubtraiEstoque(t);
                        GravarSaida(t);
                    }

                    caixa.Cod_Pedido = codPedido;
                    caixa.ValorTotal = Convert.ToDouble(lblValorTotal.Text.Replace("R$", ""));
                    caixa.DataPagamento = dtpPagam.Value;
                    caixa.Troco = Convert.ToDouble(lblTroco.Text.Replace("R$", ""));
                    caixa.ValorGarcon = 0;
                    caixaNegocio.Inserir(caixa);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Mensagem: " + ex.Message, "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCaixa.Rows.Count != 0)
            {
                if (MessageBox.Show("Deseja alterar a qtde do pedido selecionado?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtCodProduto.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = true;
                    dgvCaixa.Enabled = false;
                    CarregaEstoque();
                    txtCodProduto.Text = dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[0].Value.ToString();
                    txtProduto.Text = dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[1].Value.ToString();
                    txtQtde.Text = dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[3].Value.ToString();
                    qtdeAntes = Convert.ToInt32(dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[3].Value);
                    txtPreco.Text = string.Format("{0:C}", dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[2].Value);
                    dgvCaixa.Rows.RemoveAt(dgvCaixa.CurrentRow.Index);
                    txtQtde.Focus();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCaixa.Rows.Count != 0)
            {
                if (MessageBox.Show("Deseja excluir a qtde do pedido selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells[4].Value.ToString() != "")
                    {
                        CarregaEstoque();
                        dgvCaixa.Rows.RemoveAt(dgvCaixa.CurrentRow.Index);
                    }
                    else
                    {
                        dgvCaixa.Rows.RemoveAt(dgvCaixa.CurrentRow.Index);
                    }
                    calculaValores();
                }
                else
                {
                    MessageBox.Show("Não há linhas para serem deletadas", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não tem nenhum pedido registrado para ser excluidos", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCodProduto.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Será cancelado a atualização de agora, deseja continuar?", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AtualizaEstoque();
                dgvCaixa.Rows.Clear();
                carregaGrid();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_caixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}