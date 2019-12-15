using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class cls_pedido
    {
        public int Codigo { get; set; }
        public int Cod_Garcon { get; set; }
        public bool Livre { get; set; }
        public int NumeroMesa { get; set; }
        public int qtde { get; set; }
        public int Cod_Produto { get; set; }
        public double ValorPago { get; set; }
    }
}
