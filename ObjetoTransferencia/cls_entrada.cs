using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class cls_entrada
    {
        public int Codigo { get; set; }
        public int Cod_Produto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Qtde { get; set; }
        public double ValorTotal { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}
