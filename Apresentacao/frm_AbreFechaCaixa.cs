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
    public partial class Frm_AbreFechaCaixa: Form
    {
        public Frm_AbreFechaCaixa()
        {
            InitializeComponent();
        }
        private void TxtAbertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == Char.Parse(","))
                {
                    e.Handled = false;
                }
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                if (e.KeyChar == 13)
                {
                    if (TxtValorAbertura.Text == "")
                    {
                        MessageBox.Show("Digite um valor de abertura, ou digite '0'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    DtpData.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private string Valor(int qtde, double moeda)
        {
            string valorTotal;

            valorTotal = (qtde * moeda).ToString("C");

            return valorTotal;
        }
        private void CarregaValores()
        {
            cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
            cls_caixaColecao caixaColecao = new cls_caixaColecao();

            caixaColecao = caixaNegocio.Totais(DtpData.Value);

            LblTotalPagamento.Text = (caixaColecao[0].ValorTotal).ToString("C");
            LblTroco.Text = (caixaColecao[0].Troco).ToString("C");
            LblTotalVenda.Text = (caixaColecao[0].ValorTotal - caixaColecao[0].Troco).ToString("C");

        }
        private void CarregaCampos()
        {
            cls_fechamentoNegocio fechamentoNegocio = new cls_fechamentoNegocio();
            cls_fechamentoColecao fechamentoColecao = new cls_fechamentoColecao();

            fechamentoColecao = fechamentoNegocio.CarregaDados(DtpData.Value);

            if (fechamentoColecao.Count != 0)
            {
                TxtValorAbertura.Text = fechamentoColecao[0].ValorAbert.ToString("0.00");
                //lblTotalFecham.Text = fechamentoColecao[0].ValorFecham.ToString("C");
            }
            else
            {
                TxtValorAbertura.Text = "0,00";
                //lblTotalFecham.Text = "R$0,00";
            }

        }
        private bool VerificaRegistro()
        {
            cls_fechamentoNegocio fechamentoNegocio = new cls_fechamentoNegocio();
            cls_fechamentoColecao fechamentoColecao = new cls_fechamentoColecao();

            fechamentoColecao = fechamentoNegocio.CarregaDados(DtpData.Value);

            if (fechamentoColecao.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GravaFechamento()
        {
            try
            {
                double valor;
                valor = Convert.ToDouble(TxtValorAbertura.Text);

                cls_fechamentoNegocio fechamentoNegocio = new cls_fechamentoNegocio();
                cls_fechamento fechamento = new cls_fechamento
                {
                    DtFech = DtpData.Value,
                    ValorAbert = Convert.ToDouble(TxtValorAbertura.Text)
                };
                //fechamento.ValorFecham = Convert.ToDouble(lblTotalFecham.Text.Replace("R$", ""));

                fechamentoNegocio.Inserir(fechamento);
                MessageBox.Show("Gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar a Abertura de Caixa. Tente novamente. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtValorAbertura.Text = "";
                TxtValorAbertura.Focus();
            }
        }
        private void AtualizaFechamento()
        {
            try
            {
                double valor;
                valor = Convert.ToDouble(TxtValorAbertura.Text);

                cls_fechamentoNegocio fechamentoNegocio = new cls_fechamentoNegocio();
                cls_fechamento fechamento = new cls_fechamento
                {
                    DtFech = DtpData.Value,
                    ValorAbert = Convert.ToDouble(TxtValorAbertura.Text)
                };
                //fechamento.ValorFecham = Convert.ToDouble(lblTotalFecham.Text.Replace("R$", ""));

                fechamentoNegocio.Alterar(fechamento);
                MessageBox.Show("Gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar o Fechamento de Caixa. Tente novamente. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtValorAbertura.Text = "";
                TxtValorAbertura.Focus();
            }
        }
        private void CarregaFormasPagam()
        {
            cls_tipoPagColecao tipoPagColecao = new cls_tipoPagColecao();
            cls_tipoPagNegocio tipoPagNegocio = new cls_tipoPagNegocio();

            tipoPagColecao = tipoPagNegocio.CarregaTiposPagamentos(DtpData.Value);

            for(int t = 0; t < tipoPagColecao.Count; t++)
            {
                if(tipoPagColecao[t].TipoPagam == "Dinheiro")
                {
                    LblTotalDinheiro.Text = tipoPagColecao[t].Soma.ToString("C");
                }else if(tipoPagColecao[t].TipoPagam == "Cartão")
                {
                    LblTotalCartao.Text = tipoPagColecao[t].Soma.ToString("C");
                }else if(tipoPagColecao[t].TipoPagam == "Cheque")
                {
                    LblTotalCheque.Text = tipoPagColecao[t].Soma.ToString("C");
                }
            }
        }
        private void LimpaLists()
        {
            LblTotalPagamento.Text = "R$0,00";
            LblTroco.Text = "R$0,00";
            LblTotalVenda.Text = "R$0,00";
            LblTotalDinheiro.Text = "R$0,00";
            LblTotalCheque.Text = "R$0,00";
            LblTotalCartao.Text = "R$0,00";
            TxtValorAbertura.Text = "0,00";
            //lblTotalFecham.Text = "R$0,00";
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_AbreFechaCaixa_Load(object sender, EventArgs e)
        {
            CarregaValores();
            CarregaCampos();
            CarregaFormasPagam();
        }
        private void DtpData_ValueChanged(object sender, EventArgs e)
        {
            LblTotalDinheiro.Text = "R$0,00";
            LblTotalCheque.Text = "R$0,00";
            LblTotalCartao.Text = "R$0,00";

            CarregaValores();
            CarregaCampos();
            CarregaFormasPagam();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaRegistro())
            {
                AtualizaFechamento();
            }
            else
            {
                GravaFechamento();
            }
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            AtualizaFechamento();
        }
        private void Frm_AbreFechaCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Deseja deletar todos os dados registrados no momento?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cls_fechamentoNegocio fechamentoNegocio = new cls_fechamentoNegocio();
                    cls_fechamento fechamento = new cls_fechamento
                    {
                        DtFech = DtpData.Value
                    };

                    fechamentoNegocio.Excluir(fechamento);
                    MessageBox.Show("Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaLists();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}