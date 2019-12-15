using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class cls_pedidoproduto
    {
        public int Cod_PedidoProduto { get; set; }
        public int Cod_Pedido { get; set; }
        public int Cod_Produto { get; set; }
        public Double ValorUnitario { get; set; }
        public int Qtde { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int CodCaixa { get; set; }
    }
}
