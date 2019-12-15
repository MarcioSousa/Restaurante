using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class cls_tipoPag
    {
        public int Codigo { get; set; }
        public int Cod_Pedido { get; set; }
        public string TipoPagam { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagam { get; set; }
        public decimal Soma { get; set; }

    }
}