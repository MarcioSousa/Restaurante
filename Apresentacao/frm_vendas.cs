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
    public partial class frm_vendas : Form
    {
        public frm_vendas()
        {
            InitializeComponent();
            dgvResumoCaixa.AutoGenerateColumns = false;
        }
        private void frm_caixa_Load(object sender, EventArgs e)
        {
            carregaGrid();
            carregaGrafico();
            carregaTotal();
        }

        private void carregaTotal()
        {
            int qtde = dgvResumoCaixa.Rows.Count;
            double total = 0;

            if(qtde != 0)
            {
                for(int t = 0; t < qtde; t++)
                {
                    total = total + Convert.ToDouble(dgvResumoCaixa.Rows[t].Cells[3].Value);
                }
            }
            else
            {
                txtTotal.Text = "0,00";
            }
            txtTotal.Text = total.ToString("C2");
        }
        private void carregaGrid()
        {
            cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
            cls_caixaColecao caixaColecao = new cls_caixaColecao();

            caixaColecao = caixaNegocio.TodoRegistro();
            dgvResumoCaixa.DataSource = caixaColecao;

            dgvResumoCaixa.Update();
            dgvResumoCaixa.Refresh();
        }
        private string NomeMes(int mes)
        {
            string mesAtual = "";

            if (mes == 1)
            {
                mesAtual = "Jan";
            }
            else if (mes == 2)
            {
                mesAtual = "Fev";
            }
            else if (mes == 3)
            {
                mesAtual = "Mar";
            }
            else if (mes == 4)
            {
                mesAtual = "Abr";
            }
            else if (mes == 5)
            {
                mesAtual = "Mai";
            }
            else if (mes == 6)
            {
                mesAtual = "Jun";
            }
            else if (mes == 7)
            {
                mesAtual = "Jul";
            }
            else if (mes == 8)
            {
                mesAtual = "Ago";
            }
            else if (mes == 9)
            {
                mesAtual = "Set";
            }
            else if (mes == 10)
            {
                mesAtual = "Out";
            }
            else if (mes == 11)
            {
                mesAtual = "Nov";
            }
            else if (mes == 12)
            {
                mesAtual = "Dez";
            }

            return mesAtual;
        }

        private void cbsFiltro_CheckedChanged(object sender, EventArgs e)
        {
            carregaGridporData();
            carregaTotal();
        }
        private void carregaGridporData()
        {
            if (cbsFiltro.Checked == true)
            {
                cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
                cls_caixaColecao caixaColecao = new cls_caixaColecao();

                caixaColecao = caixaNegocio.PagamentosDia(dtpData.Value);
                dgvResumoCaixa.DataSource = caixaColecao;

                dgvResumoCaixa.Update();
                dgvResumoCaixa.Refresh();
            }else
            {
                carregaGrid();
            }
        }
        private void carregaGrafico()
        {
            try
            {
                DateTime tempo;
                int mes;
                string mesGrafico;

                tempo = DateTime.Now.AddMonths(-6);
                mes = tempo.Date.Month;

                chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                chart2.ChartAreas[0].AxisX.IsMarginVisible = false;

                for (int t = 7; t > 0; t--)
                {
                    double total = 0;
                    double troco = 0;
                    cls_caixaNegocio caixaNegocio = new cls_caixaNegocio();
                    cls_caixaColecao caixaColecao = new cls_caixaColecao();

                    caixaColecao = caixaNegocio.CarregaGrafico(mes);

                    for (int u = 0; u < caixaColecao.Count; u++)
                    {
                        total = total + caixaColecao[u].ValorTotal;
                        troco = troco + caixaColecao[u].Troco;
                    }

                    mesGrafico = NomeMes(mes);

                    chart1.Series["Venda"].Points.AddXY(mesGrafico.ToString(), total);
                    chart2.Series["Quebra"].Points.AddXY(mesGrafico.ToString(), troco);

                    tempo = tempo.AddMonths(1);
                    mes = tempo.Date.Month;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o gráfico. Mensagem: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            carregaGridporData();
            carregaTotal();
        }

        private void frm_vendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}