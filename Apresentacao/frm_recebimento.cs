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
    public partial class frm_recebimento : Form
    {
        public decimal _valor { get; set; }
        public bool cancela { get; set; }
        public frm_recebimento(string codPedido, string valorTotal, string mesa, double japago)
        {
            InitializeComponent();
            txtCodPedido.Text = codPedido;
            lblValorTotal.Text = valorTotal;
            lblJapago.Text = japago.ToString("C");
            txtMesa.Text = mesa;
        }
        private void frm_recebimento_Load(object sender, EventArgs e)
        {
            cbxForma.Text = "Dinheiro";
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            cancela = false;

            try
            {
                cls_tipoPagNegocio tipoPagNegocio = new cls_tipoPagNegocio();
                cls_tipoPag tipoPag = new cls_tipoPag();

                tipoPag.Cod_Pedido = Convert.ToInt32(txtCodPedido.Text);

                for (int t = 0; t < dgvPagamento.Rows.Count; t++)
                {
                    tipoPag.TipoPagam = dgvPagamento.Rows[t].Cells[2].Value.ToString();
                    tipoPag.Valor = Convert.ToDecimal(dgvPagamento.Rows[t].Cells[1].Value);
                    tipoPag.DataPagam = Convert.ToDateTime(dtpPagam.Value);

                    tipoPagNegocio.Inserir(tipoPag);
                }

                MessageBox.Show("Gravado com Sucesso!");

                _valor = Convert.ToDecimal(lblTotalPago.Text.Replace("Total Pago: R$", "")) + Convert.ToDecimal(lblJapago.Text.Replace("R$",""));

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não pode registrar o Pagamento. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void nudQtdePessoas_ValueChanged(object sender, EventArgs e)
        {
            if (nudQtdePessoas.Value > 0)
            {
                decimal valorTotal = 0;
                decimal faltante = 0;
                int qtdePessoas = 0;

                valorTotal = Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""));
                faltante = Convert.ToDecimal(lblJapago.Text.Replace("R$", ""));
                qtdePessoas = Convert.ToInt32(nudQtdePessoas.Value);
                

                lblValorIndividual.Text = ((valorTotal - faltante) / qtdePessoas).ToString("C");

                try
                {
                    if (txtValorPagamento.Text != "")
                    {
                        lblTroco.Text = (Convert.ToDecimal(txtValorPagamento.Text) - Convert.ToDecimal(lblValorIndividual.Text.Replace("R$", ""))).ToString("C");
                    }
                    else
                    {
                        lblTroco.Text = "R$ 0,00";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lblValorIndividual.Text = "R$ 0,00";
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cont = 0;

                if (dgvPagamento.Rows.Count != 0)
                {
                    cont = dgvPagamento.Rows.Count;
                    dgvPagamento.Rows.Add(cont + 1, Convert.ToDecimal(txtValorPagamento.Text), cbxForma.Text);
                    cont++;
                }
                else
                {
                    cont++;
                    dgvPagamento.Rows.Add(1, Convert.ToDecimal(txtValorPagamento.Text), cbxForma.Text);
                }

                carregaValorPago();
                txtValorPagamento.Text = "";
                cbxForma.Text = "Dinheiro";
                txtValorPagamento.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor incorreto, digite novamente um Valor de Pagamento." + ex.Message, "Valor incorreto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorPagamento.Text = "";
                txtValorPagamento.Focus();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPagamento.Rows.Count != 0)
            {
                int cont = 1;

                if (MessageBox.Show("Cancelar pagamento selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvPagamento.Rows.Remove(dgvPagamento.Rows[dgvPagamento.CurrentRow.Index]);

                    for (int t = 0; t < dgvPagamento.Rows.Count; t++)
                    {
                        if (Convert.ToInt32(dgvPagamento.Rows[t].Cells[0].Value) != cont)
                        {
                            dgvPagamento.Rows[t].Cells[0].Value = cont;
                        }
                        cont++;
                    }
                }
                carregaValorPago();
            }
            else
            {
                MessageBox.Show("´Não há pedidos pagos para serem excluidos!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void carregaValorPago()
        {
            decimal totalPago = 0;
            decimal valorTotal = 0;
            decimal japago = 0;

            japago = Convert.ToDecimal(lblJapago.Text.Replace("R$", ""));

            for(int t = 0; t < dgvPagamento.Rows.Count; t++)
            {
                totalPago = totalPago + Convert.ToDecimal(dgvPagamento.Rows[t].Cells[1].Value);
            }

            valorTotal = Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""));

            lblTotalPago.Text = "Total Pago: " + totalPago.ToString("C");
            lblFalta.Text = "Falta:            " + ((valorTotal - totalPago) - japago).ToString("C");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelando Pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cancela = true;
            this.Close();
        }
        private void txtValorPagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorPagamento.Text != "")
                {
                    lblTroco.Text = (Convert.ToDecimal(txtValorPagamento.Text) - Convert.ToDecimal(lblValorIndividual.Text.Replace("R$", ""))).ToString("C");
                }
                else
                {
                    lblTroco.Text = "R$ 0,00";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtValorPagamento_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (txtValorPagamento.Text == "")
                    {
                        MessageBox.Show("Digite um valor de pagamento, ex: 12,89", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void frm_recebimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}