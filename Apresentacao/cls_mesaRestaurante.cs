using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public class cls_mesaRestaurante
    {
        private int mesa;
        private int qtdePessoas;
        private bool situacao;
        private double totalFaturado;

        public int Mesa { get => mesa; set => mesa = value; }
        public int QtdePessoas { get => qtdePessoas; set => qtdePessoas = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public double TotalFaturado { get => totalFaturado; set => totalFaturado = value; }

        public cls_mesaRestaurante(int mesa, int qtdePessoas)
        {
            this.Mesa = mesa;
            this.QtdePessoas = qtdePessoas;
            this.Situacao = true;
            this.TotalFaturado = 0.00;
            MessageBox.Show("teste");
        }

        public void Reservar(int mesa)
        {

        }
        public double Liberar(int mesa)
        {
            return 0.00;
        }
        public bool GetSituacao()
        {
            return true;
        }
        public double GetTotalFaturado()
        {
            return 0.00;
        }
    }
}