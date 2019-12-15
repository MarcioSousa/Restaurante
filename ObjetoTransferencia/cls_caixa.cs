using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class cls_caixa
    {
        public int Codigo { get; set; }
        public int Cod_Pedido { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorGarcon { get; set; }
        public double Troco { get; set; }
    }
}
