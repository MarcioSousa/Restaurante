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
    public class cls_caixaNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();
        public string Inserir(cls_caixa caixa)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO CAIXA(cod_pedido, valortotal, datapagam, valorgarcon, troco) VALUES(" + caixa.Cod_Pedido + ", " + caixa.ValorTotal.ToString().Replace(",", ".") + ",'" + caixa.DataPagamento.Date + "'," + caixa.ValorGarcon + "," + caixa.Troco.ToString().Replace(",", ".") + ") RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_caixa caixa)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE CAIXA SET cod_pedido = '" + caixa.Cod_Pedido + "', valortotal = " + caixa.ValorTotal + ", datapagam = " + caixa.DataPagamento + ", valorgarcon = " + caixa.ValorGarcon + ", troco = " + caixa.Troco + " WHERE codigo = " + caixa.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_caixa caixa)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM CAIXA WHERE codigo = " + caixa.Codigo);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cls_caixaColecao TodoRegistro()
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_caixaColecao caixaColecao = new cls_caixaColecao();

                DataTable dataTableCaixa = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, cod_pedido, valortotal, datapagam, valorgarcon, troco FROM CAIXA ORDER BY codigo");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableCaixa.Rows)
                {
                    //Criar um cliente vazio
                    cls_caixa caixa = new cls_caixa();

                    //Colocar os dados da linha nele                                              
                    caixa.Codigo = Convert.ToInt32(linha["codigo"]);
                    caixa.Cod_Pedido = Convert.ToInt32(linha["cod_pedido"]);
                    caixa.ValorTotal = Convert.ToDouble(linha["valortotal"]);
                    caixa.DataPagamento = Convert.ToDateTime(linha["datapagam"]);
                    caixa.ValorGarcon = Convert.ToInt32(linha["valorgarcon"]);
                    caixa.Troco = Convert.ToDouble(linha["troco"]);
                    //Adicionar ele na coleção                                                    
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
            }
        }
        public cls_caixaColecao PagamentosDia(DateTime dia)
        {
            try
            {
                cls_caixaColecao caixaColecao = new cls_caixaColecao();

                DataTable dataTableCaixa = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT datapagam, valortotal, troco FROM caixa WHERE datapagam = '" + dia + "'");

                foreach (DataRow linha in dataTableCaixa.Rows)
                {
                    cls_caixa caixa = new cls_caixa();
                    caixa.DataPagamento = Convert.ToDateTime(linha["datapagam"]);
                    caixa.ValorTotal = Convert.ToDouble(linha["valortotal"]);
                    caixa.Troco = Convert.ToDouble(linha["troco"]);
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
            }
        }
        public cls_caixaColecao CarregaGrafico(int mes)
        {
            try
            {
                cls_caixaColecao caixaColecao = new cls_caixaColecao();

                DataTable dataTableCaixa = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT datapagam, troco, valortotal, date_part('month', datapagam) AS Expr1 FROM caixa WHERE date_part('month', datapagam) = " + mes);

                foreach (DataRow linha in dataTableCaixa.Rows)
                {
                    cls_caixa caixa = new cls_caixa();
                    caixa.DataPagamento = Convert.ToDateTime(linha["datapagam"]);
                    caixa.ValorTotal = Convert.ToDouble(linha["valortotal"]);
                    caixa.Troco = Convert.ToDouble(linha["troco"]);
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
            }
        }
        public cls_caixaColecao Totais(DateTime dataAtual)
        {
            try
            {
                cls_caixaColecao caixaColecao = new cls_caixaColecao();

                DataTable dataTableCaixa = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT SUM(valortotal) As ValorTotal, SUM(troco) AS Troco FROM caixa WHERE datapagam = '" + dataAtual.Date + "'");

                foreach (DataRow linha in dataTableCaixa.Rows)
                {
                    cls_caixa caixa = new cls_caixa();

                    if (linha["ValorTotal"] is DBNull)
                    {
                        caixa.ValorTotal = 0;
                        caixa.Troco = 0;
                    }
                    else
                    {
                        caixa.ValorTotal = Convert.ToDouble(linha["ValorTotal"]);
                        caixa.Troco = Convert.ToDouble(linha["troco"]);
                    }
                    caixaColecao.Add(caixa);
                }
                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
            }
        }

    }
}
