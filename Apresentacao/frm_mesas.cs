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
using System.IO;

namespace Apresentacao
{
    public partial class Frm_mesas : Form
    {
        int qtde = 0;

        public Frm_mesas()
        {
            InitializeComponent();
        }
        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMesaUm_Click(object sender, EventArgs e)
        {
            if (btnMesaUm.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 1, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 1, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesadois_Click(object sender, EventArgs e)
        {
            if (btnMesaDois.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 2, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 2, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatres_Click(object sender, EventArgs e)
        {
            if (btnMesaTres.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 3, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 3, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaquatro_Click(object sender, EventArgs e)
        {
            if (btnMesaQuatro.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 4, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 4, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesacinco_Click(object sender, EventArgs e)
        {
            if (btnMesaCinco.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 5, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 5, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaseis_Click(object sender, EventArgs e)
        {
            if (btnMesaSeis.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 6, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 6, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesasete_Click(object sender, EventArgs e)
        {
            if (btnMesaSete.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 7, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 7, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaoito_Click(object sender, EventArgs e)
        {
            if (btnMesaOito.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 8, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 8, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesanove_Click(object sender, EventArgs e)
        {
            if (btnMesaNove.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 9, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 9, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesadez_Click(object sender, EventArgs e)
        {
            if (btnMesaDez.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 10, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 10, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaOnze_Click(object sender, EventArgs e)
        {
            if (btnMesaOnze.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 11, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 11, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaDoze_Click(object sender, EventArgs e)
        {
            if (btnMesaDoze.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 12, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 12, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaTreze_Click(object sender, EventArgs e)
        {
            if (btnMesaTreze.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 13, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 13, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaQuatorze_Click(object sender, EventArgs e)
        {
            if (btnMesaQuatorze.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 14, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 14, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaQuinze_Click(object sender, EventArgs e)
        {
            if (btnMesaQuinze.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 15, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 15, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaDezesseis_Click(object sender, EventArgs e)
        {
            if (btnMesaDezesseis.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 16, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 16, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaDezessete_Click(object sender, EventArgs e)
        {
            if (btnMesaDezessete.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 17, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 17, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaDezoito_Click(object sender, EventArgs e)
        {
            if (btnMesaDezoito.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 18, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 18, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaDezenove_Click(object sender, EventArgs e)
        {
            if (btnMesaDezenove.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 19, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 19, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaVinte_Click(object sender, EventArgs e)
        {
            if (btnMesaVinte.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 20, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 20, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavUm_Click(object sender, EventArgs e)
        {
            if (btnMesavUm.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 21, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 21, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavDois_Click(object sender, EventArgs e)
        {
            if (btnMesavDois.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 22, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 22, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavTres_Click(object sender, EventArgs e)
        {
            if (btnMesavTres.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 23, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 23, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavQuatro_Click(object sender, EventArgs e)
        {
            if (btnMesavQuatro.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 24, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 24, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavCinco_Click(object sender, EventArgs e)
        {
            if (btnMesavCinco.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 25, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 25, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavSeis_Click(object sender, EventArgs e)
        {
            if (btnMesavSeis.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 26, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 26, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavSete_Click(object sender, EventArgs e)
        {
            if (btnMesavSete.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 27, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 27, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavOito_Click(object sender, EventArgs e)
        {
            if (btnMesavOito.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 28, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 28, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesavNove_Click(object sender, EventArgs e)
        {
            if (btnMesavNove.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 29, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 29, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaTrinta_Click(object sender, EventArgs e)
        {
            if (btnMesaTrinta.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 30, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 30, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatUm_Click(object sender, EventArgs e)
        {
            if (btnMesatUm.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 31, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 31, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatDois_Click(object sender, EventArgs e)
        {
            if (btnMesatDois.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 32, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 32, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatTres_Click(object sender, EventArgs e)
        {
            if (btnMesatTres.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 33, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 33, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatQuatro_Click(object sender, EventArgs e)
        {
            if (btnMesatQuatro.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 34, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 34, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatCinco_Click(object sender, EventArgs e)
        {
            if (btnMesatCinco.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 35, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 35, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatSeis_Click(object sender, EventArgs e)
        {
            if (btnMesatSeis.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 36, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 36, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatSete_Click(object sender, EventArgs e)
        {
            if (btnMesatSete.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 37, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 37, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatOito_Click(object sender, EventArgs e)
        {
            if (btnMesatOito.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 38, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 38, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesatNove_Click(object sender, EventArgs e)
        {
            if (btnMesatNove.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 39, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 39, "ocupado");
                Pedidos.ShowDialog();
            }
        }
        private void btnMesaQuarenta_Click(object sender, EventArgs e)
        {
            if (btnMesaQuarenta.Image == pbxLivre.Image)
            {
                frm_pedido Pedidos = new frm_pedido(this, 40, "livre");
                Pedidos.ShowDialog();
            }
            else
            {
                frm_pedido Pedidos = new frm_pedido(this, 40, "ocupado");
                Pedidos.ShowDialog();
            }
        }

        public void mesaOcupada(int botao)
        {
            if (botao == 1)
            {
                btnMesaUm.Image = pbxOcupado.Image;
            }
            else if (botao == 2)
            {
                btnMesaDois.Image = pbxOcupado.Image;
            }
            else if (botao == 3)
            {
                btnMesaTres.Image = pbxOcupado.Image;
            }
            else if (botao == 4)
            {
                btnMesaQuatro.Image = pbxOcupado.Image;
            }
            else if (botao == 5)
            {
                btnMesaCinco.Image = pbxOcupado.Image;
            }
            else if (botao == 6)
            {
                btnMesaSeis.Image = pbxOcupado.Image;
            }
            else if (botao == 7)
            {
                btnMesaSete.Image = pbxOcupado.Image;
            }
            else if (botao == 8)
            {
                btnMesaOito.Image = pbxOcupado.Image;
            }
            else if (botao == 9)
            {
                btnMesaNove.Image = pbxOcupado.Image;
            }
            else if (botao == 10)
            {
                btnMesaDez.Image = pbxOcupado.Image;
            }
            else if (botao == 11)
            {
                btnMesaOnze.Image = pbxOcupado.Image;
            }
            else if (botao == 12)
            {
                btnMesaDoze.Image = pbxOcupado.Image;
            }
            else if (botao == 13)
            {
                btnMesaTreze.Image = pbxOcupado.Image;
            }
            else if (botao == 14)
            {
                btnMesaQuatorze.Image = pbxOcupado.Image;
            }
            else if (botao == 15)
            {
                btnMesaQuinze.Image = pbxOcupado.Image;
            }
            else if (botao == 16)
            {
                btnMesaDezesseis.Image = pbxOcupado.Image;
            }
            else if (botao == 17)
            {
                btnMesaDezessete.Image = pbxOcupado.Image;
            }
            else if (botao == 18)
            {
                btnMesaDezoito.Image = pbxOcupado.Image;
            }
            else if (botao == 19)
            {
                btnMesaDezenove.Image = pbxOcupado.Image;
            }
            else if (botao == 20)
            {
                btnMesaVinte.Image = pbxOcupado.Image;
            }
            else if (botao == 21)
            {
                btnMesavUm.Image = pbxOcupado.Image;
            }
            else if (botao == 22)
            {
                btnMesavDois.Image = pbxOcupado.Image;
            }
            else if (botao == 23)
            {
                btnMesavTres.Image = pbxOcupado.Image;
            }
            else if (botao == 24)
            {
                btnMesavQuatro.Image = pbxOcupado.Image;
            }
            else if (botao == 25)
            {
                btnMesavCinco.Image = pbxOcupado.Image;
            }
            else if (botao == 26)
            {
                btnMesavSeis.Image = pbxOcupado.Image;
            }
            else if (botao == 27)
            {
                btnMesavSete.Image = pbxOcupado.Image;
            }
            else if (botao == 28)
            {
                btnMesavOito.Image = pbxOcupado.Image;
            }
            else if (botao == 29)
            {
                btnMesavNove.Image = pbxOcupado.Image;
            }
            else if (botao == 30)
            {
                btnMesaTrinta.Image = pbxOcupado.Image;
            }
            else if (botao == 31)
            {
                btnMesatUm.Image = pbxOcupado.Image;
            }
            else if (botao == 32)
            {
                btnMesatDois.Image = pbxOcupado.Image;
            }
            else if (botao == 33)
            {
                btnMesatTres.Image = pbxOcupado.Image;
            }
            else if (botao == 34)
            {
                btnMesatQuatro.Image = pbxOcupado.Image;
            }
            else if (botao == 35)
            {
                btnMesatCinco.Image = pbxOcupado.Image;
            }
            else if (botao == 36)
            {
                btnMesatSeis.Image = pbxOcupado.Image;
            }
            else if (botao == 37)
            {
                btnMesatSete.Image = pbxOcupado.Image;
            }
            else if (botao == 38)
            {
                btnMesatOito.Image = pbxOcupado.Image;
            }
            else if (botao == 39)
            {
                btnMesatNove.Image = pbxOcupado.Image;
            }
            else if (botao == 40)
            {
                btnMesaQuarenta.Image = pbxOcupado.Image;
            }
        }
        public void mesaLivre(int botao)
        {
            if (botao == 1)
            {
                btnMesaUm.Image = pbxLivre.Image;
            }
            else if (botao == 2)
            {
                btnMesaDois.Image = pbxLivre.Image;
            }
            else if (botao == 3)
            {
                btnMesaTres.Image = pbxLivre.Image;
            }
            else if (botao == 4)
            {
                btnMesaQuatro.Image = pbxLivre.Image;
            }
            else if (botao == 5)
            {
                btnMesaCinco.Image = pbxLivre.Image;
            }
            else if (botao == 6)
            {
                btnMesaSeis.Image = pbxLivre.Image;
            }
            else if (botao == 7)
            {
                btnMesaSete.Image = pbxLivre.Image;
            }
            else if (botao == 8)
            {
                btnMesaOito.Image = pbxLivre.Image;
            }
            else if (botao == 9)
            {
                btnMesaNove.Image = pbxLivre.Image;
            }
            else if (botao == 10)
            {
                btnMesaDez.Image = pbxLivre.Image;
            }
            else if (botao == 11)
            {
                btnMesaOnze.Image = pbxLivre.Image;
            }
            else if (botao == 12)
            {
                btnMesaDoze.Image = pbxLivre.Image;
            }
            else if (botao == 13)
            {
                btnMesaTreze.Image = pbxLivre.Image;
            }
            else if (botao == 14)
            {
                btnMesaQuatorze.Image = pbxLivre.Image;
            }
            else if (botao == 15)
            {
                btnMesaQuinze.Image = pbxLivre.Image;
            }
            else if (botao == 16)
            {
                btnMesaDezesseis.Image = pbxLivre.Image;
            }
            else if (botao == 17)
            {
                btnMesaDezessete.Image = pbxLivre.Image;
            }
            else if (botao == 18)
            {
                btnMesaDezoito.Image = pbxLivre.Image;
            }
            else if (botao == 19)
            {
                btnMesaDezenove.Image = pbxLivre.Image;
            }
            else if (botao == 20)
            {
                btnMesaVinte.Image = pbxLivre.Image;
            }
            else if (botao == 21)
            {
                btnMesavUm.Image = pbxLivre.Image;
            }
            else if (botao == 22)
            {
                btnMesavDois.Image = pbxLivre.Image;
            }
            else if (botao == 23)
            {
                btnMesavTres.Image = pbxLivre.Image;
            }
            else if (botao == 24)
            {
                btnMesavQuatro.Image = pbxLivre.Image;
            }
            else if (botao == 25)
            {
                btnMesavCinco.Image = pbxLivre.Image;
            }
            else if (botao == 26)
            {
                btnMesavSeis.Image = pbxLivre.Image;
            }
            else if (botao == 27)
            {
                btnMesavSete.Image = pbxLivre.Image;
            }
            else if (botao == 28)
            {
                btnMesavOito.Image = pbxLivre.Image;
            }
            else if (botao == 29)
            {
                btnMesavNove.Image = pbxLivre.Image;
            }
            else if (botao == 30)
            {
                btnMesaTrinta.Image = pbxLivre.Image;
            }
            else if (botao == 31)
            {
                btnMesatUm.Image = pbxLivre.Image;
            }
            else if (botao == 32)
            {
                btnMesatDois.Image = pbxLivre.Image;
            }
            else if (botao == 33)
            {
                btnMesatTres.Image = pbxLivre.Image;
            }
            else if (botao == 34)
            {
                btnMesatQuatro.Image = pbxLivre.Image;
            }
            else if (botao == 35)
            {
                btnMesatCinco.Image = pbxLivre.Image;
            }
            else if (botao == 36)
            {
                btnMesatSeis.Image = pbxLivre.Image;
            }
            else if (botao == 37)
            {
                btnMesatSete.Image = pbxLivre.Image;
            }
            else if (botao == 38)
            {
                btnMesatOito.Image = pbxLivre.Image;
            }
            else if (botao == 39)
            {
                btnMesatNove.Image = pbxLivre.Image;
            }
            else if (botao == 40)
            {
                btnMesaQuarenta.Image = pbxLivre.Image;
            }
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produto produto = new frm_produto();
            produto.ShowDialog();
        }
        private void frm_principal_Load(object sender, EventArgs e)
        {
            verificarMesas();
        }
        private void verificarMesas()
        {
            cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();
            cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();

            for (int t = 1; t <= 40; t++)
            {
                pedidoColecao = pedidoNegocio.VerificacaoMesas(t);

                if (pedidoColecao[0].qtde > 0)
                {
                    mesaOcupada(t);
                }
                else
                {
                    mesaLivre(t);
                }
            }
        }
        private void menuEstoque_Click(object sender, EventArgs e)
        {
            frm_estoque estoque = new frm_estoque();
            estoque.ShowDialog();
        }
        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_produto produto = new frm_produto();
            produto.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_estoque estoque = new frm_estoque();
            estoque.ShowDialog();
        }
        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frm_caixa caixa = new frm_caixa();
            caixa.ShowDialog();
        }
        private void btnHistCaixa_Click(object sender, EventArgs e)
        {
            frm_vendas resumoCaixa = new frm_vendas();
            resumoCaixa.ShowDialog();
        }
        private void verificaCodPedido()
        {
            try
            {
                cls_pedidoProdutoNegocio pedidoProdutoNegocio = new cls_pedidoProdutoNegocio();
                cls_pedidoprodutoColecao pedidoProdutoColecao = new cls_pedidoprodutoColecao();

                qtde = pedidoProdutoColecao.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o Pedido" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_produto produto = new frm_produto();
            produto.ShowDialog();
        }
        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_saida saida = new frm_saida();
            saida.ShowDialog();
        }
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sobre sobre = new frm_sobre();
            sobre.ShowDialog();
        }
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTrocaMesa_Click(object sender, EventArgs e)
        {
            gbxTrocaMesa.Visible = true;
            nupMesaAtual.Focus();
        }
        private bool verificaMesa(int qtde)
        {
            if (qtde == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nupMesaAtual.Value == nupNovaMesa.Value)
                {
                    MessageBox.Show("Digite numero de mesas diferentes nos campos", "Mesas Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();
                cls_pedidoNegocio pedidoNegocio = new cls_pedidoNegocio();

                pedidoColecao = pedidoNegocio.VerificacaoMesas(Convert.ToInt32(nupMesaAtual.Value));
                bool mesaAtual = verificaMesa(pedidoColecao[0].qtde);

                pedidoColecao = pedidoNegocio.VerificacaoMesas(Convert.ToInt32(nupNovaMesa.Value));
                bool novaMesa = verificaMesa(pedidoColecao[0].qtde);

                if (mesaAtual != false)
                {
                    MessageBox.Show("Coloque o número da mesa Atual que esteja ocupada no momento!\nPois ela está livre e não pode ser feito a troca!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nupMesaAtual.Focus();
                    return;
                }

                if (novaMesa == false)
                {
                    MessageBox.Show("Escolha uma mesa que esteja livre nesse momento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nupNovaMesa.Focus();
                    return;
                }

                if (mesaAtual == false && novaMesa == true)
                {
                    cls_pedidoColecao pedidoColecaoc = new cls_pedidoColecao();
                    cls_pedidoNegocio pedidoNegocioc = new cls_pedidoNegocio();
                    cls_pedido pedido = new cls_pedido();

                    pedidoColecaoc = pedidoNegocioc.PedidosMesa(Convert.ToInt32(nupMesaAtual.Value));

                    pedido.Codigo = pedidoColecaoc[0].Codigo;
                    pedido.NumeroMesa = Convert.ToInt32(nupNovaMesa.Value);

                    pedidoNegocioc.AlterarMesa(pedido);

                    MessageBox.Show("Mesa alterada com sucesso!", "Alteração de Mesa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    verificarMesas();
                    gbxTrocaMesa.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro na alteração, contate o desenvolvedor! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCancela_Click(object sender, EventArgs e)
        {
            gbxTrocaMesa.Visible = false;
            nupMesaAtual.Value = 1;
            nupNovaMesa.Value = 1;
        }

        private void frm_mesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }

}
