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
    public class cls_pedidoProdutoNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();

        public string Inserir(cls_pedidoproduto pedidoProduto)
        {
            try
            {  
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO PEDIDO_PRODUTO(cod_pedido, cod_produto, valorunidprod, qtde) VALUES(" + pedidoProduto.Cod_Pedido + "," + pedidoProduto.Cod_Produto + "," + pedidoProduto.ValorUnitario.ToString().Replace(",", ".") + "," + pedidoProduto.Qtde + ") RETURNING cod_pedidoproduto").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_pedidoproduto pedidoProduto)
        {
            try
            {   
                acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE pedido_produto SET cod_produto = " + pedidoProduto.Cod_Produto + ", valorunidprod = " + pedidoProduto.ValorUnitario.ToString().Replace(",",".") + ", qtde = " + pedidoProduto.Qtde + " WHERE cod_pedidoproduto = " + pedidoProduto.Cod_PedidoProduto);
                return "Cadastro Alterado com Sucesso!!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AlterarQtde(cls_pedidoproduto pedidoProduto)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE pedido_produto SET qtde = " + pedidoProduto.Qtde + " WHERE cod_pedidoproduto = " + pedidoProduto.Cod_PedidoProduto);
                return "Cadastro Alterado com Sucesso!!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_pedidoproduto pedidoProduto)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM PEDIDO_PRODUTO WHERE cod_pedidoproduto = " + pedidoProduto.Cod_PedidoProduto);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cls_pedidoprodutoColecao CarregaGridPedido(int codigoPedido)
        {
            try
            {
                cls_pedidoprodutoColecao pedidoProdutoColecao = new cls_pedidoprodutoColecao();

                DataTable dataTablePedidoProduto = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT A.cod_produto, B.nome, A.valorunidprod, A.qtde, A.cod_pedidoproduto, B.tipounidade FROM pedido_produto A LEFT OUTER JOIN pedido P ON A.cod_pedido = P.codigo LEFT OUTER JOIN Produto B ON B.codigo = A.cod_produto WHERE A.cod_pedido = " + codigoPedido);
                foreach (DataRow linha in dataTablePedidoProduto.Rows)
                {
                    cls_pedidoproduto pedidoProduto = new cls_pedidoproduto();
                    pedidoProduto.Cod_Produto = Convert.ToInt32(linha["cod_produto"]);
                    pedidoProduto.Nome = Convert.ToString(linha["nome"]);
                    pedidoProduto.ValorUnitario = Convert.ToDouble(linha["valorunidprod"]);
                    pedidoProduto.Qtde = Convert.ToInt32(linha["qtde"]);
                    pedidoProduto.Cod_PedidoProduto = Convert.ToInt16(linha["cod_pedidoproduto"]);
                    pedidoProduto.Tipo = linha["tipounidade"].ToString();
                    pedidoProdutoColecao.Add(pedidoProduto);
                }
                return pedidoProdutoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos dos Pedidos.\nDetalhes: " + ex.Message);
            }
        }
    }
}