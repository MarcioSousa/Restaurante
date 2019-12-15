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
    public partial class frm_pedido : Form
    {
        //Bitmap captura = null;
        public decimal valorTotalPago;
        Frm_mesas instanciaDoForm;
        decimal valortotal = 0;
        string escolha = "";
        int codpedprod;

        public frm_pedido(Frm_mesas principal, int codmesa, string mesa)
        {
            InitializeComponent();
            instanciaDoForm = principal;
            txtCodMesa.Text = codmesa.ToString();
            txtCodProduto.Focus();

            if (mesa == "ocupado")
            {
                carregarnoInicio(codmesa);
            }
        }
        private void carregarnoInicio(int mesa)
        {
            cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();
            cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();

            pedidoColecao = pedidoNegocio.PedidosMesa(mesa);

            if (pedidoColecao.Count != 0)
            {
                txtCodPedido.Text = pedidoColecao[0].Codigo.ToString();
                txtCodGarcon.Text = pedidoColecao[0].Cod_Garcon.ToString();
                lblValorPago.Text = pedidoColecao[0].ValorPago.ToString("C");
                carregaGridInicio();
            }
        }
        private void carregaGridInicio()
        {
            cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();
            cls_pedidoprodutoColecao pedidoProdutoColecao = new cls_pedidoprodutoColecao();

            pedidoProdutoColecao = pedidoProdutoNegocio.CarregaGridPedido(Convert.ToInt32(txtCodPedido.Text));

            dgvPedido.Rows.Clear();

            for (int t = 0; t < pedidoProdutoColecao.Count; t++)
            {
                dgvPedido.Rows.Add(pedidoProdutoColecao[t].Cod_Produto, pedidoProdutoColecao[t].Nome, pedidoProdutoColecao[t].ValorUnitario, pedidoProdutoColecao[t].Qtde, pedidoProdutoColecao[t].Cod_PedidoProduto, pedidoProdutoColecao[t].Tipo);
            }
            txtCodProduto.Enabled = true;
            txtQtde.Enabled = true;

            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtQtde.Text = "1";
            txtCodProduto.Focus();
        }
        private void carregarnoGrid()
        {
            try
            {
                if (txtCodPedido.Text == "")
                {
                    cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                    cls_produtoColecao produtoColecao = new cls_produtoColecao();

                    produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));
                    if (txtQtde.Text != "")
                    {
                        dgvPedido.Rows.Add(produtoColecao[0].Codigo.ToString(), produtoColecao[0].Nome.ToString(), string.Format("{0:C}", produtoColecao[0].Valor), txtQtde.Text);

                        valortotal = valortotal + Convert.ToDecimal(produtoColecao[0].Valor.ToString().Replace("R$", ""));

                        calculaValores();

                        txtCodProduto.Text = "";
                        txtProduto.Text = "";
                        txtQtde.Text = "1";
                        dgvPedido.Enabled = true;

                        txtCodProduto.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo Quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtQtde.Focus();
                    }
                }
                else
                {
                    //escolhas de edição
                    if (escolha == "E")
                    {
                        cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                        cls_produtoColecao produtoColecao = new cls_produtoColecao();
                        cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();

                        produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));

                        if (produtoColecao.Count > 0)
                        {
                            codpedprod = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[4].Value);

                            dgvPedido.Rows.Add(txtCodProduto.Text, txtProduto.Text, produtoColecao[0].Valor, txtQtde.Text, dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[4].Value);
                            dgvPedido.Enabled = true;
                            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);

                            calculaValores();

                            txtCodProduto.Text = "";
                            txtProduto.Text = "";
                            txtQtde.Text = "1";
                            dgvPedido.Enabled = false;

                            for (int t = 0; t < dgvPedido.Rows.Count; t++)
                            {
                                if (Convert.ToInt32(dgvPedido.Rows[t].Cells[4].Value) == codpedprod)
                                {
                                    dgvPedido.Rows[t].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                            }
                            codpedprod = 0;
                            txtCodProduto.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Produto não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema ou Produto inexistente, digite novamente! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProduto.Text = "";
                txtCodProduto.Focus();
            }

        }
        private void calculaValores()
        {
            if (dgvPedido.Rows.Count != 0 && txtQtde.Text != "")
            {
                decimal total = 0;

                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor != Color.Red)
                    {
                        total = total + (Convert.ToDecimal(dgvPedido.Rows[t].Cells[2].Value.ToString().Replace("R$", "")) * Convert.ToDecimal(dgvPedido.Rows[t].Cells[3].Value));
                    }
                }

                valortotal = 0;
            }
        }
        private void AtualizaBotoes()
        {
            cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();
            cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();

            for (int t = 1; t <= 40; t++)
            {
                pedidoColecao = pedidoNegocio.VerificacaoMesas(t);

                if (pedidoColecao[0].qtde > 0)
                {
                    instanciaDoForm.mesaOcupada(t);
                }
                else
                {
                    instanciaDoForm.mesaLivre(t);
                }
            }
        }
        private void cadastrarPedidoProduto(int codigoPedido)
        {
            try
            {
                cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();
                cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();

                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].Cells[4].Value.ToString() == "")
                    {
                        pedidoProduto.Cod_Pedido = codigoPedido;
                        pedidoProduto.Cod_Produto = Convert.ToInt32(dgvPedido.Rows[t].Cells[0].Value);
                        pedidoProduto.ValorUnitario = Convert.ToDouble(dgvPedido.Rows[t].Cells[2].Value.ToString().Replace("R$", ""));
                        pedidoProduto.Qtde = Convert.ToInt32(dgvPedido.Rows[t].Cells[3].Value);
                        pedidoProdutoNegocio.Inserir(pedidoProduto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique os Campos." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fechaCaixa()
        {
            try
            {
                cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
                cls_caixa caixa = new cls_caixa();

                caixa.Cod_Pedido = Convert.ToInt32(txtCodPedido.Text);
                caixa.ValorTotal = Convert.ToDouble(lblValorTotal.Text.ToString().Replace("R$", ""));
                caixa.Troco = Convert.ToDouble(lblTroco.Text.ToString().Replace("R$", ""));
                caixa.DataPagamento = DateTime.Now;
                caixaNegocio.Inserir(caixa);

                MessageBox.Show("Pagamento efetuado com sucesso!", "Pagamento Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar mesa. Aviso: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void saidaNovo()
        {
            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                cls_saida saida = new cls_saida();
                cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
                saida.Cod_Produto = Convert.ToInt32(dgvPedido.Rows[t].Cells[0].Value);
                saida.Qtde = Convert.ToInt32(dgvPedido.Rows[t].Cells[3].Value);
                saida.DataSaida = DateTime.Today.Date;
                saidaNegocio.Inserir(saida);
            }

        }
        private void atualizaProduto()
        {
            try
            {
                cls_produto produto = new cls_produto();
                cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                int qtdeProduto;

                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    produto.Codigo = Convert.ToInt32(dgvPedido.Rows[t].Cells[0].Value);
                    produtoColecao = produtoNegocio.TrazerQuantidade(produto.Codigo);

                    qtdeProduto = produtoColecao[0].QtdeAtual;
                    produto.QtdeAtual = qtdeProduto - Convert.ToInt32(dgvPedido.Rows[t].Cells[3].Value);
                    produtoNegocio.AlterarQtde(produto);

                    //MessageBox.Show("Qtde Atualizado " + t.ToString());
                    qtdeProduto = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Produto: Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void carregaCampos()
        {
            btnDeletar.Enabled = true;

            txtCodProduto.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[0].Value.ToString();
            txtProduto.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[1].Value.ToString();
            txtQtde.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value.ToString();
            lblCodPedProd.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[4].Value.ToString();

            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);

            dgvPedido.Refresh();


            dgvPedido.Enabled = false;
            txtCodProduto.Enabled = true;
            txtQtde.Enabled = true;

            calculaValores();
            txtCodProduto.Focus();
        }
        private void novoImprimeBalcao()
        {
            try
            {
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Blue && dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                    {
                        printDocNb.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                        printDocNb.DocumentName = "PedidoBalcao";

                        if (!printDocNb.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                        printDocNb.PrintPage += new PrintPageEventHandler(printDocNb_PrintPage);

                        printDocNb.Print();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir no Balcão. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void editaImprimeBalcao()
        {
            try
            {
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Yellow && dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                    {
                        printDocEb.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                        printDocEb.DocumentName = "EdicaoPedidoBalcao";

                        if (!printDocEb.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                        printDocEb.PrintPage += new PrintPageEventHandler(printDocEb_PrintPage);

                        printDocEb.Print();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir no Balcão. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void excluiImprimeBalcao()
        {
            try
            {
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Red && dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                    {
                        printDocEx.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                        printDocEx.DocumentName = "ExclusaoPedidoBalcao";

                        if (!printDocEx.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                        printDocEx.PrintPage += new PrintPageEventHandler(printDocEx_PrintPage);

                        printDocEx.Print();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir no Balcão. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void novoImprimeCozinha()
        {
            try
            {
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Blue && dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                    {
                        printDocNc.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                        printDocNc.DocumentName = "PedidoCozinha";

                        if (!printDocNc.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                        printDocNc.PrintPage += new PrintPageEventHandler(printDocNc_PrintPage);

                        printDocNc.Print();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir na Cozinha. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void editarImprimeCozinha()
        {
            try
            {
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Yellow && dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                    {
                        printDocEc.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                        printDocEc.DocumentName = "EdicaoPedidoCozinha";

                        if (!printDocEc.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                        printDocEc.PrintPage += new PrintPageEventHandler(printDocEc_PrintPage);

                        printDocEc.Print();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir na Cozinha. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void excluiImprimeCozinha()
        {
            try
            {
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Red && dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                    {
                        printDocExx.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                        printDocExx.DocumentName = "ExclusaoPedidoCozinha";

                        if (!printDocExx.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                        printDocExx.PrintPage += new PrintPageEventHandler(printDocExx_PrintPage);

                        printDocExx.Print();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir na Cozinha. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void excluiUmImprimeBalcao()
        {
            try
            {
                printDocExB.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                printDocExB.DocumentName = "ExclusaoUmPedidoBalcao";

                        if (!printDocExB.PrinterSettings.IsValid)
                            throw new Exception("Não foi possível localizar a impressora");

                printDocExB.PrintPage += new PrintPageEventHandler(printDocExB_PrintPage);

                        printDocExB.Print();
                        return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir na Cozinha. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void excluiUmImprimeCozinha()
        {
            try
            {
                printDocExC.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                printDocExC.DocumentName = "ExclusaoUmPedidoCozinha";

                if (!printDocExC.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocExC.PrintPage += new PrintPageEventHandler(printDocExC_PrintPage);

                printDocExC.Print();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir na Cozinha. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int novoPedido()
        {
            try
            {
                int codigoPedido;

                cls_pedido pedido = new cls_pedido();
                cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();
                pedido.Livre = false;
                pedido.NumeroMesa = Convert.ToInt32(txtCodMesa.Text);
                pedido.Cod_Garcon = 0;

                codigoPedido = Convert.ToInt32(pedidoNegocio.Inserir(pedido));

                return codigoPedido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique os Campos." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void imprimirBalcao()
        {
            try
            {
                printDocB.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                printDocB.DocumentName = "ComandaBalcao";

                if (!printDocB.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocB.PrintPage += new PrintPageEventHandler(printDocB_PrintPage);

                printDocB.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir no Balcão. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void imprimirCozinha()
        {
            try
            {
                printDocC.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                printDocC.DocumentName = "ComandaCozinha";

                if (!printDocC.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocC.PrintPage += new PrintPageEventHandler(printDocC_PrintPage);

                printDocC.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir no Balcão. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void salvanoGrid()
        {
            if (txtCodPedido.Text == "")
            {
                cls_produto produto = new cls_produto();
                cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));

                if (produtoColecao.Count != 0)
                {
                    double valorProduto = produtoColecao[0].Valor;
                    dgvNovoPedido.Rows.Add(txtCodProduto.Text, txtProduto.Text.ToUpper(), valorProduto, txtQtde.Text, "", produtoColecao[0].TipoUnidade);
                    txtCodProduto.Text = "";
                    txtProduto.Text = "";
                    txtQtde.Text = "1";

                    dgvNovoPedido.Enabled = true;
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
            else
            {
                cls_produto produto = new cls_produto();
                cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                produtoColecao = produtoNegocio.ConsultarPorCod(Convert.ToInt32(txtCodProduto.Text));
                double valorProduto = produtoColecao[0].Valor;

                if (lblCodPedProd.Text != "")
                {
                    codpedprod = Convert.ToInt32(lblCodPedProd.Text);
                    dgvNovoPedido.Rows.Add(txtCodProduto.Text, txtProduto.Text.ToUpper(), valorProduto, txtQtde.Text, codpedprod, produtoColecao[0].TipoUnidade);
                }
                else
                {
                    codpedprod = 0;
                    dgvNovoPedido.Rows.Add(txtCodProduto.Text, txtProduto.Text.ToUpper(), valorProduto, txtQtde.Text, "", produtoColecao[0].TipoUnidade);
                }

                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].Cells[4].Value.ToString() == "")
                    {
                        dgvPedido.Rows[t].DefaultCellStyle.BackColor = Color.Blue;
                        dgvPedido.Rows[t].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (Convert.ToInt32(dgvPedido.Rows[t].Cells[4].Value) == codpedprod)
                    {
                        dgvPedido.Rows[t].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
                escolha = "";
                dgvPedido.Enabled = true;

                txtCodProduto.Text = "";
                txtProduto.Text = "";
                txtQtde.Text = "1";
                txtCodProduto.Focus();
            }
        }
        private void frm_pedido_Load(object sender, EventArgs e)
        {
            calculaValores();
            txtCodProduto.Enabled = true;
            txtQtde.Enabled = true;

            txtCodProduto.Focus();
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
                    lblCodPedProd.Text = "";
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
                    lblCodPedProd.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha corretamente o campo Qtde. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProduto.Text != "")
                {
                    cls_produto produto = new cls_produto();
                    cls_produtoNegocio produtoNegocio = new cls_produtoNegocio();
                    cls_produtoColecao produtoColecao = new cls_produtoColecao();

                    produtoColecao = produtoNegocio.CarregaPorNome(txtProduto.Text);

                    txtCodProduto.Text = produtoColecao[0].Codigo.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    }
                    else
                    {
                        txtProduto.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtCodPedido.Text == "" && dgvPedido.Rows.Count != 0)
            {
                int codPed = novoPedido();

                cadastrarPedidoProduto(codPed);
                atualizaProduto();

                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                    {
                        imprimirBalcao();
                        break;
                    }
                }
                for (int t = 0; t < dgvPedido.Rows.Count; t++)
                {
                    if (dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                    {
                        imprimirCozinha();
                        break;
                    }
                }
                MessageBox.Show("Pedido Feito com Sucesso!", "Finalização do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                AtualizaBotoes();
            }
            else if (txtCodPedido.Text != "" && dgvPedido.Rows.Count != 0)
            {
                cadastrarPedidoProduto(Convert.ToInt32(txtCodPedido.Text));

                novoImprimeBalcao();
                editaImprimeBalcao();
                excluiImprimeBalcao();
                novoImprimeCozinha();
                editarImprimeCozinha();
                excluiImprimeCozinha();

                MessageBox.Show("Pedido Atualizado com Sucesso!", "Finalização do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                AtualizaBotoes();
            }
            else
            {
                MessageBox.Show("Não foi cadastrado nenhum produto na mesa " + txtCodMesa.Text);
            }
        }
        private void fecharMesa(int codigoPedido)
        {
            cls_pedido pedido = new cls_pedido();
            cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();

            try
            {
                if (MessageBox.Show("Deseja encerrar a mesa?", "Fechamento de Contas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pedido.Codigo = codigoPedido;
                    pedido.Cod_Garcon = 0;
                    pedido.Livre = true;
                    pedido.NumeroMesa = Convert.ToInt32(txtCodMesa.Text);
                    pedido.ValorPago = Convert.ToDouble(txtReceb.Text);

                    pedidoNegocio.Alterar(pedido);

                    MessageBox.Show("Mesa encerrada com sucesso!!");
                }
                else
                {
                    pedido.Codigo = codigoPedido;
                    pedido.Cod_Garcon = 0;
                    pedido.Livre = false;
                    pedido.NumeroMesa = Convert.ToInt32(txtCodMesa.Text);
                    pedido.ValorPago = Convert.ToDouble(txtReceb.Text);

                    pedidoNegocio.Alterar(pedido);

                    imprimeContaPaga();

                    MessageBox.Show("A mesa não foi fechada por haver mais pessoas!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um incidente ao fechar a mesa!", "Encerramento de Mesa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnFecharMesa_Click(object sender, EventArgs e)
        {
            try
            {
                double japago = 0;

                japago = Convert.ToDouble(lblValorPago.Text.Replace("R$", ""));

                frm_recebimento recebimento = new frm_recebimento(txtCodPedido.Text, lblValorTotal.Text, txtCodMesa.Text, japago);
                recebimento.ShowDialog();

                if (recebimento.cancela == false)
                {
                    txtReceb.Text = recebimento._valor.ToString();

                    if (txtReceb.Text == "")
                    {
                        MessageBox.Show("Digite um valor a ser pago e registrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtReceb.Focus();
                        return;
                    }

                    if (txtCodPedido.Text == "" && dgvPedido.Rows.Count != 0)
                    {
                        if (dgvPedido.Rows[0].Cells[4].Value.ToString() == "")
                        {
                            MessageBox.Show("Primeiro registre o pedido clicando no botão 'Finaliza Pedido'", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnFinalizar.Focus();
                            return;
                        }
                        int codPed = novoPedido();

                        cadastrarPedidoProduto(codPed);
                        atualizaProduto();

                        fecharMesa(codPed);
                        fechaCaixa();
                    }
                    else if (txtCodPedido.Text != "" && dgvPedido.Rows.Count != 0)
                    {
                        for (int t = 0; t < dgvPedido.Rows.Count; t++)
                        {
                            if (dgvPedido.Rows[t].Cells[4].Value.ToString() == "")
                            {
                                MessageBox.Show("Primeiro registre o pedido clicando no botão 'Finaliza Pedido'", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnFinalizar.Focus();
                                return;
                            }
                        }

                        fecharMesa(Convert.ToInt32(txtCodPedido.Text));
                        fechaCaixa();
                        saidaNovo();
                    }
                    AtualizaBotoes();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deletaPedidoProduto()
        {
            cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();
            cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();

            pedidoProduto.Cod_PedidoProduto = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[4].Value);
            pedidoProdutoNegocio.Excluir(pedidoProduto);
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Não há pedidos a serem excluidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Deseja excluir o produto selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvPedido.Rows[dgvPedido.CurrentRow.Index].DefaultCellStyle.BackColor == Color.Blue)
                {
                    dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                    return;
                }
                if (txtCodPedido.Text != "")
                {
                    if (dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[5].Value.ToString() == "B")
                    {
                        excluiUmImprimeBalcao();
                    }
                    else if (dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[5].Value.ToString() == "C")
                    {
                        excluiUmImprimeCozinha();
                    }

                    deletaPedidoProduto();
                    carregarnoInicio(Convert.ToInt32(txtCodMesa.Text));
                    calculaValores();

                    if (dgvPedido.Rows.Count == 0)
                    {
                        btnDeletar.Enabled = false;
                        lblValorTotal.Text = "R$ 0,00";
                        txtCodProduto.Focus();
                    }
                    MessageBox.Show("Os pedidos foram recarregados novamente. \nDigite os novos pedidos a serem feitos", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                    calculaValores();
                    txtCodProduto.Focus();
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            escolha = "E";
            try
            {
                if (txtCodPedido.Text == "")
                {
                    carregaCampos();
                }
                else
                {
                    carregaCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os campos! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                escolha = "";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnDeletar.Enabled = false;

            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtQtde.Text = "";

            txtCodProduto.Focus();

            dgvPedido.Enabled = true;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();
                cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();

                pedidoProduto.Cod_PedidoProduto = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[4].Value);
                pedidoProduto.Cod_Pedido = Convert.ToInt32(txtCodPedido.Text);
                pedidoProduto.Cod_Produto = Convert.ToInt32(txtCodProduto.Text);
                pedidoProduto.ValorUnitario = Convert.ToDouble(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[2].Value);
                pedidoProduto.Qtde = Convert.ToInt32(txtQtde.Text);

                pedidoProdutoNegocio.Alterar(pedidoProduto);

                MessageBox.Show("Alterado com Sucesso!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaGridInicio();
                btnDeletar.Enabled = false;
                dgvPedido.Enabled = true;
                txtQtde.Text = "1";
                calculaValores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar. Mensagem: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCancelardoid_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Cancelar os pedidos da mesa " + txtCodMesa.Text, "Cancelamento de Mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtCodPedido.Text != "")
                {
                    for (int t = 0; t < dgvPedido.Rows.Count; t++)
                    {
                        dgvPedido.Rows[t].DefaultCellStyle.BackColor = Color.Red;
                        cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();
                        cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();

                        pedidoProduto.Cod_PedidoProduto = Convert.ToInt32(dgvPedido.Rows[t].Cells[4].Value);
                        pedidoProdutoNegocio.Excluir(pedidoProduto);
                    }

                    cls_pedido pedido = new cls_pedido();
                    cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();
                    pedido.Codigo = Convert.ToInt32(txtCodPedido.Text);
                    pedidoNegocio.Excluir(pedido);

                    excluiImprimeBalcao();
                    excluiImprimeCozinha();
                    AtualizaBotoes();
                }
                this.Close();
            }
        }
        private void dgvPedido_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedido.Rows.Count != 0)
                {
                    btnDeletar.Enabled = true;
                    btnFinalizar.Enabled = true;
                    btnFecharMesa.Enabled = true;
                }
                else
                {
                    btnFinalizar.Enabled = false;
                    btnDeletar.Enabled = false;
                    btnFecharMesa.Enabled = false;
                    lblCodPedProd.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de erro! Aviso: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void dgvPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodProduto.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[0].Value.ToString();
                txtProduto.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[1].Value.ToString();
                txtQtde.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value.ToString();
                txtCodProduto.Enabled = true;
                txtProduto.Enabled = true;
                txtQtde.Enabled = true;
                dgvPedido.Enabled = false;
                escolha = "E";
                txtCodProduto.Focus();
                e.Handled = true;
            }
        }
        private void printDocB_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "   " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "   " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void btnImprimeConta_Click(object sender, EventArgs e)
        {
            try
            {
                //printDocX.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printDocX.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                printDocX.DocumentName = "Cupom";

                if (!printDocX.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocX.PrintPage += new PrintPageEventHandler(printDocX_PrintPage);
                printDocX.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir a Conta. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void printDocX_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-----------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("Qtde| Produto           | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                e.Graphics.DrawString(" " + dgvPedido.Rows[t].Cells[3].Value.ToString() + " " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = e.Graphics.MeasureString("Pedidos", pdvFont);
                currentUsedHeight += size.Height;

                e.Graphics.DrawString(Convert.ToDecimal(dgvPedido.Rows[t].Cells[2].Value).ToString("C"), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = e.Graphics.MeasureString("Pedidos", pdvFont);
                currentUsedHeight += size.Height;
            }

            e.Graphics.DrawString("-----------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("  Valor Total: " + lblValorTotal.Text, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("\n", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("   " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }
        private void printDocNb_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----NOVO--------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Blue && dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void printDocEb_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-EDITADO--------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Yellow && dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void printDocEx_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-CANCELAR-------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Red && dgvPedido.Rows[t].Cells[5].Value.ToString() == "B")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void printDocNc_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----NOVO--------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Blue && dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void printDocEc_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-EDITADO--------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Yellow && dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void printDocExx_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-CANCELAR-------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < dgvPedido.Rows.Count; t++)
            {
                if (dgvPedido.Rows[t].DefaultCellStyle.BackColor == Color.Red && dgvPedido.Rows[t].Cells[5].Value.ToString() == "C")
                {
                    e.Graphics.DrawString("   " + dgvPedido.Rows[t].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[t].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
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
        private void printDocExB_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-CANCELAR-------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("   " + dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pedidos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("                    " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }
        private void printDocExC_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("-CANCELAR-------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Qtde  |  Produto                | Valor", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("   " + dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value.ToString() + "  " + dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[1].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pedidos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("                    " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }
        private void txtReceb_TextChanged(object sender, EventArgs e)
        {
            double valor = 0;
            double receb = 0;
            double troco = 0;

            try
            {
                if (txtReceb.Text != "")
                {
                    receb = Convert.ToDouble(txtReceb.Text);
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
                txtReceb.Text = "";
            }
        }
        private void frm_pedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void printDocPago_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString("Pagamento Mesa " + txtCodMesa.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("---- PAGAMENTO -----", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("TOTAL PAGO: " + lblValorPago.Text, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pedidos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("--------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("                " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }
        private void imprimeContaPaga()
        {
            try
            {
                printDocPago.PrinterSettings.PrinterName = "POS58 10.0.0.6";
                printDocPago.DocumentName = "PagamentoCliente";

                if (!printDocB.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                printDocPago.PrintPage += new PrintPageEventHandler(printDocPago_PrintPage);

                printDocPago.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}