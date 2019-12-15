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
    public partial class frm_saida : Form
    {
        public frm_saida()
        {
            InitializeComponent();
            dgvSaida.AutoGenerateColumns = false;
        }

        private void frm_saida_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }
        private void carregaGrid()
        {
            cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
            cls_saidaColecao saidaColecao = new cls_saidaColecao();

            saidaColecao = saidaNegocio.SaidaColecao();

            dgvSaida.DataSource = null;
            dgvSaida.DataSource = saidaColecao;

            dgvSaida.Update();
            dgvSaida.Refresh();
        }
        private void dtpDataSaida_ValueChanged(object sender, EventArgs e)
        {
            if (cbxPorData.Checked == true)
            {
                cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
                cls_saidaColecao saidaColecao = new cls_saidaColecao();

                saidaColecao = saidaNegocio.SaidaPorData(dtpDataSaida.Value);

                dgvSaida.DataSource = null;
                dgvSaida.DataSource = saidaColecao;

                dgvSaida.Update();
                dgvSaida.Refresh();
            }
            else
            {
                cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
                cls_saidaColecao saidaColecao = new cls_saidaColecao();

                saidaColecao = saidaNegocio.SaidaColecao();

                dgvSaida.DataSource = null;
                dgvSaida.DataSource = saidaColecao;

                dgvSaida.Update();
                dgvSaida.Refresh();
            }
        }

        private void cbxPorData_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPorData.Checked == true)
            {
                cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
                cls_saidaColecao saidaColecao = new cls_saidaColecao();

                saidaColecao = saidaNegocio.SaidaPorData(dtpDataSaida.Value);

                dgvSaida.DataSource = null;
                dgvSaida.DataSource = saidaColecao;

                dgvSaida.Update();
                dgvSaida.Refresh();
            }
            else
            {
                cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();
                cls_saidaColecao saidaColecao = new cls_saidaColecao();

                saidaColecao = saidaNegocio.SaidaColecao();

                dgvSaida.DataSource = null;
                dgvSaida.DataSource = saidaColecao;

                dgvSaida.Update();
                dgvSaida.Refresh();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir a saída do produto selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cls_saida saida = new cls_saida();
                    cls_saidaNegocio saidaNegocio = new cls_saidaNegocio();


                    saida.Codigo = Convert.ToInt32(dgvSaida.Rows[dgvSaida.CurrentRow.Index].Cells[0].Value);
                    saidaNegocio.Excluir(saida);

                    MessageBox.Show("A saída foi excluida com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir a saída do produto. Aviso: " + ex.Message, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_saida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}