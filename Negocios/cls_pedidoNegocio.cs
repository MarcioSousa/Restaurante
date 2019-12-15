using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class cls_pedidoNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();

        public string Inserir(cls_pedido pedido)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO PEDIDO(cod_garcon, livre, numeromesa, valorpago) VALUES(" + pedido.Cod_Garcon + "," + pedido.Livre + "," + pedido.NumeroMesa + "," + pedido.ValorPago + ") RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_pedido pedido)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE PEDIDO SET cod_garcon = " + pedido.Cod_Garcon + ", livre = " + pedido.Livre + ", numeromesa = " + pedido.NumeroMesa + ", valorpago = " + pedido.ValorPago + " WHERE codigo = " + pedido.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AlterarMesa(cls_pedido pedido)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE PEDIDO SET numeromesa = " + pedido.NumeroMesa + " WHERE codigo = " + pedido.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string RecebeValor(cls_pedido pedido)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE PEDIDO SET valorpago = " + pedido.ValorPago + " WHERE codigo = " + pedido.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_pedido pedido)
        {
            try
            {
                //"DELETE FROM produto WHERE codigo = @codigo
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM PEDIDO WHERE codigo = " + pedido.Codigo);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public cls_pedidoColecao TodoPedido()
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();

                DataTable dataTablePedido = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, cod_garcon, livre, numeromesa FROM PEDIDO");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    //Criar um cliente vazio
                    cls_pedido pedido = new cls_pedido();

                    //Colocar os dados da linha nele                                              
                    pedido.Codigo = Convert.ToInt32(linha["codigo"]);
                    pedido.Cod_Garcon = Convert.ToInt32(linha["cod_garcon"]);
                    pedido.Livre = Convert.ToBoolean(linha["livre"]);
                    pedido.NumeroMesa = Convert.ToInt32(linha["numeromesa"]);

                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }
        public cls_pedidoColecao VerificacaoMesas(int numeromesa)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();

                DataTable dataTablePedido = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT COUNT(*) as Qtde FROM pedido WHERE numeromesa = " + numeromesa + " AND livre = 'False'");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    //Criar um cliente vazio
                    cls_pedido pedido = new cls_pedido();

                    //Colocar os dados da linha nele             
                    pedido.qtde = Convert.ToInt32(linha["Qtde"]);
                   
                    pedidoColecao.Add(pedido);
                    break;
                }

                return pedidoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }
        public cls_pedidoColecao PedidosMesa(int mesa)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_pedidoColecao pedidoColecao = new cls_pedidoColecao();

                DataTable dataTablePedido = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, cod_garcon, livre, numeromesa, valorpago FROM pedido WHERE numeromesa = " + mesa + " AND livre = 'false'");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    //Criar um cliente vazio
                    cls_pedido pedido = new cls_pedido();

                    //Colocar os dados da linha nele                                              
                    pedido.Codigo = Convert.ToInt32(linha["codigo"]);
                    pedido.Cod_Garcon = Convert.ToInt32(linha["cod_garcon"]);
                    pedido.Livre = Convert.ToBoolean(linha["livre"]);
                    pedido.NumeroMesa = Convert.ToInt32(linha["numeromesa"]);
                    pedido.ValorPago = Convert.ToDouble(linha["valorpago"]);
                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }

    }
}
